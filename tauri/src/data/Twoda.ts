import { Result } from "@/models/Result";
import { invoke } from "@tauri-apps/api/core";

/**
 * Represents a single cell value in a 2DA table
 */
export type TwodaCellValue = string | number | null;

/**
 * Represents a single row in a 2DA table
 */
export interface TwodaRow {
    index: number;
    values: Map<string, TwodaCellValue>;
}

/**
 * Represents the header information of a 2DA file
 */
export interface TwodaHeader {
    version: string;
    defaultValue: string | null;
}

/**
 * Represents a complete 2DA (Two-Dimensional Array) file
 * Used in Aurora Engine games for storing tabular data
 */
export class Twoda {
    header: TwodaHeader;
    columns: string[];
    rows: TwodaRow[];

    constructor(header: TwodaHeader, columns: string[], rows: TwodaRow[]) {
        this.header = header;
        this.columns = columns;
        this.rows = rows;
    }

    /**
     * Gets a cell value by row index and column name
     */
    getCell(rowIndex: number, columnName: string): TwodaCellValue | undefined {
        const row = this.rows.find(r => r.index === rowIndex);
        return row?.values.get(columnName);
    }

    /**
     * Gets a row by its index
     */
    getRow(rowIndex: number): TwodaRow | undefined {
        return this.rows.find(r => r.index === rowIndex);
    }

    /**
     * Gets the number of rows in the table
     */
    get rowCount(): number {
        return this.rows.length;
    }

    /**
     * Gets the number of columns in the table
     */
    get columnCount(): number {
        return this.columns.length;
    }
}

/**
 * API class for reading and writing 2DA files
 */
export class TwodaApi {
    /**
     * Reads a 2DA file from the specified path
     * @param path - Path to the 2DA file
     * @returns Promise resolving to the parsed Twoda data
     */
    async readTwoda(path: string): Promise<Result<Twoda>> {
        try {
            const twoda = await invoke<Twoda>('read_twoda', { path });
            return { ok: true, value: twoda };
        } catch (error) {
            return { ok: false, error: error as Error };
        }
    }

    // /**
    //  * Reads a 2DA file from raw bytes
    //  * @param data - Raw byte data of the 2DA file
    //  * @returns Promise resolving to the parsed Twoda data
    //  */
    // async readTwodaFromBytes(data: Uint8Array): Promise<Result<Twoda>> {
    //     try {
    //         const twoda = await invoke<Twoda>('read_twoda_from_bytes', { data: Array.from(data) });
    //         return { ok: true, value: twoda };
    //     } catch (error) {
    //         return { ok: false, error: error as Error };
    //     }
    // }

    // /**
    //  * Writes a 2DA file to the specified path
    //  * @param path - Path where to write the file
    //  * @param twoda - The 2DA data to write
    //  * @returns Promise resolving to void on success
    //  */
    // async writeTwoda(path: string, twoda: Twoda): Promise<Result<void>> {
    //     try {
    //         await invoke('write_twoda', { path, twoda });
    //         return { ok: true, value: undefined };
    //     } catch (error) {
    //         return { ok: false, error: error as Error };
    //     }
    // }

    // /**
    //  * Gets 2DA data from a container file (BIFF, ERF, RIM) at specified offset and size
    //  * @param path - Path to the container file
    //  * @param offset - Offset in the file where 2DA data starts
    //  * @param size - Size of the 2DA data in bytes
    //  * @returns Promise resolving to the parsed Twoda data
    //  */
    // async getTwodaFromFile(path: string, offset: number, size: number): Promise<Result<Twoda>> {
    //     try {
    //         const twoda = await invoke<Twoda>('get_twoda_from_file', { path, offset, size });
    //         return { ok: true, value: twoda };
    //     } catch (error) {
    //         return { ok: false, error: error as Error };
    //     }
    // }
}

export const twodaApi = new TwodaApi();
