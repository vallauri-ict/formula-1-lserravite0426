import Vue from "vue";
import VueRouter from "vue-router";

import Dashboard from "../views/Dashboard";
import Teams from "../views/Teams.vue"
import Drivers from "../views/Drivers.vue";
import Circuits from "../views/Circuits.vue";
import Races from "../views/Races.vue";

Vue.use(VueRouter);

const routes = [
  {
    path: "/",
    component: Dashboard
  },
  {
    path: "/teams",
    component: Teams
  },
  {
    path: "/drivers",
    component: Drivers
  },
  {
    path: "/circuits",
    component: Circuits
  },
  {
    path: "/races",
    component: Races
  }
];

const router = new VueRouter({
  routes
});

export default router;
