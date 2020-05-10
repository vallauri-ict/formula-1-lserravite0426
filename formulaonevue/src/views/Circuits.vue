<template>
  <v-container>
    <v-row v-for="(row, i) in rows" :key="i">
      <v-col cols="12" md="4" v-for="(circuit, j) in row" :key="j">
        <v-card max-width="344" class="mx-auto" @click="toCircuit(circuit)">
          <v-list-item>
            <v-list-item-avatar>
              <v-img :src="circuit.img"></v-img>
            </v-list-item-avatar>
            <v-list-item-content>
              <v-list-item-title class="headline">{{ circuit.name }}</v-list-item-title>
              <v-list-item-subtitle>{{ circuit.country }}</v-list-item-subtitle>
            </v-list-item-content>
          </v-list-item>
          <v-img :src="circuit.img"></v-img>

          <v-card-text>
            <b>Length:</b>
            {{ circuit.length }} m
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
    axios.get("https://localhost:44307/api/circuits/list").then(data => {
      console.log(data.data);
      this.circuits = data.data;
      for (let i = 0; i < this.circuits.length; i += 3) {
        this.rows.push(this.circuits.slice(i, i + 3));
      }
    });
  },
  data() {
    return {
      circuits: [],
      rows: []
    };
  },
  methods: {
    toCircuit(circuit) {
      console.log(circuit.id);
    }
  }
};
</script>

<style>
</style>