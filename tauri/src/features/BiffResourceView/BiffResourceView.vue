<template>
    <div class="biff-view">
        <div class="desk">
            <div class="name">
                <a-breadcrumb style="color: white">
                    <a-breadcrumb-item>File Path</a-breadcrumb-item>
                    <a-breadcrumb-item>biff</a-breadcrumb-item>
                    <a-breadcrumb-item>{{ filePath.split('/').pop() }}</a-breadcrumb-item>
                </a-breadcrumb>
            </div>

            <a-page-header :title="filePath.split('/').pop()" sub-title="BIFF Resource File" :ghost="false"
                style="background-color: transparent; padding: 10px;">
                <template #extra>
                    <v-btn key="3">Export As</v-btn>
                    <v-btn key="2">View Relationships</v-btn>
                    <v-btn key="1" color="primary">Save</v-btn>
                </template>

                <div style="display: flex; flex-direction: row; gap: 16px;">
                    <a-statistic title="File Type" :value="biffHeader.file_type" />
                    <a-statistic title="File Version" :value="biffHeader.file_version" />
                    <a-statistic title="Variable Resources" :value="biffHeader.variable_resource_count" />
                    <a-statistic title="Fixed Resources" :value="biffHeader.fixed_resource_count" />
                </div>
            </a-page-header>

            <a-tabs>
                <a-tab-pane key="1" tab="Variable Resources">
                    <v-data-table :headers="variableHeaders" :items="variableResources" :height="400" fixed-header>
                        <template v-slot:item.data="{ item }">
                            <v-btn size="small" color="primary" @click="viewResourceData(item)">
                                View Data
                            </v-btn>
                        </template>
                    </v-data-table>
                </a-tab-pane>

                <a-tab-pane key="2" tab="Fixed Resources">
                    <v-data-table :headers="fixedHeaders" :items="fixedResources" :height="400" fixed-header>
                        <template v-slot:item.data="{ item }">
                            <v-btn size="small" color="primary" @click="viewResourceData(item)">
                                View Data
                            </v-btn>
                        </template>
                    </v-data-table>
                </a-tab-pane>
            </a-tabs>

        </div>
    </div>
</template>

<script lang="ts">
import { defineComponent, ref, onMounted } from 'vue';
import { BiffHeader, VResourceEntry, FResourceEntry } from '@/data/biff';
import { AuroraService } from '@/data/aurora-service';

export default defineComponent({
    name: 'BiffResourceView',
    props: {
        filePath: {
            type: String,
            required: true
        }
    },
    setup(props) {
        const biffHeader = ref<BiffHeader>(new BiffHeader());
        const variableResources = ref<VResourceEntry[]>([]);
        const fixedResources = ref<FResourceEntry[]>([]);
        const activeTab = ref('variable');

        const variableHeaders = [
            { title: 'ID', key: 'id' },
            { title: 'Offset', key: 'offset' },
            { title: 'File Size', key: 'fileSize' },
            { title: 'Resource Type', key: 'resourceType' },
            { title: 'Actions', key: 'data' }
        ];

        const fixedHeaders = [
            { title: 'ID', key: 'id' },
            { title: 'Offset', key: 'offset' },
            { title: 'Part Count', key: 'partCount' },
            { title: 'File Size', key: 'fileSize' },
            { title: 'Resource Type', key: 'resourceType' },
            { title: 'Actions', key: 'data' }
        ];

        const viewResourceData = (resource: VResourceEntry | FResourceEntry) => {
            console.log('Viewing resource data:', resource);
            // Implement resource data viewing logic
        };

        const auroraService = new AuroraService();

        const loadBiffData = async () => {
            try {
                const result = await auroraService.readBiffFile(props.filePath);
                if (result.ok) {
                    biffHeader.value = result.value.header;
                    variableResources.value = result.value.variable_resources;
                    fixedResources.value = result.value.fixed_resources;
                } else {    
                    console.error('Failed to load BIFF data:', result.error);
                }
            } catch (error) {
                console.error('Error loading BIFF data:', error);
            }
        };

        onMounted(async () => {
            await loadBiffData();
        });

        return {
            biffHeader,
            variableResources,
            fixedResources,
            activeTab,
            variableHeaders,
            fixedHeaders,
            viewResourceData,
            props,
            loadBiffData
        };
    }
});
</script>

<style scoped>
.biff-view {
.v-data-table {
    margin-top: 1rem;
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
