import { Router } from '@angular/router';
import { Component } from '@angular/core';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent {

  constructor(private router: Router) { }

  public isSmallScreen = false;

  get sidenavMode() {
    return this.isSmallScreen ? 'over' : 'side';
  }

  public logout() {
    localStorage.clear();
    this.router.navigate(["/"])
  }
}
