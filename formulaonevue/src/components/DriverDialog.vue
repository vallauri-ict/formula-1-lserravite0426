<template>
  <v-dialog v-model="dialog" max-width="90%" persistent>
    <v-card>
      <v-toolbar flat color="error" dark>
        <v-btn icon @click="close()">
          <v-icon>mdi-close</v-icon>
        </v-btn>
        <v-toolbar-title class="headline">Driver details</v-toolbar-title>
      </v-toolbar>
      <v-container v-if="driver">
        <v-row>
          <v-col cols="12" md="5">
            <v-img :src="driver.img"></v-img>
          </v-col>
          <v-col cols="12" md="7">
            <v-row class="mb-n5">
              <v-col cols="6" class="title">Firstname</v-col>
              <v-col cols="6" class="title font-weight-regular">{{driver.firstname}}</v-col>
            </v-row>
            <v-row class="mb-n5">
              <v-col cols="6" class="title">Lastname</v-col>
              <v-col cols="6" class="title font-weight-regular">{{driver.lastname}}</v-col>
            </v-row>
            <v-row class="mb-n5">
              <v-col cols="6" class="title">Country</v-col>
              <v-col cols="6" class="title font-weight-regular">{{driver.country.name}}</v-col>
            </v-row>
            <v-row class="mb-n5">
              <v-col cols="6" class="title">Date of birth</v-col>
              <v-col cols="6" class="title font-weight-regular">{{date(driver.dob)}}</v-col>
            </v-row>
            <v-row class="mb-n3">
              <v-col cols="6" class="title">Place of birth</v-col>
              <v-col cols="6" class="title font-weight-regular">{{driver.placeOfBirth}}</v-col>
            </v-row>
            <v-row>
              <v-col cols="12">{{driver.description}}</v-col>
            </v-row>
          </v-col>
        </v-row>
      </v-container>
      <v-container v-else>
        <v-text-field class="mt-n5" loading disabled></v-text-field>
      </v-container>
    </v-card>
  </v-dialog>
</template>

<script>
export default {
  props: {
    dialog: {
      type: Boolean,
      default: false
    },
    driver: Object
  },
  methods: {
    close() {
      this.$emit("close");
    },
    date(dob) {
      return new Date(dob).toDateString();
    }
  }
};
</script>

<style>
</style>