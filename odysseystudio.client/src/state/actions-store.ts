import { defineStore } from "pinia";

interface UserAction {
  id: string;
  timestamp: Date;
  actionType: string;
  resourceId?: string;
  details?: Record<string, any>;
}

export const useActionsStore = defineStore("actions", {
  state: () => ({
    actions: [] as UserAction[],
  }),

  actions: {
    addAction(
      actionType: string,
      resourceId?: string,
      details?: Record<string, any>
    ) {
      const action: UserAction = {
        id: crypto.randomUUID(),
        timestamp: new Date(),
        actionType,
        resourceId,
        details,
      };
      this.actions.push(action);
    },

    clearActions() {
      this.actions = [];
    },

    removeAction(id: string) {
      const index = this.actions.findIndex((action) => action.id === id);
      if (index > -1) {
        this.actions.splice(index, 1);
      }
    },
  },

  getters: {
    getActionsByType: (state) => {
      return (actionType: string) =>
        state.actions.filter((action) => action.actionType === actionType);
    },

    getActionsByResource: (state) => {
      return (resourceId: string) =>
        state.actions.filter((action) => action.resourceId === resourceId);
    },

    getRecentActions: (state) => {
      return (limit: number = 10) =>
        [...state.actions]
          .sort((a, b) => b.timestamp.getTime() - a.timestamp.getTime())
          .slice(0, limit);
    },
  },
});
