<template>
  <v-container>
    <v-row>
      <v-col cols="12" md="5">
        <v-card>
          <v-card-title class="display-1">Formula 1</v-card-title>
          <v-carousel height="250" hide-delimiter-background show-arrows-on-hover cycle>
            <v-carousel-item v-for="(item,i) in items" :key="i" :src="item"></v-carousel-item>
          </v-carousel>
          <v-card-text>
            This is formulaonevue, a Vuejs client developed with Vuetify components that use a C# Web API 2 server to get Formula 1 2019 Championship data.
            <br />
            <a
              target="_blank"
              href="https://github.com/vallauri-ict/formula-1-lserravite0426"
              style="text-decoration: none"
            >Click here</a> to visit my GitHub repository!
          </v-card-text>
        </v-card>
      </v-col>
      <v-col cols="12" md="7">
        <v-row class="mt-n3">
          <v-col cols="6">
            <DataCount text="Teams" icon="mdi-account-group" :items="teams" page="/teams" />
          </v-col>
          <v-col cols="6">
            <DataCount text="Drivers" icon="mdi-account" :items="drivers" page="/drivers" />
          </v-col>
        </v-row>
        <v-row>
          <v-col cols="6">
            <DataCount text="Circuits" icon="mdi-road" :items="circuits" page="/circuits" />
          </v-col>
          <v-col cols="6">
            <DataCount text="Races" icon="mdi-calendar" :items="races" page="/races" />
          </v-col>
        </v-row>
        <v-row>
          <v-col cols="12" md="6">
            <DataCount text="Races scores" icon="mdi-flag" :items="racesScores" page="/races" />
          </v-col>
          <v-col cols="12" md="4"></v-col>
        </v-row>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
import axios from "axios";

import DataCount from "../components/DataCount";

export default {
  components: {
    DataCount
  },
  data() {
    return {
      datacollection: null,
      teamsCount: null,
      driversCount: null,
      circuitsCount: null,
      racesCount: null,
      racesScoresCount: null,
      items: [
        "https://f1grandprix.motorionline.com/wp-content/uploads/2017/11/71898DBD-4D6D-4C5F-BEDE-B7DB24375D18-1024x683.jpeg",
        "https://www.calcioefinanza.it/wp-content/uploads/2020/03/f1-vettel-1.jpg",
        "https://www.formula1.com/etc/designs/fom-website/social/f1-default-share.jpg",
        "https://www.digital-news.it/img/primo_piano/foto_grandi/2019/09/1567897460-f1-italia-monza-skysport-tv8.jpg"
      ]
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