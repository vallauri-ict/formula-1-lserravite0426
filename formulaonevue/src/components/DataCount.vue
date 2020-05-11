<template>
  <v-card @click="toPage">
    <div class="d-flex flex-no-wrap justify-space-between">
      <div>
        <v-card-title class="headline">{{ text }}</v-card-title>
        <v-card-subtitle>{{ items }}</v-card-subtitle>
      </div>
      <v-icon large class="mr-5">{{ icon }}</v-icon>
    </div>
  </v-card>
</template>

<script>
export default {
  props: {
    text: String,
    items: String,
    icon: String,
    page: String
  },
  methods: {
    toPage() {
      this.$router.push(this.page);
    }
  }
};
</script>

<style>
</style>