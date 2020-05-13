<template>
  <v-container>
    <v-text-field class="mt-n5" :loading="loading" disabled v-if="loading"></v-text-field>
    <v-row v-for="(row, i) in rows" :key="i">
      <v-col cols="12" md="4" v-for="(team, j) in row" :key="j">
        <v-card max-width="344" class="mx-auto" min-height="344" @click="cardClick(team)">
          <v-list-item>
            <v-list-item-avatar>
              <v-img :src="team.logo"></v-img>
            </v-list-item-avatar>
            <v-list-item-content>
              <v-list-item-title class="headline">{{ team.name }}</v-list-item-title>
              <v-list-item-subtitle>{{ team.country }}</v-list-item-subtitle>
            </v-list-item-content>
          </v-list-item>
          <v-img :src="team.logo" height="200"></v-img>

          <v-card-text>Drivers: {{ team.drivers.join(', ') }}</v-card-text>
        </v-card>
      </v-col>
    </v-row>
    <TeamDialog @close="closeDialog()" :dialog="dialog" :team="team" />
  </v-container>
</template>

<script>
import axios from "axios";

import TeamDialog from "../components/TeamDialog";

export default {
  components: {
    TeamDialog
  },
  beforeMount() {
    axios.get(this.$url + "/api/teams/list").then(data => {
      this.teams = data.data;
      for (let i = 0; i < this.teams.length; i += 3) {
        this.rows.push(this.teams.slice(i, i + 3));
      }
      this.loading = false;
    });
  },
  data() {
    return {
      teams: [],
      rows: [],
      loading: true,
      dialog: false,
      team: null
    };
  },
  methods: {
    cardClick(team) {
      this.dialog = true;
      axios
        .get(this.$url + "/api/teams/" + team.id + "/details")
        .then(data => (this.team = data.data));
    },
    closeDialog() {
      this.dialog = false;
    }
  }
};
</script>
<style>
</style>