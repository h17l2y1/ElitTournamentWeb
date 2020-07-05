import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {environment} from '../../../environments/environment';
import {Observable} from 'rxjs';
import {GetAllPostResponse} from '../models/post/get-all-post-response';
import {UpdateManyPostRequest} from '../models/post/update-many-post-request';
import { UpdatePostRequest } from '../models/post/update-post-request';

@Injectable({
  providedIn: 'root'
})
export class PostService {

  readonly rootUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  public getAll(): Observable<GetAllPostResponse> {
    return this.http.get<GetAllPostResponse>(this.rootUrl + 'Post/GetAll');
  }

  public update(data: UpdatePostRequest): Observable<null> {
    return this.http.post<null>(this.rootUrl + 'Post/Update', data);
  }

  public updateMany(data: UpdateManyPostRequest): Observable<null> {
    return this.http.post<null>(this.rootUrl + 'Post/UpdateMany', data);
  }

}
