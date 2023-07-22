import { TokenService } from './../../../services/token.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  constructor(private tokenService: TokenService) { }
  public token!: string;

  ngOnInit(): void {
    this.token = this.tokenService.getToken();
    console.log(this.token)
  }

}
