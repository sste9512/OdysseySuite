using System.Diagnostics;

namespace AuroraParsers.AuroraParsers
{
    public class WaveObject
    {
        private byte[] bytes;
        private AudioType audioType = AudioType.Unknown;

        private readonly BinaryReader _binaryReader;
        private AuroraFile file;

        public int Offset = 58;

        public enum AudioType
        {
            Unknown,
            WAVE,
            MP3
        }

        /// <summary>
        /// Represents an audio wave object parser that determines the file type of an audio file, extracts its data,
        /// and provides functionality for external playback. The WaveObject class works with binary data to identify
        /// file headers and interpret the content appropriately.
        /// </summary>
        /// <remarks>
        /// Validates and supports recognition of audio types such as WAVE and MP3 by checking specific file markers.
        /// Manages offsets based on the file type and retrieves a playable byte stream.
        /// The class utilizes an AuroraFile instance to read binary content and interacts with an external player for file playback.
        /// </remarks>
        public WaveObject(AuroraFile file)
        {
            this.file = file;
            this.file.Open();
            _binaryReader = file.GetReader();

            try
            {
                // Check for real WAVE file
                _binaryReader.BaseStream.Position = 470; // Set position for WAVE check
                string riff = new string(_binaryReader.ReadChars(4)); // Read 4 characters
                if (riff == "RIFF") // Validate if WAVE file
                {
                    Offset = 470;
                    audioType = AudioType.WAVE;
                    Debug.WriteLine("Found: " + riff); // Log success
                }
                else
                {
                    Debug.WriteLine(riff); // Log unsuccessful detection
                }
            }
            catch (Exception ex)
            {
                audioType = AudioType.WAVE; // Fallback to WAVE type in case of an error
                Debug.WriteLine(ex.ToString()); // Log exception
            }

            // Check for 'data' marker in file
            _binaryReader.BaseStream.Position = 32; // Set position for data check
            string data = new string(_binaryReader.ReadChars(4)); // Read 4 characters
            if (data == "data") // Validate 'data' marker
            {
                Offset = 32;
                // audioType = AudioType.WAVE; // Uncomment if necessary
                Debug.WriteLine("Found: " + data); // Log success
            }

            // Check for real MP3 file, first position
            _binaryReader.BaseStream.Position = 199; // Set position for MP3 check
            string lame = new string(_binaryReader.ReadChars(4)); // Read 4 characters
            if (lame == "LAME") // Validate if MP3 file
            {
                Offset = 199;
                audioType = AudioType.MP3;
                Debug.WriteLine("Found: " + lame); // Log success
            }
            else
            {
                Debug.WriteLine(lame); // Log unsuccessful detection
            }

            // Check for real MP3 file, second position
            _binaryReader.BaseStream.Position = 200; // Set position for secondary MP3 check
            lame = new string(_binaryReader.ReadChars(4)); // Read 4 characters
            if (lame == "LAME") // Validate if MP3 file
            {
                Offset = 200;
                audioType = AudioType.MP3;
                Debug.WriteLine(lame); // Log success
            }

            file.Close(); // Close the file as we are done reading data
        }

        public byte[] getPlayableByteStream()
        {
            file.Open();

            byte[] data;
            using (var br = file.GetReader())
            {
                br.BaseStream.Position = Offset;
                data = br.ReadBytes((int)br.BaseStream.Length - Offset);
            }

            file.Close();

            return data;
        }

        public AudioType getType()
        {
            return audioType;
        }

        public static void PlayInExternalPlayer(AuroraFile file)
        {
            WaveObject audio = new WaveObject(file);

            //byte[] bytes = audio.getPlayableByteStream();

            MemoryStream dataStream = new MemoryStream(audio.getPlayableByteStream());

            switch (audio.getType())
            {
                case AudioType.WAVE:
                    Debug.WriteLine("Playing: WAV");
                    //simpleSound = new SoundPlayer(dataStream);
                    //simpleSound.Play();

                    FileStream fsW = new FileStream("test.wav", FileMode.Create, FileAccess.Write);
                    BinaryWriter bwW = new BinaryWriter(fsW);
                    bwW.Write(audio.getPlayableByteStream());
                    bwW.Close();
                    fsW.Close();

                    Process.Start("test.wav");

                    break;
                case AudioType.MP3:
                default:
                    Debug.WriteLine("Playing: MP3");

                    FileStream fs = new FileStream("test.mp3", FileMode.Create, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(audio.getPlayableByteStream());
                    bw.Close();
                    fs.Close();

                    Process.Start("test.mp3");

                    //Mp3FileReader mp3 = new Mp3FileReader(dataStream);
                    //WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(mp3);
                    //simpleSound = new SoundPlayer(pcm);
                    //File.WriteAllBytes("test.mp3", audio.getPlayableByteStream());
                    break;
            }
        }
    }
}