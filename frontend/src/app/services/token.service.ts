import { Injectable } from "@angular/core";

@Injectable({
  providedIn: 'root',
})
export class TokenService {
  public getToken(): string {
    let token = localStorage.getItem('token');
    return JSON.stringify(token);
  }
}
