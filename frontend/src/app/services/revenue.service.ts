import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class RevenueService {
  constructor(private http: HttpClient) {}

  private readonly baseUrl: string = environment.baseURL;

  public buscarRevenue(token: string, cnpj: string): Observable<any> {
    return this.http.get<any>(`${this.baseUrl}/api/revenue?cnpj=${cnpj}`, {
      headers: {
        'Authorization': `Bearer ${token}`
      }
    });
  }
}

