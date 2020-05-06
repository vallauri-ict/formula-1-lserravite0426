import Vue from "vue";
import VueRouter from "vue-router";

import Dashboard from "../views/Dashboard";
import Teams from "../views/Teams.vue"

Vue.use(VueRouter);

const routes = [
  {
    path: "/",
    component: Dashboard
  },
  {
    path: "/teams",
    component: Teams
  }
];

const router = new VueRouter({
  routes
});

export default router;
