import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import { GetAllLeaguesResponse } from '../models/leagues-view.ts';

@Injectable({
  providedIn: 'root'
})

export class LeagueService {

  readonly rootUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  public getAll(): Observable<GetAllLeaguesResponse> {
    return this.http.get<GetAllLeaguesResponse>(this.rootUrl + 'League/GetAll');
  }
}
