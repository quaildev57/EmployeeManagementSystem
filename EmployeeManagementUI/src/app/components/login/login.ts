import { AuthService } from '../../services/auth.service';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import{Router} from '@angular/router';
@Component({
  selector: 'app-login',
  imports: [FormsModule],
  templateUrl: './login.html',
  styleUrl: './login.css',
})
export class Login {
  username ="";
  password ="";
  constructor(
    private authService: AuthService,
  private router: Router) { }

login() {

  this.authService.login(
    this.username,
    this.password
  ).subscribe({

    next: (response: any) => {

      localStorage.setItem("token", response.token);
      this.router.navigate(['/dashboard']);

      console.log("Login Successful");

    },

    error: (error) => {

      console.error("Login Failed", error);

    }

  });

}

}
