import { Injectable } from '@angular/core';
import { environment } from './../../environments/environment';
import { LoginRequest } from './../models/loginRequest';
import { HttpClient } from '@angular/common/http'
import { Observable, map } from 'rxjs';
import { AccountRequestDTO } from '../models/accountRequest';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  constructor(private http: HttpClient)
  {
  }

  private readonly baseUrl: string = environment.baseURL;

  public login(loginRequest: LoginRequest): Observable<string> {
    return this.http.post<string>(`${this.baseUrl}/api/auth/login`, loginRequest);
  }

  public register(accountRequest: AccountRequestDTO): Observable<string> {
    console.log(accountRequest)
    return this.http.post<string>(`${this.baseUrl}/api/auth/create-account`, accountRequest);
  }

  public excluirConta(token: string): Observable<any> {
    return this.http.delete<any>(`${this.baseUrl}/api/auth/remove-account`, {
      headers: {
        'Authorization': `Bearer ${token}`
      }
    });
  }
}
