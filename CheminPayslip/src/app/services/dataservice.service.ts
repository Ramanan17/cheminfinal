import { Injectable } from '@angular/core';
import { Http } from '@angular/Http';
import { Observable } from 'rxjs/internal/Observable';
import { map } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class DataserviceService {

  constructor(public http: Http) {

  }
    getSites() {
        return this.http.get("/api/Siteinfo").pipe(map((response: any) => response.json()));
    }
}
