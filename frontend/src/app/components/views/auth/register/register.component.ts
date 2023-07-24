import { Router } from '@angular/router';
import { AccountRequestDTO } from 'src/app/models/accountRequest';
import { AuthService } from './../../../../services/auth.service';
import { Component } from '@angular/core';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent {
  public name!: string;
  public email!: string;
  public password!: string;
  public confirmPassword!: string;

  constructor(private authService: AuthService, private router: Router) { }

  public register() {
    let account = new AccountRequestDTO(this.name,
                                     this.email,
                                     this.password,
                                     this.confirmPassword);

    this.authService.register(account)
    .subscribe((response: any) => {
      console.log(response);
      localStorage.setItem('token', response.token);
      this.router.navigate(["/home"])

    })
  }

}
