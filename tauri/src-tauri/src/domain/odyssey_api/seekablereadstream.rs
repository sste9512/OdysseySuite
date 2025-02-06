use std::io::{self, Read, Seek, SeekFrom};
use std::error::Error;
use std::convert::TryInto;


// Constants corresponding to the original C++ values
const K_EOF: u32 = 0xFFFFFFFFu32;
const K_SIZE_INVALID: usize = usize::MAX;
const K_POSITION_INVALID: usize = usize::MAX;

/// Basic trait for readable data streams
pub trait ReadStream {
    fn eos(&self) -> bool; // Check if the stream has reached end-of-file

    /// Read data from the stream
    fn read(&mut self, data: &mut [u8]) -> usize;

    /// Read and ensure the exact amount of data is retrieved, otherwise return an error
    fn read_checked(&mut self, data: &mut [u8]) -> Result<(), Box<dyn Error>> {
        if self.read(data) != data.len() {
            return Err("Read error".into());
        }
        Ok(())
    }

    /// Read a single unsigned byte
    fn read_byte(&mut self) -> Result<u8, Box<dyn Error>> {
        let mut buf = [0u8];
        self.read_checked(&mut buf)?;
        Ok(buf[0])
    }

    /// Reads the next character or return K_EOF at EOF
    fn read_char(&mut self) -> u32 {
        self.read_byte().map(|b| b as u32).unwrap_or(K_EOF)
    }

    /// Read little-endian 16-bit unsigned integer
    fn read_u16_le(&mut self) -> Result<u16, Box<dyn Error>> {
        let mut buf = [0u8; 2];
        self.read_checked(&mut buf)?;
        Ok(u16::from_le_bytes(buf))
    }

    /// Read little-endian 32-bit unsigned integer
    fn read_u32_le(&mut self) -> Result<u32, Box<dyn Error>> {
        let mut buf = [0u8; 4];
        self.read_checked(&mut buf)?;
        Ok(u32::from_le_bytes(buf))
    }

    /// Read little-endian 64-bit unsigned integer
    fn read_u64_le(&mut self) -> Result<u64, Box<dyn Error>> {
        let mut buf = [0u8; 8];
        self.read_checked(&mut buf)?;
        Ok(u64::from_le_bytes(buf))
    }

    /// Read big-endian 16-bit unsigned integer
    fn read_u16_be(&mut self) -> Result<u16, Box<dyn Error>> {
        let mut buf = [0u8; 2];
        self.read_checked(&mut buf)?;
        Ok(u16::from_be_bytes(buf))
    }

    /// Read big-endian 32-bit unsigned integer
    fn read_u32_be(&mut self) -> Result<u32, Box<dyn Error>> {
        let mut buf = [0u8; 4];
        self.read_checked(&mut buf)?;
        Ok(u32::from_be_bytes(buf))
    }

    /// Read big-endian 64-bit unsigned integer
    fn read_u64_be(&mut self) -> Result<u64, Box<dyn Error>> {
        let mut buf = [0u8; 8];
        self.read_checked(&mut buf)?;
        Ok(u64::from_be_bytes(buf))
    }
}

/// Extend `ReadStream` with seekable functionality
pub trait SeekableReadStream: ReadStream + Read + Seek {
    fn pos(&self) -> usize; // Get current position
    fn size(&self) -> usize; // Get size of the stream
    fn seek(&mut self, offset: i64, origin: SeekFrom) -> usize; // Seek to position
}

/// Struct providing substream functionality
pub struct SubReadStream<R: ReadStream> {
    parent: R,
    end: usize,
    current_pos: usize,
    eos: bool,
}

impl<R: ReadStream + Seek + Read> SubReadStream<R> {
    pub fn new(mut parent: R, end: usize) -> Result<Self, Box<dyn Error>> {
        let current_pos = 0; // This assumes the parent stream is at position 0. Adjust if needed.
        Ok(Self {

            parent,
            end,
            current_pos,
            eos: false,
        })
    }
}

impl<R: ReadStream> ReadStream for SubReadStream<R> {
    fn eos(&self) -> bool {
        self.eos
    }

    fn read(&mut self, data: &mut [u8]) -> usize {
        let remaining = self.end - self.current_pos;
        let to_read = data.len().min(remaining);
        let bytes_read = self.parent.read(&mut data[..to_read]);
        self.current_pos += bytes_read;
        if self.current_pos >= self.end {
            self.eos = true;
        }
        bytes_read
    }
}

/// A seekable substream attached to a parent
pub struct SeekableSubReadStream<R: SeekableReadStream> {
    parent: R,
    begin: usize,
    end: usize,
    current_pos: usize,
}

impl<R: SeekableReadStream + Seek + Read> SeekableSubReadStream<R> {
    pub fn new(
        mut parent: R,
        begin: usize,
        end: usize,
    ) -> Result<Self, Box<dyn Error>> {
        Seek::seek(&mut parent, SeekFrom::Start(begin as u64))?;
        Ok(Self {
            parent,
            begin,
            end,
            current_pos: begin,
        })
    }
}

impl<R: SeekableReadStream> Read for SeekableSubReadStream<R> {
    fn read(&mut self, buf: &mut [u8]) -> io::Result<usize> {
        let remaining = self.end - self.current_pos;
        let to_read = buf.len().min(remaining);
        let bytes_read = ReadStream::read(&mut self.parent, &mut buf[..to_read]);
        self.current_pos += bytes_read;
        Ok(bytes_read)
    }
}

impl<R: SeekableReadStream> ReadStream for SeekableSubReadStream<R> {
    fn eos(&self) -> bool {
        self.current_pos >= self.end
    }

    fn read(&mut self, data: &mut [u8]) -> usize {
        let remaining = self.end - self.current_pos;
        let to_read = data.len().min(remaining);
        let bytes_read = ReadStream::read(&mut self.parent, &mut data[..to_read]);
        self.current_pos += bytes_read;
        bytes_read
    }
}

impl<R: SeekableReadStream> Seek for SeekableSubReadStream<R> {
    fn seek(&mut self, pos: SeekFrom) -> io::Result<u64> {
        let new_pos = match pos {
            SeekFrom::Start(offset) => self.begin as u64 + offset,
            SeekFrom::Current(offset) => self.current_pos as u64 + offset as u64,
            SeekFrom::End(offset) => self.end as u64 + offset as u64,
        };
        if new_pos < self.begin as u64 || new_pos > self.end as u64 {
            return Err(io::Error::new(io::ErrorKind::InvalidInput, "Seek out of bounds"));
        }
        self.current_pos = Seek::seek(&mut self.parent, SeekFrom::Start(new_pos))? as usize;
        Ok(new_pos)
    }
}

impl<R: SeekableReadStream> SeekableReadStream for SeekableSubReadStream<R> {
    fn pos(&self) -> usize {
        self.current_pos - self.begin
    }

    fn size(&self) -> usize {
        self.end - self.begin
    }

    fn seek(&mut self, offset: i64, origin: SeekFrom) -> usize {
        if let Ok(pos) = Seek::seek(self, origin) {
            self.current_pos = pos as usize;
        }
        self.current_pos
    }
}