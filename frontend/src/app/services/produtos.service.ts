import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable({
  providedIn: 'root',
})
export class ProdutoService {
  constructor(private http: HttpClient) { }

  public buscarProdutos(token: string): Observable<any> {
    return this.http.get("localhost:7000/listar-produtos", {
      headers: {
        'Authorization Bearer': token
      }
    })
  }
}
