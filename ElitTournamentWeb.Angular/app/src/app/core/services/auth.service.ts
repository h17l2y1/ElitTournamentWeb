import {Inject, Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import * as jwt_decode from 'jwt-decode';
import 'rxjs/add/operator/delay';

import {environment} from '../../../environments/environment';
import {Observable} from 'rxjs';
import {JwtResponse} from '../models/jwt-response';
import {LogInRequest} from '../models/log-in-request';
import {TokenData} from '../models/token-data';

@Injectable({
    providedIn: 'root'
})
export class AuthenticationService {

    readonly rootUrl = environment.apiUrl;

    constructor(private http: HttpClient, @Inject('LOCALSTORAGE') private localStorage: Storage) {
    }

    public login(model: LogInRequest): Observable<JwtResponse> {
        return this.http.post<JwtResponse>(this.rootUrl + "Account/LogIn", model);
    }

    public logout(): void {
        this.localStorage.removeItem('TOKEN_DATA_KEY');
    }

    public getCurrentUser(): TokenData {
        const token = localStorage.getItem('TOKEN_DATA_KEY');
        if (!token){
            return null;
        }
        return jwt_decode(token) as TokenData;
    }

}
