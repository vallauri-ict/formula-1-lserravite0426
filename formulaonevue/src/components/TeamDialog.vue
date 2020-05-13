<template>
  <v-dialog v-model="dialog" max-width="90%" persistent>
    <v-card>
      <v-toolbar flat color="error" dark>
        <v-btn icon @click="close()">
          <v-icon>mdi-close</v-icon>
        </v-btn>
        <v-toolbar-title class="headline">Team details</v-toolbar-title>
      </v-toolbar>
      <v-container v-if="team">
        <v-row>
          <v-col cols="12" md="4">
            <v-img :src="team.img"></v-img>
            <v-row>
              <v-col cols="4" class="title">Full team name</v-col>
              <v-col cols="8" class="title font-weight-regular">{{team.fullTeamName}}</v-col>
            </v-row>
            <v-row>
              <v-col cols="4" class="title">Country</v-col>
              <v-col cols="8" class="title font-weight-regular">{{team.country.name}}</v-col>
            </v-row>
            <v-row>
              <v-col cols="4" class="title">Technical chief</v-col>
              <v-col cols="8" class="title font-weight-regular">{{team.technicalChief}}</v-col>
            </v-row>
            <v-row>
              <v-col cols="4" class="title">Chassis</v-col>
              <v-col cols="8" class="title font-weight-regular">{{team.chassis}}</v-col>
            </v-row>
            <v-row>
              <v-col cols="4" class="title">Power unit</v-col>
              <v-col cols="8" class="title font-weight-regular">{{team.powerUnit}}</v-col>
            </v-row>
          </v-col>
          <v-col cols="12" md="1"></v-col>
          <v-col cols="12" md="7">
            <v-row>
              <v-col cols="12" md="6">
                <v-img :src="team.firstDriver.img"></v-img>
                <p
                  class="title mt-2 text-center"
                >{{team.firstDriver.firstname}} {{team.firstDriver.lastname}}</p>
              </v-col>
              <v-col cols="12" md="6">
                <v-img :src="team.secondDriver.img"></v-img>
                <p
                  class="title mt-2 text-center"
                >{{team.secondDriver.firstname}} {{team.secondDriver.lastname}}</p>
              </v-col>
            </v-row>
          </v-col>
        </v-row>
      </v-container>
      <v-container v-else>
        <v-text-field class="mt-n5" loading disabled></v-text-field>
      </v-container>
    </v-card>
  </v-dialog>
</template>

<script>
export default {
  props: {
    dialog: {
      type: Boolean,
      default: false
    },
    team: Object
  },
  methods: {
    close() {
      this.$emit("close");
    },
    date(dob) {
      return new Date(dob).toDateString();
    }
  }
};
</script>

<style>
</style>