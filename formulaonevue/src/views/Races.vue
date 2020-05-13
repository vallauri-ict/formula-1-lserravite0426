<template>
  <v-container>
    <v-card :loading="loading">
      <v-card-title class="display-1">
        Races
        <v-spacer></v-spacer>
        <v-text-field
          v-model="search"
          append-icon="mdi-magnify"
          label="Search"
          single-line
          hide-details
          class="mt-n3"
        ></v-text-field>
      </v-card-title>
      <v-data-table :headers="headers" :items="items" :search="search"></v-data-table>
    </v-card>
  </v-container>
</template>

<script>
import axios from "axios";

export default {
  beforeMount() {
    axios.get(this.$url + "/api/races/list").then(data => {
      this.items = data.data;
      this.loading = false;
    });
  },
  data() {
    return {
      loading: true,
      headers: [
        {
          text: "Name",
          value: "name"
        },
        {
          text: "Circuit",
          value: "circuit"
        },
        {
          text: "Date",
          value: "date"
        }
      ],
      items: [],
      search: ""
    };
  }
};
</script>

<style>
</style>