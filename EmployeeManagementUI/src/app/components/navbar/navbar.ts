import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../../services/auth.service';

@Component({
  selector: 'app-navbar',
  imports: [],
  templateUrl: './navbar.html',
  styleUrl: './navbar.css',
})
export class Navbar {
  constructor(
  private authService: AuthService,
  private router: Router
) {}
  title =  " Employee Management System";
  username = "Hrishita";
  showMessage(){
    alert("Welcome "+this.username)
  }
  logout() {

  this.authService.logout();

  alert("Logged out successfully.");

  this.router.navigate(['/login']);

}
}
