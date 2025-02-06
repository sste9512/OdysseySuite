use std::collections::VecDeque;
use std::io;
use serde::{Deserialize, Serialize};

#[derive(Debug, Default, Serialize, Deserialize)]
pub struct Rim {
    pub entry_count: i32,
    pub off_key_list: i32,
    pub key_entry_list: VecDeque<RimKeyEntry>,
    pub data: Vec<u8>,
    pub ascii_encoding: (),
}

const ITEM_ENTRY_COUNT_OFFSET: usize = 12;
const ITEM_OFF_KEY_LIST_OFFSET: usize = 16;
const ITEM_RESOURCE_NAME_LENGTH: usize = 16;
const ITEM_SHORT_VALUE_OFFSET: usize = 32;

impl Rim {
    pub fn new(input_data: Vec<u8>) -> Self {
        let mut rim = Rim {
            entry_count: 0,
            off_key_list: 0,
            key_entry_list: VecDeque::new(),
            data: input_data,
            ascii_encoding: (),
        };
        rim.entry_count = rim.calculate_integer_value(ITEM_ENTRY_COUNT_OFFSET);
        rim.off_key_list = rim.calculate_integer_value(ITEM_OFF_KEY_LIST_OFFSET);
        rim.key_entry_list = VecDeque::with_capacity(rim.entry_count as usize);
        rim.populate_key_entries();
        rim
    }

    fn populate_key_entries(&mut self) {
        for index in 0..self.entry_count {
            self.key_entry_list
                .push_back(self.create_rim_key_entry(index));
        }
    }

    fn create_rim_key_entry(&self, index: i32) -> RimKeyEntry {
        let resource_name = self.get_resource_name(index);
        let resource_type = self.calculate_short_value(
            (self.off_key_list + index * ITEM_SHORT_VALUE_OFFSET as i32 + 16) as usize,
        );
        let resource_id = self.calculate_short_value(
            (self.off_key_list + index * ITEM_SHORT_VALUE_OFFSET as i32 + 18) as usize,
        );
        let offset = self.calculate_integer_value(
            (self.off_key_list + index * ITEM_SHORT_VALUE_OFFSET as i32 + 24) as usize,
        );
        let length = self.calculate_integer_value(
            (self.off_key_list + index * ITEM_SHORT_VALUE_OFFSET as i32 + 28) as usize,
        );

        RimKeyEntry::new(
            resource_name,
            resource_type,
            resource_id,
            offset,
            length,
            index,
        )
    }

    pub fn read_resource_data(&self, resource_id: u32) -> io::Result<Vec<u8>> {
        // Convert u32 resource_id to i16 since that's what we store
        let resource_id = i16::try_from(resource_id).map_err(|_| {
            io::Error::new(
                io::ErrorKind::InvalidInput,
                "Resource ID too large for i16"
            )
        })?;

        // Find the key entry with matching resource_id
        let key_entry = self.key_entry_list.iter().find(|entry| {
            entry.resource_id == resource_id
        }).ok_or_else(|| {
            io::Error::new(
                io::ErrorKind::NotFound,
                format!("Resource with ID {} not found", resource_id)
            )
        })?;

        // Get the data using the found key entry's index
        let data = self.get_rim_resource(key_entry.index as usize);
        Ok(data)
    }

    fn calculate_integer_value(&self, start_index: usize) -> i32 {
        ((self.data[start_index] as i32)
            + (self.data[start_index + 1] as i32) * 256
            + (self.data[start_index + 2] as i32) * 65536
            + (self.data[start_index + 3] as i32) * 16777216)
    }

    fn calculate_short_value(&self, start_index: usize) -> i16 {
        ((self.data[start_index] as i16) + ((self.data[start_index + 1] as i16) * 256))
    }

    fn get_resource_name(&self, index: i32) -> String {
        let mut resource_name_bytes = vec![0; ITEM_RESOURCE_NAME_LENGTH];
        let base_index = self.off_key_list as usize + index as usize * ITEM_SHORT_VALUE_OFFSET;
        resource_name_bytes
            .clone_from_slice(&self.data[base_index..base_index + ITEM_RESOURCE_NAME_LENGTH]);

        let mut length = 0;
        while length < ITEM_RESOURCE_NAME_LENGTH && resource_name_bytes[length] != 0 {
            length += 1;
        }

        String::from_utf8_lossy(&resource_name_bytes[..length]).to_string()
    }

    pub fn get_rim_resource(&self, index: usize) -> Vec<u8> {
        let key_entry = &self.key_entry_list[index];
        let mut destination_array = vec![0; key_entry.length as usize];
        destination_array.copy_from_slice(
            &self.data[key_entry.offset as usize..(key_entry.offset + key_entry.length) as usize],
        );
        destination_array
    }
}

#[derive(Debug, Default, Serialize, Deserialize)]
pub struct RimKeyEntry {
    pub resource_name: String,
    pub resource_type: i16,
    pub resource_id: i16,
    pub offset: i32,
    pub length: i32,
    pub index: i32,
}

impl RimKeyEntry {
    pub fn new(
        resource_name: String,
        resource_type: i16,
        resource_id: i16,
        offset: i32,
        length: i32,
        index: i32,
    ) -> Self {
        RimKeyEntry {
            resource_name,
            resource_type,
            resource_id,
            offset,
            length,
            index,
        }
    }
}
