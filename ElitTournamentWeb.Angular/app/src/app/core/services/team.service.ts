import { Injectable } from '@angular/core';
import {environment} from '../../../environments/environment';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {GetAllTeamsResponse} from '../models/team/get-all-teams-response';

@Injectable({
  providedIn: 'root'
})
export class TeamService {

  readonly rootUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  public getAll(): Observable<GetAllTeamsResponse> {
    return this.http.get<GetAllTeamsResponse>(this.rootUrl + 'Team/GetAll');
  }

  public create(data: any): Observable<any> {
    return this.http.post<any>(this.rootUrl + 'Team/Create', data);
  }

  public update(data: any): Observable<any> {
    return this.http.post<any>(this.rootUrl + 'Team/Update', data);
  }

  public remove(data: any): Observable<any> {
    return this.http.post<any>(this.rootUrl + 'Team/Remove', data);
  }
}
