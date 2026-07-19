import { Component, OnInit } from '@angular/core';
import { AuthService } from '../../core/services/auth.service';
import { ChangeDetectorRef } from '@angular/core';
@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [],
  templateUrl: './dashboard.html',
  styleUrl: './dashboard.scss'
})
export class Dashboard implements OnInit {
  username = "";
role = "";
department = "";

  constructor(
  private authService: AuthService,
  private cdr: ChangeDetectorRef
) {}

  ngOnInit(): void {
  //     this.username = "Test User";
  // this.role = "Developer";
  // this.department = "IT";
    console.log("Dashboard Loaded");

    this.authService.getCurrentUser().subscribe({

next: (response: any) => {

  console.log("Response:", response);

  this.username = response.username;
  this.role = response.role;
  this.department = response.department;
  this.cdr.detectChanges();
  console.log(this.username);
  console.log(this.role);
  console.log(this.department);

},

      error: (error) => {

        console.log("Failed to fetch user");
        console.log(error);

      }

    });

  }

}