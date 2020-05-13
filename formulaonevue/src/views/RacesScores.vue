<template>
  <v-container>
    <v-row>
      <v-col cols="12" md="4">
        <v-card style="overflow: auto" :loading="loading.filters" :disabled="loading.filters">
          <v-card-title class="display-1 mb-n4">Filters</v-card-title>
          <v-card-text>
            <v-radio-group v-model="filter" column @change="getFilterItems">
              <v-radio label="By Race" value="races"></v-radio>
              <v-radio label="By Driver" value="drivers"></v-radio>
            </v-radio-group>
            <v-select
              placeholder="Filter"
              :disabled="!filter || !filterItems.length"
              :items="filterItems"
              v-model="filterSelected"
              label
              outlined
              item-text="name"
              item-value="id"
            ></v-select>
          </v-card-text>
          <div>
            <v-btn
              class="float-right mt-n5 mb-5 mr-4"
              color="primary"
              :disabled="!filterSelected || loading.data"
              @click="getData"
            >Get data</v-btn>
          </div>
        </v-card>
      </v-col>
      <v-col cols="12" md="8">
        <v-card :loading="loading.data">
          <v-card-title class="display-1">
            Races Scores
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
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
import axios from "axios";
const HEADER_DRIVERS = [
  {
    text: "Race",
    value: "race",
    sortable: false
  },
  {
    text: "Circuit",
    value: "circuit",
    sortable: false
  },
  {
    text: "Pos",
    value: "pos",
    sortable: false
  },
  {
    text: "Score",
    value: "score",
    sortable: false
  },
  {
    text: "Details",
    value: "details",
    sortable: false
  }
];
const HEADER_RACES = [
  {
    text: "Driver",
    value: "driver",
    sortable: false
  },
  {
    text: "Pos",
    value: "pos",
    sortable: false
  },
  {
    text: "Score",
    value: "score",
    sortable: false
  },
  {
    text: "Details",
    value: "details",
    sortable: false
  }
];

export default {
  data() {
    return {
      search: "",
      filter: null,
      filterItems: [],
      filterSelected: null,
      items: [],
      headers: [],
      loading: {
        filters: false,
        data: false
      }
    };
  },
  methods: {
    getFilterItems() {
      this.loading.filters = true;
      this.filterItems = [];
      this.filterSelected = null;
      axios.get(this.$url + "/api/" + this.filter + "/list").then(data => {
        this.filterItems = data.data;
        this.loading.filters = false;
      });
    },
    getData() {
      this.loading.data = true;
      axios
        .get(
          `https://localhost:44307/api/racesScores/${this.filter}/${this.filterSelected}`
        )
        .then(data => {
          this.headers =
            this.filter == "drivers" ? HEADER_DRIVERS : HEADER_RACES;
          this.items = data.data;
          this.loading.data = false;
          this.search = "";
        });
    }
  }
};
</script>

<style>
</style>