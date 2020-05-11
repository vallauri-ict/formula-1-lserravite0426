<template>
  <v-app style="background-color: #eee">
    <v-content>
      <Drawer :small="small" />
      <v-container>
        <v-app-bar flat class="mt-n2 ml-n4" color="#eee">
          <v-btn fab small @click="small = !small">
            <v-icon>mdi-dots-horizontal</v-icon>
          </v-btn>
        </v-app-bar>
      </v-container>
      <router-view />
    </v-content>
  </v-app>
</template>

<script>
import Drawer from "./components/Drawer";

export default {
  name: "App",

  components: {
    Drawer
  },

  data() {
    return {
      small: true
    };
  }
};
</script>
