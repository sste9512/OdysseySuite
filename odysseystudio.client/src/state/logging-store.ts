import {defineStore} from 'pinia';

// Type definitions for user actions and categories
interface UserAction {
    id: string;
    description: string;
    timestamp: Date;
}

interface UserActionsByCategory {
    [category: string]: UserAction[];
}

export const useLoggingStore = defineStore('userActions', {
    state: () => ({
        actionsByCategory: {} as UserActionsByCategory,
    }),
    actions: {
        addAction(category: string, description: string) {
            const newAction: UserAction = {
                id: crypto.randomUUID(),
                description,
                timestamp: new Date(),
            };

            if (!this.actionsByCategory[category]) {
                this.actionsByCategory[category] = [];
            }

            this.actionsByCategory[category].push(newAction);
        },
        getActionsByCategory(category: string): UserAction[] {
            return this.actionsByCategory[category] || [];
        },
        clearCategory(category: string) {
            if (this.actionsByCategory[category]) {
                delete this.actionsByCategory[category];
            }
        },
        clearAll() {
            this.actionsByCategory = {};
        },
    },
});