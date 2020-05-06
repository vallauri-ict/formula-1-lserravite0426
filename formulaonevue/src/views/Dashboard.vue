<template>
  <v-container>
    <v-row>
      <v-col cols="12" md="4">
        <v-card>
          <div class="d-flex flex-no-wrap justify-space-between">
            <div>
              <v-card-title class="headline">Teams</v-card-title>
              <v-card-subtitle>800 items</v-card-subtitle>
            </div>
            <v-icon large class="mr-5">mdi-flag</v-icon>
          </div>
        </v-card>
      </v-col>
      <v-col cols="12" md="4">
        <v-card>
          <div class="d-flex flex-no-wrap justify-space-between">
            <div>
              <v-card-title class="headline">Drivers</v-card-title>
              <v-card-subtitle>800 items</v-card-subtitle>
            </div>
            <v-icon large class="mr-5">mdi-account</v-icon>
          </div>
        </v-card>
      </v-col>
      <v-col cols="12" md="4">
        <v-card>
          <div class="d-flex flex-no-wrap justify-space-between">
            <div>
              <v-card-title class="headline">Circuits</v-card-title>
              <v-card-subtitle>800 items</v-card-subtitle>
            </div>
            <v-icon large class="mr-5">mdi-flag</v-icon>
          </div>
        </v-card>
      </v-col>
    </v-row>
    <v-row>
      <v-col cols="12" md="5">
        <v-card>
          <v-card-title class="headline">Completed</v-card-title>
          <v-card-text>
            <LineChart :chart-data="datacollection" />
          </v-card-text>
        </v-card>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
import LineChart from "../components/LineChart.js";

export default {
  components: {
    LineChart
  },
  data() {
    return {
      datacollection: null
    };
  },
  mounted() {
    this.fillData();
  },
  methods: {
    fillData() {
      this.datacollection = {
        labels: ["Drivers", "Teams", "Circuits"],
        datasets: [
          {
            label: "Drivers",
            backgroundColor: ["red", "green", "purple"],
            data: [80, 5, 15]
          }
        ]
      };
    }
  }
};
</script>

<style>
</style>