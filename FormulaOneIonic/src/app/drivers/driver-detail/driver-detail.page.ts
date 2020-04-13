import { Component, OnInit, Input } from '@angular/core';
import { Driver } from 'src/app/interfaces/driver';
import { ModalController } from '@ionic/angular';

@Component({
  selector: 'app-driver-detail',
  templateUrl: './driver-detail.page.html',
  styleUrls: ['./driver-detail.page.scss'],
})
export class DriverDetailPage implements OnInit {

  @Input() driver: Driver;

  constructor(
    private modalCtrl: ModalController
  ) { }

  ngOnInit() {

  }

  async back() {
    await this.modalCtrl.dismiss();
  }

}
