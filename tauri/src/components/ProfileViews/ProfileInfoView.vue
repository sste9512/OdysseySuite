<template>
  <v-container>
    <v-card>
      <v-card-title>
        <span class="text-h5">User Profile</span>
      </v-card-title>
      <v-card-text>
        <v-container>
          <v-row>
            <v-col
                cols="12"
                sm="6"
                md="4"
            >
              <v-text-field
                  label="Legal first name*"
                  required
              ></v-text-field>
            </v-col>
            <v-col
                cols="12"
                sm="6"
                md="4"
            >
              <v-text-field
                  label="Legal middle name"
                  hint="example of helper text only on focus"
              ></v-text-field>
            </v-col>
            <v-col
                cols="12"
                sm="6"
                md="4"
            >
              <v-text-field
                  label="Legal last name*"
                  hint="example of persistent helper text"
                  persistent-hint
                  required
              ></v-text-field>
            </v-col>
            <v-col cols="12">
              <v-text-field
                  label="Email*"
                  required
              ></v-text-field>
            </v-col>
            <v-col cols="12">
              <v-text-field
                  label="Password*"
                  type="password"
                  required
              ></v-text-field>
            </v-col>
            <v-col
                cols="12"
                sm="6"
            >
              <v-select
                  :items="['0-17', '18-29', '30-54', '54+']"
                  label="Age*"
                  required
              ></v-select>
            </v-col>
            <v-col
                cols="12"
                sm="6"
            >
              <v-autocomplete
                  :items="['Skiing', 'Ice hockey', 'Soccer', 'Basketball', 'Hockey', 'Reading', 'Writing', 'Coding', 'Basejump']"
                  label="Interests"
                  multiple
              ></v-autocomplete>
            </v-col>
          </v-row>
        </v-container>
        <small>*indicates required field</small>
      </v-card-text>
      <v-card-actions>
        <v-spacer></v-spacer>
        <v-btn
            color="blue-darken-1"
            variant="text"

        >
          Close
        </v-btn>
        <v-btn
            color="blue-darken-1"
            variant="text"

        >
          Save
        </v-btn>
      </v-card-actions>
    </v-card>
  </v-container>
</template>

<script lang="ts">
export default {
  name: "ProfileInfoView"
}
</script>

<style scoped>

/* Override Vuetify card settings */
::v-deep(v-card) {
  background-color: #f5f5f5; /* Change the background color */
  border-radius: 8px; /* Adjust the border radius */
  box-shadow: none ; /* Remove the shadow */
  padding: 16px ; /* Add padding */
}

::v-deep(v-card-title) {
  font-weight: bold ; /* Change font weight */
  font-size: 20px ; /* Change font size */
  color: #333 ; /* Adjust text color */
}

::v-deep(v-card-text) {
  font-size: 16px; /* Adjust font size */
  color: #555; /* Adjust font color */
}

::v-deep(v-card-actions) {
  justify-content: flex-end; /* Align buttons to the right */
  padding-top: 16px; /* Add spacing above actions */
}

</style>
