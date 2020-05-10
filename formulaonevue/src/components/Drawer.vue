<template>
  <v-navigation-drawer
    class="overflow-hidden"
    v-model="drawer"
    permanent
    color="success"
    dark
    app
    :mini-variant="small"
    :expand-on-hover="small"
    width="200"
  >
    <v-list nav class="py-0">
      <v-list-item two-line :mini-variant="small" class="px-0">
        <v-list-item-avatar>
          <img
            src="https://www.ilposticipo.it/wp-content/uploads/sites/63/2018/03/00/24/674E7134-986E-4EA4-9737-4DBA19EC88F5.png"
          />
        </v-list-item-avatar>

        <v-list-item-content>
          <v-list-item-title>Formula1</v-list-item-title>
        </v-list-item-content>
      </v-list-item>

      <v-divider></v-divider>

      <v-list-item-group v-model="selected">
        <template v-for="page in pages">
          <v-list-item link :key="page.title" @click="changeView(page.path)">
            <v-list-item-icon>
              <v-icon>{{ page.icon }}</v-icon>
            </v-list-item-icon>
            <v-list-item-content>
              <v-list-item-title>{{ page.title }}</v-list-item-title>
            </v-list-item-content>
          </v-list-item>
        </template>
      </v-list-item-group>
    </v-list>
  </v-navigation-drawer>
</template>

<script>
export default {
  props: {
    small: {
      type: Boolean,
      default: false
    }
  },
  data() {
    return {
      drawer: true,
      selected: 0,
      pages: [
        {
          title: "Daskboard",
          icon: "mdi-view-dashboard",
          path: "/"
        },
        {
          title: "Teams",
          icon: "mdi-account-group",
          path: "/teams"
        },
        {
          title: "Drivers",
          icon: "mdi-account",
          path: "/drivers"
        },
        {
          title: "Circuits",
          icon: "mdi-road",
          path: "/circuits"
        },
        {
          title: "Races",
          icon: "mdi-flag",
          path: "/races"
        }
      ]
    };
  },
  methods: {
    changeView(path) {
      this.$router.push(path);
    }
  }
};
</script>