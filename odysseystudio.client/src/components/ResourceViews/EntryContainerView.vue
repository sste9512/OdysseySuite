<template>
<!--  <v-sheet
    border="md"
    class="pa-6 text-white mx-auto"
    color="#141518"
    max-width="400"

  >-->
  <div class="btn-shadow">
    <h5 class="text-h5 font-weight-bold mb-4">{{ propertyTitle }}</h5>


<!--    <v-btn
      block
      class="text-none text-black mb-4"
      color="red-accent-2"
      size="x-large"
      variant="flat"
    >
      Accept
    </v-btn>

    <v-btn
      block
      class="text-none text-black"
      color="red-accent-2"
      size="x-large"
      variant="outlined"
    >
      Your Preferences
    </v-btn>-->
<!--  </v-sheet>-->
  </div>
</template>

<script>
export default {
  name: 'EntryContainerView',
  props: {
    propertyTitle: String,
    propertyValue: String
  }
}
</script>

<style scoped lang="scss">

.btn-shadow{



  &:after {
    border-radius: 100% / 30%;
    content: "";
    position: absolute;
    top: 20px;
    z-index: -1;
    //width: 90%;
    width: calc(100% - 40px);
    //height: 280px;
    height: calc(100% - 20px);
    -webkit-box-shadow: 0px 10px 30px 0px rgba(0,0,0,0.4);
    -moz-box-shadow: 0px 10px 30px 0px rgba(0,0,0,0.4);
    box-shadow: 0px 10px 30px 0px rgba(0,0,0,0.4);
  }
}

</style>
