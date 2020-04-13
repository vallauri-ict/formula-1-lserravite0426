import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpResponse, HttpResponseBase } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DriversService {

  constructor(
    public http: HttpClient
  ) { }

  getDriver(id: number) {
    return this.http.get('https://localhost:44307/api/drivers/' + id).toPromise()
  }

  failFunction(error: HttpErrorResponse) {
    console.log(error);
  }
}
