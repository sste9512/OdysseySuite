<template>
  <v-data-table
      :headers="headers"
      :items="creatureStructs"
      :search="search"
      class="creature-struct-table"
      density="comfortable"
  >
    <template #item.description="{ item }">
      <div class="description-cell" v-html="formatDescription(item.description)"></div>
    </template>
  </v-data-table>
</template>

<script lang="ts">
import { defineComponent, ref } from 'vue'

interface CreatureStruct {
  label: string
  type: string
  description: string
}

export default defineComponent({
  name: "CreatureStructTable",
  setup() {
    const headers = [
      {
        title: 'Label',
        key: 'label',
        align: 'start',
        sortable: true
      },
      {
        title: 'Type',
        key: 'type',
        align: 'start',
        sortable: true
      },
      {
        title: 'Description',
        key: 'description',
        align: 'start',
        sortable: false
      }
    ]

    const creatureStructs: CreatureStruct[] = [
      {
        label: 'Appearance_Type',
        type: 'WORD',
        description: 'Index into appearance.2da.'
      },
      {
        label: 'BodyBag',
        type: 'BYTE',
        description: 'Index into bodybag.2da. Specifies the appearance of the bodybag that this Creature leaves behind after its corpse fades, if it had dropped any Items on death, and if the Lootable Field is 0. See Table 4.5.2 in the Doors and Placeable Objects document.'
      },
      {
        label: 'Cha',
        type: 'BYTE',
        description: 'Charisma Ability Score, before any bonuses/penalties'
      },
      {
        label: 'ChallengeRating',
        type: 'FLOAT',
        description: 'Calculated Challenge Rating. See Section 3.1. Challenge Rating.'
      },
      {
        label: 'ClassList',
        type: 'List',
        description: 'List of Class Structs, having StructID 2. Must always contain at least one element, and can have up to 3 elements.'
      }
    ]

    const search = ref('')

    const formatDescription = (description: string) => {
      return description.replace(/\n/g, '<br>')
    }

    return {
      headers,
      creatureStructs,
      search,
      formatDescription
    }
  }
})
</script>

<style scoped>
.creature-struct-table {
  width: 100%;
  background-color: rgb(43, 37, 37) !important;
  border-radius: 9px !important;
  border: 1px solid rebeccapurple !important;
  overflow: hidden !important;
}

:deep(.v-data-table-header) {
  background-color: rgba(102, 51, 153, 0.2) !important;
}

:deep(.v-data-table__tr) {
  border-bottom: 1px solid rgba(102, 51, 153, 0.3) !important;
}

:deep(.v-data-table__td) {
  color: rgb(226, 210, 241) !important;
}

.description-cell {
  max-width: 500px;
  white-space: pre-wrap;
  line-height: 1.4;
}

:deep(.v-data-table-header th) {
  color: rgb(226, 210, 241) !important;
  font-weight: bold !important;
  text-transform: uppercase;
  letter-spacing: 0.5px;
}
</style>