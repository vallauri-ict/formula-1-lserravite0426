import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { DriverDetailPage } from './driver-detail.page';

describe('DriverDetailPage', () => {
  let component: DriverDetailPage;
  let fixture: ComponentFixture<DriverDetailPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DriverDetailPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(DriverDetailPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
