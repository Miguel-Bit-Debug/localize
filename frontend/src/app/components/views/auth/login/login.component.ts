import { LoginRequest } from 'src/app/models/loginRequest';
import { AuthService } from './../../../../services/auth.service';
import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {

  public email!: string;
  public password!: string;

  constructor(private authService: AuthService, private router: Router) { }

  public login() {
    let loginRequest = new LoginRequest(this.email, this.password);

    this.authService.login(loginRequest)
      .subscribe((response: any) => {
        localStorage.setItem('token', response.token);
        this.router.navigate(["/home"])
      })

  }
}
