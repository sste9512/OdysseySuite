import {defineStore} from 'pinia';
import {useLoggingStore} from "@/state/logging-store";


interface TabViewState {
    id: string; // Unique identifier for each tab
    title: string,
    isSelected: boolean,
    pinned: boolean; // State for tab pinning
    innerComponent?: string; // Reference to a Vue component
}

export const useTabViewStore = defineStore('tabViewStore', {

    // {
    //     icon: 'mdi-shield-lock-outline',
    //     type: 'chitin-tab',
    //     text: 'Security',
    //     value: 'tab-4',
    //   },
    state: () => ({
        tabs: [] as { icon: string, type: string, text: string, value: string }[], // List of tab states
        currentTab: "swpc_tex_tpc" as string,
    }),
    actions: {
        setCurrentTab(id: string) {
            const loggingStore = useLoggingStore();
            loggingStore.addAction("tabs", "Set current tab" + id)
            this.currentTab = id;
            const tab = this.tabs.find(tab => tab.id === id);
            this.tabs.map(tab => tab.isSelected = false);
            if (tab != null) {
                tab.isSelected = true;
            }
        },
        // Add a new tab with optional configuration and inner component reference
        addTab(id: string, type: string, title: string, value: string) {
            const loggingStore = useLoggingStore();
            loggingStore.addAction("tabs", "Add Tab ->" + id)
            const existingTab = this.tabs.find(tab => tab.value === value);   
            if (!existingTab) {
                this.tabs.push({
                    icon: "mdi-shield-lock-outline",
                    type: type,
                    text: title,
                    value: value,
                });
              
            }
        },

        // Set the pinned state of a specific tab
        setTabPinned(value: string, pinned: boolean) {
            const tab = this.tabs.find(tab => tab.value === value);
            if (tab) {
                tab.pinned = pinned;
            }
        },
        // Update the inner component reference of a specific tab
        setInnerComponent(value: string, innerComponent: any) {
            const tab = this.tabs.find(tab => tab.value === value);
            if (tab) {
                tab.innerComponent = innerComponent;
            }
        },
        // Remove a tab
        removeTab(value: string) {
            this.tabs = this.tabs.filter(tab => tab.value !== value);
        },
        closeAllTabs() {
            this.tabs = [];
            this.currentTab = "";
        }
    },
});