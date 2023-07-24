import { RevenueService } from './../../../services/revenue.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  public isSmallScreen = false;
  public cnpj!: string;
  private token!: string;

  ngOnInit(): void {
  }

  constructor(private revenueService: RevenueService) {
    this.token = localStorage.getItem('token') || ''
  }

  get sidenavMode() {
    return this.isSmallScreen ? 'over' : 'side';
  }

  public buscarCnpj() {
    this.revenueService.buscarRevenue(this.token, this.cnpj)
      .subscribe((response: any) => {
        console.log(response);
      });
  }
}
