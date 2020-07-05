import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import { GetAllLeaguesResponse } from '../models/league/get-all-leagues-response';

@Injectable({
  providedIn: 'root'
})

export class LeagueService {

  readonly rootUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  public getAll(): Observable<GetAllLeaguesResponse> {
    return this.http.get<GetAllLeaguesResponse>(this.rootUrl + 'League/GetAll');
  }

  public create(data: any): Observable<any> {
    return this.http.post<any>(this.rootUrl + 'League/Create', data);
  }

  public update(data: any): Observable<any> {
    return this.http.post<any>(this.rootUrl + 'League/Update', data);
  }

  public remove(data: any): Observable<any> {
    return this.http.post<any>(this.rootUrl + 'League/Remove', data);
  }
}
