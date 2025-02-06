//! Mathematical helpers.

#[cfg(not(all(target_family = "unix", target_pointer_width = "64")))]
const INT_LOG2_TABLE_256: [i8; 256] = {
    let mut table = [-1i8; 256];
    
    // Initialize first values manually
    table[0] = -1;
    table[1] = 0;
    table[2] = 1;
    table[3] = 1;
    
    // Fill in groups of 2s
    table[4] = 2;
    table[5] = 2;
    table[6] = 2;
    table[7] = 2;
    
    // Fill in groups of 3s
    table[8] = 3;
    table[9] = 3;
    table[10] = 3;
    table[11] = 3;
    table[12] = 3;
    table[13] = 3;
    table[14] = 3;
    table[15] = 3;
    
    // Fill in groups of 4s through 7s using macro-like repetition
    let mut i = 16;
    while i < 32 {
        table[i] = 4;
        i += 1;
    }
    while i < 64 {
        table[i] = 5;
        i += 1;
    }
    while i < 128 {
        table[i] = 6;
        i += 1;
    }
    while i < 256 {
        table[i] = 7;
        i += 1;
    }
    
    table
};

#[cfg(not(all(target_family = "unix", target_pointer_width = "64")))]
pub fn int_log2(n: u32) -> i8 {
    INT_LOG2_TABLE_256[n as usize]
}

#[cfg(all(target_family = "unix", target_pointer_width = "64"))]
pub fn int_log2(n: u32) -> i8 {
    // On 64-bit Unix systems, we can use the built-in leading zeros count
    if n == 0 {
        -1
    } else {
        (31 - n.leading_zeros()) as i8
    }
}