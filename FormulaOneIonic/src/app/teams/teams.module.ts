import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { TeamsPage } from './teams.page';
import { TeamsPageRoutingModule } from './teams-routing.module';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    TeamsPageRoutingModule
  ],
  declarations: [TeamsPage]
})
export class TeamsPageModule { }
