import { Injectable } from '@angular/core';
import {environment} from '../../../environments/environment';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {GetAllTeamsResponse} from '../models/team/get-all-teams-response';
import {Season} from '../models/season/season';

@Injectable({
  providedIn: 'root'
})
export class SeasonService {

  readonly rootUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  // public get(): Observable<GetAllTeamsResponse> {
  //   return this.http.get<GetAllTeamsResponse>(this.rootUrl + 'Season/Get');
  // }

  public create(data: Season): Observable<null> {
    return this.http.post<null>(this.rootUrl + 'Season/Create', data);
  }

  // public update(): Observable<GetAllTeamsResponse> {
  //   return this.http.get<GetAllTeamsResponse>(this.rootUrl + 'Season/Update');
  // }
}
