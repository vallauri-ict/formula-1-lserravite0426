<template>
  <v-container>
    <v-text-field class="mt-n4" :loading="loading" disabled v-if="loading"></v-text-field>
    <v-row v-for="(row, i) in rows" :key="i">
      <v-col cols="12" md="4" v-for="(driver, j) in row" :key="j">
        <v-card max-width="344" class="mx-auto">
          <v-list-item>
            <v-list-item-avatar>
              <v-img :src="driver.img"></v-img>
            </v-list-item-avatar>
            <v-list-item-content>
              <v-list-item-title class="headline">{{ driver.name }}</v-list-item-title>
              <v-list-item-subtitle>{{ driver.country }}</v-list-item-subtitle>
            </v-list-item-content>
          </v-list-item>
          <v-img :src="driver.img"></v-img>

          <v-card-text>{{ driver.description.substr(0, 150) }}...</v-card-text>
        </v-card>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
import axios from "axios";

export default {
  beforeMount() {
    axios.get("https://localhost:44307/api/drivers/list").then(data => {
      console.log(data.data);
      this.drivers = data.data;
      for (let i = 0; i < this.drivers.length; i += 3) {
        this.rows.push(this.drivers.slice(i, i + 3));
      }
      this.loading = false;
    });
  },
  data() {
    return {
      drivers: [],
      rows: [],
      loading: true
    };
  }
};
</script>

<style>
</style>