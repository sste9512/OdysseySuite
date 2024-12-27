import {defineStore} from 'pinia';

interface TabViewState {
    id: string; // Unique identifier for each tab
    pinned: boolean; // State for tab pinning
    configuration: Record<string, any>; // Stores configuration settings for the tab
    innerComponent?: any; // Reference to an inner component (optional, can be typed further if needed)
}

export const useTabViewStore = defineStore('tabViewStore', {
    state: () => ({
        tabs: [] as TabViewState[], // List of tab states
        currentTab: "" as string,
    }),
    actions: {
        setCurrentTab(id: string) {
             this.currentTab = id;
        },
        // Add a new tab with optional configuration and inner component reference
        addTab(id: string, configuration: Record<string, any> = {}, innerComponent?: any) {
            this.tabs.push({
                id,
                pinned: false,
                configuration,
                innerComponent,
            });
        },
        // Update the configuration state of a specific tab
        updateTabConfiguration(id: string, newConfig: Record<string, any>) {
            const tab = this.tabs.find(tab => tab.id === id);
            if (tab) {
                tab.configuration = {...tab.configuration, ...newConfig};
            }
        },
        // Set the pinned state of a specific tab
        setTabPinned(id: string, pinned: boolean) {
            const tab = this.tabs.find(tab => tab.id === id);
            if (tab) {
                tab.pinned = pinned;
            }
        },
        // Update the inner component reference of a specific tab
        setInnerComponent(id: string, innerComponent: any) {
            const tab = this.tabs.find(tab => tab.id === id);
            if (tab) {
                tab.innerComponent = innerComponent;
            }
        },
        // Remove a tab
        removeTab(id: string) {
            this.tabs = this.tabs.filter(tab => tab.id !== id);
        },
        closeAllTabs() {
             this.tabs = [];
        }
    },
});