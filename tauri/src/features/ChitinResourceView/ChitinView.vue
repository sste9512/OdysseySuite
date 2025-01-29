<template>
    <div class="chitin-view">
        <div class="desk">


            <div class="name">
                <v-breadcrumbs :items="path.split(/[/\\]/).map(item => ({
                    title: item || 'Root',
                    disabled: false
                }))"></v-breadcrumbs>
            </div>



            <!-- Page header showing key information about the Chitin Key file -->
            <a-page-header title="Chitin Key" sub-title="Resource Index File" :ghost="false"
                style="background-color: transparent; padding: 10px;">
                <!-- Action buttons for file operations -->
                <template #extra>
                    <v-btn key="3">Export As</v-btn>
                    <v-btn key="2">View Relationships</v-btn>
                    <v-btn key="1" color="primary">Save</v-btn>
                </template>

                <!-- Statistics display showing key metadata from the file header -->
                <div style="display: flex; flex-direction: row; gap: 16px;">
                    <!-- File version identifier -->
                    <a-statistic title="File Version" :value="header?.file_version" />
                    <!-- Number of BIF (Binary Index File) entries -->
                    <a-statistic title="BIF Count" :value="header?.bif_count" />
                    <!-- Total number of resource keys -->
                    <a-statistic title="Key Count" :value="header?.key_count" />
                    <!-- Byte offset to the file table in the KEY file -->
                    <a-statistic title="Offset to File Table" :value="header?.offset_to_file_table" />
                    <!-- Byte offset to the key table in the KEY file -->
                    <a-statistic title="Offset to Key Table" :value="header?.offset_to_key_table" />
                    <!-- Build year of the KEY file -->
                    <a-statistic title="Build Year" :value="header?.build_year" />
                    <!-- Build day of the KEY file -->
                    <a-statistic title="Build Day" :value="header?.build_day" />
                </div>
            </a-page-header>




            <a-tabs>
                <a-tab-pane key="1" :tab="`Key Entries (${chitinData?.length || 0})`">
                    <v-data-table :headers="[
                        { title: 'Resref', key: 'resref' },
                        { title: 'Resource Type', key: 'resource_type' },
                        { title: 'Resource ID', key: 'res_id' }
                    ]" :items="chitinData" :height="400" fixed-header>
                        <template v-slot:item.resref="{ item }">
                            {{ item.resref }}
                        </template>
                        <template v-slot:item.resource_type="{ item }">
                            {{ getResourceTypeName(item.resource_type) }}
                        </template>
                        <template v-slot:item.res_id="{ item }">
                            {{ item.res_id }}

                        </template>
                    </v-data-table>
                </a-tab-pane>

                <a-tab-pane key="2" :tab="`File Entries (${fileEntries?.length || 0})`">
                    <v-data-table :headers="fileColumns" :items="fileEntries" :height="400" fixed-header>
                        <template v-slot:item.filename="{ item }">
                            {{ item.file_size }}
                        </template>
                        <template v-slot:item.file_size="{ item }">
                            {{ item.file_size }}
                        </template>
                        <template v-slot:item.drives="{ item }">
                            {{ item.drives }}
                        </template>
                        <template v-slot:item.filename_offset="{ item }">
                            {{ item.filename_offset }}
                        </template>
                    </v-data-table>
                </a-tab-pane>

                <a-tab-pane key="3" :tab="`Filenames (${filenameEntries?.length || 0})`">
                    <v-data-table :headers="filenameColumns" :items="filenameEntries" :height="400" fixed-header>
                        <template v-slot:item.filename="{ item }">
                            {{ item }}
                        </template>
                    </v-data-table>
                </a-tab-pane>
            </a-tabs>

        </div>
    </div>
</template>

<script lang="ts">
import { defineComponent, onMounted, ref } from 'vue';
import { AuroraService } from '@/data/aurora-service';
import { KeyHeader, KeyEntry } from '@/data/chitin-key';
import { FileEntry, FilenameEntry } from '@/data/chitin-key';
import { ResourceType } from '@/data/resource_identification';




export default defineComponent({
    name: 'ChitinView',
    props: {
        path: {
            type: String,
            required: false,
            default: 'E:/SteamLibrary/steamapps/common/swkotor/chitin.key'
        }
    },
    setup(props) {
        const chitinData = ref<KeyEntry[]>([]);
        const loading = ref(false);
        const header = ref<KeyHeader | null>(null);
        const fileEntries = ref<FileEntry[]>([]);
        

        const filenameEntries = ref<string[]>([]);

        const fileColumns = [
            {
                title: 'Filename',
                dataIndex: 'filename',
                key: 'filename',
                width: '40%'
            },
            {
                title: 'File Size',
                dataIndex: 'file_size',
                key: 'file_size',
                width: '30%'
            },
            {
                title: 'Drives',
                dataIndex: 'drives',
                key: 'drives',
                width: '30%'
            },
            {
                title: 'Filename Offset',
                dataIndex: 'filename_offset',
                key: 'filename_offset',
                width: '30%'
            }
        ];
        const filenameColumns = [
            {
                title: 'Filename',
                dataIndex: 'filename',
                key: 'filename',
                width: '100%'
            }
        ];


        const columns = [
            {
                title: 'Resource Reference',
                dataIndex: 'resref',
                key: 'resref',
                width: '40%'
            },
            {
                title: 'Resource Type',
                dataIndex: 'resource_type',
                key: 'resource_type',
                width: '30%'
            },
            {
                title: 'Resource ID',
                dataIndex: 'res_id',
                key: 'res_id',
                width: '30%'
            }
        ];

        const getResourceTypeName = (type: number) => {
            return ResourceType[type] || type;
        };

        const loadChitinData = async () => {
            try {
                loading.value = true;
                const auroraService = new AuroraService();
                const path = props.path;
                const result = await auroraService.readChitinKey(path);
                console.log(result.filenames);
                if (result) {
                    chitinData.value = result.key_entries;
                    header.value = result.header;
                    fileEntries.value = result.file_entries;
                    filenameEntries.value = result.filenames;
                }
            } catch (error) {
                console.error('Error loading chitin data:', error);
            } finally {
                loading.value = false;
            }
        };

        onMounted(async () => {
            await loadChitinData();
        });

        return {
            chitinData,
            loading,
            columns,
            header,
            fileEntries,
            filenameEntries,
            fileColumns,
            filenameColumns,
            props,
            loadChitinData,
            getResourceTypeName
        };
    }
});

