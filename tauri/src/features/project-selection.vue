<script lang="ts">


import {useField, useForm} from 'vee-validate'
import type {Project} from "@/clients/web-api-client";
import router from "@/navigation/base-router";
import DirectoryViewer from "@/components/DirectoryViewer.vue";
import {ref} from "vue";

export default {
  name: 'ProjectSelection',
  components: {DirectoryViewer},
  setup() {
    return {
      name,
      phone,
      checkbox,
      submit,
      show,
      handleReset
    }
  },
  methods: {
    navigateToProject: async function () {
      await router.push({path: '/project'});
    },
    async openFolderDialog() {
      show.value = true;
    }
  }
}
async function navigateToProject ()  {
  await router.push({path: '/project'});
}

async function openFolderDialog() {

}


const {handleSubmit, handleReset} = useForm({
  validationSchema: {
    name(value) {
      if (value?.length >= 2) return true

      return 'Name needs to be at least 2 characters.'
    },
   
    checkbox(value) {
      return true;
      /*f (value === '1') return true

      return 'Must be checked.'*/
    },
  },
})
const name = useField('name')
const phone = useField('phone')
const checkbox = useField('checkbox')
const show = ref(false)


const submit = handleSubmit(async values => {
  /*const projectManagementClient = resolve<IProjectManagementClient>('projectManagementClient');
  await projectManagementClient.createProject(values);*/
  console.log("submit")
  const project: Project = {
    name: values.name,
    gameBackupFilePath: values.phone, 
    filePath: values.checkbox
  }
  //alert(JSON.stringify(project, null, 2))
  await router.push({path: '/project'});
})


</script>

<template>
  <v-sheet theme="dark">
    <v-container>
      <v-row no-gutters>

<!--        List of Projects          -->
        <v-col cols="12"
               sm="8">
          <v-sheet class="ma-1 pa-1">
            <v-list lines="two" theme="dark">
              <v-list-item
                  v-for="n in 3"
                  :key="n"
                  :title="'Item ' + n"
                  theme="dark"
                  subtitle="Lorem ipsum dolor sit amet consectetur adipisicing elit"
              ></v-list-item>
            </v-list>
          </v-sheet>
        </v-col>

       
        
<!--        Project Name Input      -->
        <v-col cols="12"
               sm="8">
          <form @submit.prevent="submit" class="ma-1 pa-1">
            <v-text-field
                v-model="name.value.value"
                :counter="10"
                :error-messages="name.errorMessage.value"
                label="Project Name"
            ></v-text-field>

            <v-text-field
                v-model="phone.value.value"
                :counter="7"
                :error-messages="phone.errorMessage.value"
                label="Game File Path"
            ></v-text-field>

            <v-checkbox
                v-model="checkbox.value.value"
                :error-messages="checkbox.errorMessage.value"
                value="1"
                label="Back up game data in folder"
                type="checkbox"
            ></v-checkbox>

            <v-btn
                class="me-4"
                @click="openFolderDialog"
            >
              Find Directory
            </v-btn>
            <v-btn
                class="me-4"
                type="submit"
                @click="navigateToProject"
            >
              submit
            </v-btn>

            <v-btn @click="handleReset">
              clear
            </v-btn>
          </form>
        </v-col>

        <v-col>

        </v-col>

      </v-row>
    </v-container>
  </v-sheet>
  <directory-viewer :show="show" @update:selectedDirectory="updateSelectedDirectory" @update:isOpen="updateIsOpen"></directory-viewer>
</template>

<style scoped>
/*.card {
  width: 100%;
  height: 350px;
  padding: 20px;
  color: white;
  background: linear-gradient(#212121, #212121) padding-box,
  linear-gradient(145deg, transparent 35%, #e81cff, #40c9ff) border-box;
  border: 2px solid transparent;
  border-radius: 8px;
  !*display: flex;
  flex-direction: column;*!
  cursor: pointer;
  transform-origin: right bottom;
  transition: all 0.6s cubic-bezier(0.23, 1, 0.320, 1);
}

.card .main-content {
  flex: 1;
}

.card .header span:first-child {
  font-weight: 600;
  color: #717171;
  margin-right: 4px;
}

.card .heading {
  font-size: 24px;
  margin: 24px 0 16px;
  font-weight: 600;
}

.card .categories {
  !*display: flex;*!
  gap: 8px;
}

.card .categories span {
  background-color: #e81cff;
  padding: 4px 8px;
  font-weight: 600;
  text-transform: uppercase;
  font-size: 12px;
  border-radius: 50em;
}

.card .footer {
  font-weight: 600;
  color: #717171;
  margin-right: 4px;
}

.card:hover {
  rotate: 8deg;
}*/
</style>