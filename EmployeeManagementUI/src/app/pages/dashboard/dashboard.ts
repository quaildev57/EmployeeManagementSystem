import { Component, OnInit } from '@angular/core';
import { AuthService } from '../../core/services/auth.service';
import { ChangeDetectorRef } from '@angular/core';
import { Router } from '@angular/router';
import { EmployeeService } from '../../core/services/employee.service';
import { Employee } from '../../shared/models/employee';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [ RouterLink],
  templateUrl: './dashboard.html',
  styleUrl: './dashboard.scss'
})
export class Dashboard implements OnInit {
  username = "";
role = "";
department = "";
employeeCount = 0;
activeCount = 0;
inactiveCount = 0;

  constructor(
  private authService: AuthService,
  private cdr: ChangeDetectorRef,
  private router: Router,
  private employeeService: EmployeeService
) {}

  ngOnInit(): void {
  //     this.username = "Test User";
  // this.role = "Developer";
  // this.department = "IT";
  this.employeeService.getEmployees().subscribe({
    next: (employees: Employee[]) => {

        this.employeeCount = employees.length;

        this.activeCount = employees.filter(e => e.isActive).length;

        this.inactiveCount = employees.filter(e => !e.isActive).length;
    }
});
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
  goToAddEmployee(){

    this.router.navigate(['/add']);

}

}