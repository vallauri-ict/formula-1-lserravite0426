import { Component, OnInit, Input, } from '@angular/core';
import { Driver } from 'src/app/interfaces/driver';
import { ModalController } from '@ionic/angular';
import { DriverDetailPage } from '../driver-detail/driver-detail.page';

@Component({
  selector: 'app-driver-card',
  templateUrl: './driver-card.component.html',
  styleUrls: ['./driver-card.component.scss'],
})
export class DriverCardComponent implements OnInit {

  @Input() driver: Driver;
  driverOk: boolean;

  constructor(
    private modalCtrl: ModalController
  ) { }

  ngOnInit() {
    this.driverOk = JSON.stringify(this.driver) != '{}';
  }

  async modal() {
    const modal = await this.modalCtrl.create({
      component: DriverDetailPage,
      componentProps: {
        driver: this.driver
      }
    });
    await modal.present();
  }

}
