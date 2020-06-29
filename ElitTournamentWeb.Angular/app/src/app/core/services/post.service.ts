import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {environment} from '../../../environments/environment';
import {Observable} from 'rxjs';
import {GetAllPostItemResponse, GetAllPostResponse} from '../models/get-all-post-response';

@Injectable({
  providedIn: 'root'
})
export class PostService {

  readonly rootUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  public getAll(): Observable<GetAllPostResponse> {
    return this.http.get<GetAllPostResponse>(this.rootUrl + 'Post/GetAll');
  }

  public update(data: GetAllPostItemResponse): Observable<null> {
    return this.http.post<null>(this.rootUrl + 'Post/Update', data);
  }

}
