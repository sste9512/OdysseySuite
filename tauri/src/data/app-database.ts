import Dexie, { type Table } from 'dexie';

interface Resource {
  id: string; 
  name: string;
  type: string;
  path: string;
  size: number;
  lastModified: Date;
  resourceCount?: number; 
  status?: string;
}

interface UserPreference {
  id: string;
  key: string;
  value: any;
  lastUpdated: Date;
}

interface UserAction {
  id: string;
  timestamp: Date;
  actionType: string;
  resourceId?: string;
  details?: Record<string, any>;
}
interface Log {
  id: string;
  timestamp: Date;
  level: string;
  message: string;
  source: string;
  details?: Record<string, any>;
}

export class AppDatabase extends Dexie {
  resources!: Table<Resource>;
  preferences!: Table<UserPreference>;
  actions!: Table<UserAction>;
  logs!: Table<Log>;

  constructor() {
    super("AppDatabase");
    super.version(1).stores({
      resources: "&id, name, type, path",
      preferences: "&id, key",
      actions: "&id, timestamp, actionType, resourceId",
      logs: "&id, timestamp, level, message, source",
    });
  }

  // Intercept read operations
  hooks = {
    reading: {
      resources: (resource: Resource) => {
        console.debug("[READ] Resource:", {
          id: resource.id,
          name: resource.name,
          type: resource.type,
        });
        return resource;
      },
      preferences: (preference: UserPreference) => {
        console.debug("[READ] Preference:", {
          key: preference.key,
          value: preference.value,
        });
        return preference;
      },
      actions: (action: UserAction) => {
        console.debug("[READ] Action:", {
          id: action.id,
          type: action.actionType,
          resourceId: action.resourceId,
        });
        return action;
      },
    },
    creating: {
      resources: (primKey: string, obj: Resource) => {
        console.debug("[CREATE] Resource:", {
          id: obj.id,
          name: obj.name,
          type: obj.type,
          path: obj.path,
        });
        return obj;
      },
      preferences: (primKey: string, obj: UserPreference) => {
        console.debug("[CREATE] Preference:", {
          key: obj.key,
          value: obj.value,
        });
        return obj;
      },
      actions: (primKey: string, obj: UserAction) => {
        console.debug("[CREATE] Action:", {
          id: obj.id,
          type: obj.actionType,
          resourceId: obj.resourceId,
          details: obj.details,
        });
        return obj;
      },
    },
    updating: {
      resources: (mods: Partial<Resource>, primKey: string, obj: Resource) => {
        console.debug("[UPDATE] Resource:", {
          id: primKey,
          modifications: mods,
        });
        return mods;
      },
      preferences: (
        mods: Partial<UserPreference>,
        primKey: string,
        obj: UserPreference
      ) => {
        console.debug("[UPDATE] Preference:", {
          id: primKey,
          modifications: mods,
        });
        return mods;
      },
      actions: (
        mods: Partial<UserAction>,
        primKey: string,
        obj: UserAction
      ) => {
        console.debug("[UPDATE] Action:", {
          id: primKey,
          modifications: mods,
        });
        return mods;
      },
    },
  };
}

export const appDatabase = new AppDatabase();
