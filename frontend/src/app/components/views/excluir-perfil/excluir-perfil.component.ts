import { Router } from '@angular/router';
import { AuthService } from './../../../services/auth.service';
import { Component } from '@angular/core';

@Component({
  selector: 'app-excluir-perfil',
  templateUrl: './excluir-perfil.component.html',
  styleUrls: ['./excluir-perfil.component.scss']
})
export class ExcluirPerfilComponent {

  private token!: string;
  constructor(private authService: AuthService,
              private router: Router)
  {
    this.token = localStorage.getItem('token') || '';
  }

  public excluirPerfil() {
    this.authService.excluirConta(this.token).subscribe(() => {
      localStorage.clear();
      this.router.navigate(["/"])
    });
  }
}
