<template>
  <v-container>
    <v-row>
      <v-col cols="12" md="4">
        <v-card>
          <div class="d-flex flex-no-wrap justify-space-between">
            <div>
              <v-card-title class="headline">Teams</v-card-title>
              <v-card-subtitle>{{ teams }}</v-card-subtitle>
            </div>
            <v-icon large class="mr-5">mdi-account-group</v-icon>
          </div>
        </v-card>
      </v-col>
      <v-col cols="12" md="4">
        <v-card>
          <div class="d-flex flex-no-wrap justify-space-between">
            <div>
              <v-card-title class="headline">Drivers</v-card-title>
              <v-card-subtitle>{{ drivers }}</v-card-subtitle>
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
              <v-card-subtitle>{{ circuits }}</v-card-subtitle>
            </div>
            <v-icon large class="mr-5">mdi-road</v-icon>
          </div>
        </v-card>
      </v-col>
    </v-row>

    <v-row>
      <v-col cols="12" md="4">
        <v-card>
          <div class="d-flex flex-no-wrap justify-space-between">
            <div>
              <v-card-title class="headline">Races</v-card-title>
              <v-card-subtitle>{{ races }}</v-card-subtitle>
            </div>
            <v-icon large class="mr-5">mdi-account-group</v-icon>
          </div>
        </v-card>
      </v-col>
      <v-col cols="12" md="4">
        <v-card>
          <div class="d-flex flex-no-wrap justify-space-between">
            <div>
              <v-card-title class="headline">Races scores</v-card-title>
              <v-card-subtitle>{{ racesScores }}</v-card-subtitle>
            </div>
            <v-icon large class="mr-5">mdi-flag</v-icon>
          </div>
        </v-card>
      </v-col>
      <v-col cols="12" md="4"></v-col>
    </v-row>
  </v-container>
</template>

<script>
import axios from "axios";

export default {
  components: {},
  data() {
    return {
      datacollection: null,
      teamsCount: null,
      driversCount: null,
      circuitsCount: null,
      racesCount: null,
      racesScoresCount: null
    };
  },
  beforeMount() {
    axios
      .get("https://localhost:44307/api/teams/count")
      .then(data => (this.teamsCount = data.data));
    axios
      .get("https://localhost:44307/api/drivers/count")
      .then(data => (this.driversCount = data.data));
    axios
      .get("https://localhost:44307/api/circuits/count")
      .then(data => (this.circuitsCount = data.data));
    axios
      .get("https://localhost:44307/api/races/count")
      .then(data => (this.racesCount = data.data));
    axios
      .get("https://localhost:44307/api/racesScores/count")
      .then(data => (this.racesScoresCount = data.data));
  },
  methods: {
    fillData() {}
  },
  computed: {
    teams() {
      return this.teamsCount ? +this.teamsCount + " teams" : "Wait...";
    },
    drivers() {
      return this.driversCount ? +this.driversCount + " drivers" : "Wait...";
    },
    circuits() {
      return this.circuitsCount ? +this.circuitsCount + " circuits" : "Wait...";
    },
    races() {
      return this.racesCount ? +this.racesCount + " races" : "Wait...";
    },
    racesScores() {
      return this.racesScoresCount
        ? +this.racesScoresCount + " scores"
        : "Wait...";
    }
  }
};
</script>

<style>
</style>