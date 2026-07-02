import { AuthService } from '../../services/auth.service';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-login',
  imports: [FormsModule],
  templateUrl: './login.html',
  styleUrl: './login.css',
})
export class Login {
  username ="";
  password ="";
  constructor(private authService: AuthService) { }

  login() {

  this.authService.login(
    this.username,
    this.password
  ).subscribe({

    next: (response: any) => {

  console.log(response);

  localStorage.setItem("token", response.token);

  console.log("Token Saved");

},

    error: (error) => {

      console.log(error);

    }

  });

}
}
