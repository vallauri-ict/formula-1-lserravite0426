import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { DriversPageRoutingModule } from './drivers-routing.module';

import { DriversPage } from './drivers.page';
import { DriverCardComponent } from './driver-card/driver-card.component';
import { DriverDetailPageModule } from './driver-detail/driver-detail.module';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    DriversPageRoutingModule,
    DriverDetailPageModule
  ],
  declarations: [
    DriversPage,
    DriverCardComponent
  ],
  entryComponents: []
})
export class DriversPageModule { }