</script>

<style scoped lang="scss">
.chitin-view {
    :deep(.v-breadcrumbs) {
        padding: 0;
        
        .v-breadcrumbs-item {
            color: rgba(255, 255, 255, 0.65);
            font-size: 14px;
            
            &--disabled {
                opacity: 0.5;
            }
            
            &:hover:not(.v-breadcrumbs-item--disabled) {
                color: rgba(255, 255, 255, 0.85);
            }
        }

        .v-breadcrumbs-divider {
            color: rgba(255, 255, 255, 0.45);
            padding: 0 8px;
        }
    }

    :deep(.ant-tabs) {
        .ant-tabs-nav {
            margin-bottom: 16px;
            border-bottom: 1px solid rgba(255, 255, 255, 0.1);

            .ant-tabs-tab {
                color: rgba(255, 255, 255, 0.65);
                background: transparent;
                border: none;
                margin-right: 24px;
                padding: 8px 0;

                &:hover {
                    color: rgba(255, 255, 255, 0.85);
                }

                &.ant-tabs-tab-active {
                    .ant-tabs-tab-btn {
                        color: #4a9eff;
                    }
                }
            }

            .ant-tabs-ink-bar {
                background: #4a9eff;
            }
        }

        .ant-tabs-content {
            color: rgba(255, 255, 255, 0.85);
        }
    }

    :deep(.ant-page-header) {
        background: transparent;
        padding: 16px 24px;

        .ant-page-header-heading-title {
            color: rgba(255, 255, 255, 0.85);
            font-size: 20px;
            font-weight: 500;
        }

        .ant-page-header-heading-sub-title {
            color: rgba(255, 255, 255, 0.65);
        }

        .ant-page-header-back-button {
            color: rgba(255, 255, 255, 0.65);

            &:hover {
                color: rgba(255, 255, 255, 0.85);
            }
        }
    }


    :deep(.ant-table) {
        background: transparent;

        .ant-table-thead>tr>th {
            background: rgba(30, 30, 40, 0.7);
            color: white;
            border-bottom: 1px solid rgba(255, 255, 255, 0.1);
        }

        .ant-table-tbody>tr>td {
            background: rgba(20, 20, 30, 0.5);
            color: white;
            font-size: 12px;
            padding: 8px;
            border-bottom: none;
        }

        .ant-table-tbody>tr:hover>td {
            background: rgba(40, 40, 50, 0.7);
        }

        .ant-table-cell {
            border: none;
        }

        .ant-table-pagination {
            .ant-pagination-item {
                background: rgba(30, 30, 40, 0.7);
                border-color: rgba(255, 255, 255, 0.1);

                a {
                    color: rgb(83, 80, 80);
                }

                &-active {
                    background: #4a9eff;
                    border-color: #4a9eff;

                    a {
                        color: white;
                    }
                }
            }
        }
    }

    :deep(.ant-statistic) {
        .ant-statistic-title {
            color: rgba(255, 255, 255, 0.85);
            font-size: 14px;
            margin-bottom: 4px;
        }

        .ant-statistic-content {
            color: rgba(255, 255, 255, 0.65);
            font-size: 24px;

            .ant-statistic-content-value {
                display: inline-block;
            }

            .ant-statistic-content-suffix {
                margin-left: 4px;
            }
        }
    }

    height: 100%;

    padding: 15px 15px 15px 15px;

    .desk {
        background: rgba(0, 0, 0, 0.3);
        border-radius: 8px;
        padding: 25px 25px 30px 30px;
        border: 0.4px solid rebeccapurple;
        box-shadow: 0 0 5px 0 rgba(0, 0, 0, 0.5);
    }


    .pad {
        padding: 15px;
    }

    .titles {
        display: flex;
        align-items: center;
        margin-bottom: 15px;

        &.blue {
            color: #4a9eff;
        }

        .icon {
            width: 24px;
            height: 24px;
            margin-right: 10px;
        }

        .title {
            font-size: 18px;
            font-weight: 500;

            .subtitle {
                font-size: 12px;
                opacity: 0.7;
            }
        }
    }


}
</style>
