import { Router } from '@angular/router';
import { UpdateAccountRequest } from 'src/app/models/updateAccountRequest';
import { AuthService } from './../../../services/auth.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-editar-perfil',
  templateUrl: './editar-perfil.component.html',
  styleUrls: ['./editar-perfil.component.scss']
})
export class EditarPerfilComponent implements OnInit {
  public email!: string;
  public name!: string;
  private token!: string;

  constructor(private authService: AuthService,
              private router: Router)
  {
    this.token = localStorage.getItem('token') || '';
  }

  ngOnInit(): void {
    this.authService.accountInfo(this.token)
      .subscribe((response: any) => {
        this.name = response.name;
        this.email = response.email;
      })
  }

  public atualizarDados() {
    let accountUpdate = new UpdateAccountRequest(this.name, this.email);
    this.authService.updateAccount(this.token, accountUpdate)
      .subscribe(() => {
        this.router.navigate(["/home"])
      })
  }
}
