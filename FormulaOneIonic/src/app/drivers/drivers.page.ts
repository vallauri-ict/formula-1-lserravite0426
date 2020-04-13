import { Component, OnInit } from '@angular/core';
import { DriversService } from '../services/drivers.service';
import { Driver } from '../interfaces/driver';
import { HttpErrorResponse } from '@angular/common/http';
import { LoadingController } from '@ionic/angular';

@Component({
  selector: 'app-drivers',
  templateUrl: './drivers.page.html',
  styleUrls: ['./drivers.page.scss'],
})
export class DriversPage implements OnInit {

  id: number;
  drivers: Driver[];
  disableScroll: boolean;

  idSearch: number;
  driver: Driver;
  notFound: boolean;


  constructor(
    public driversApi: DriversService,
    public loadingCtrl: LoadingController
  ) {
    this.drivers = [];
    this.id = 1;
    this.disableScroll = false;
  }

  async ngOnInit() {
    const loading = await this.loadingCtrl.create();
    await loading.present();
    this.loadDrivers(async () => {
      loading.dismiss();
    });
  }

  moreDrivers(event) {
    this.loadDrivers(() => {
      event.target.complete();
    });
  }

  async loadDrivers(callback = () => { }) {
    this.driversApi.getDriver(this.id++).then((data: Driver) => {
      this.drivers.push(data);
      if (this.id % 2 == 0 && this.id < 18)
        this.loadDrivers(callback);
      else {
        if (this.id == 20)
          this.disableScroll = true;
        callback();
      }
    });
  }

  async search(event) {
    this.driver = {};

    const loading = await this.loadingCtrl.create();
    await loading.present();

    console.log(this.idSearch);

    if (this.idSearch.toString() != "") {
      this.disableScroll = true;
      this.driversApi.getDriver(this.idSearch)
        .then(async (data: Driver) => {
          this.notFound = false;
          this.driver = data;
          await loading.dismiss();
        }).catch(async (error: HttpErrorResponse) => {
          if (error.status == 404) {
            this.notFound = true;
          }
          await loading.dismiss();
        });
    }
    else {
      await loading.dismiss();
      this.clear();
    }
  }

  clear() {
    if (this.idSearch.toString() == '') {
      this.disableScroll = false;
      this.driver = null;
    }
  }

}
