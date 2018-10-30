import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map, catchError } from 'rxjs/operators';

@Injectable()
export class PresidentsService {
  private baseUrl = 'https://presidentsservice20181030113456.azurewebsites.net/api/presidents/';

  constructor(private http: HttpClient) {

  }

  getSortedPresidents(sort: number) {
    return this.http.get(this.baseUrl + sort)
      .pipe(
        map(this.extractData)
      );
  }

  private extractData(res) {
    return res || {};
  }
}
