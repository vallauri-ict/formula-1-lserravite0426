<template>
  <v-container>
    <v-text-field class="mt-n5" :loading="loading" disabled v-if="loading"></v-text-field>
    <v-row v-for="(row, i) in rows" :key="i">
      <v-col cols="12" md="4" v-for="(circuit, j) in row" :key="j">
        <v-card max-width="344" class="mx-auto">
          <v-list-item>
            <v-list-item-avatar>
              <v-img :src="circuit.img"></v-img>
            </v-list-item-avatar>
            <v-list-item-content>
              <v-list-item-title class="headline">{{ circuit.name }}</v-list-item-title>
              <v-list-item-subtitle>{{ circuit.country.name }}</v-list-item-subtitle>
            </v-list-item-content>
          </v-list-item>
          <v-img :src="circuit.img"></v-img>

          <v-card-text>
            <p class="mb-n1">
              <b>Length:</b>
              {{ circuit.length }} m
            </p>
            <p class="mb-n1">
              <b>Laps:</b>
              {{ circuit.laps }}
            </p>
          </v-card-text>
        </v-card>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
import axios from "axios";

export default {
  beforeMount() {
    axios.get(this.$url + "/api/circuits/list").then(data => {
      this.circuits = data.data;
      for (let i = 0; i < this.circuits.length; i += 3) {
        this.rows.push(this.circuits.slice(i, i + 3));
      }
      this.loading = false;
    });
  },
  data() {
    return {
      circuits: [],
      rows: [],
      loading: true
    };
  }
};
</script>

<style>
</style>