import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../../services/employee.service';
import { Employee } from '../../models/employee';
import { CommonModule } from '@angular/common';
import {ChangeDetectorRef} from '@angular/core';
import { Router } from '@angular/router';
@Component({
  selector: 'app-employee-list',
  imports: [CommonModule],
  templateUrl: './employee-list.html',
  styleUrl: './employee-list.css',
  standalone: true,
})
export class EmployeeList implements OnInit {

  employees: Employee[] = [];

  constructor(private employeeService: EmployeeService,
    private cdr: ChangeDetectorRef,
    private router: Router) {}

  ngOnInit(): void {

    this.employeeService.getEmployees().subscribe({

      next: (response: Employee[]) => {

  this.employees = response;

  this.cdr.detectChanges();

  console.log("Assigned:", this.employees.length);

},
      error: (error) => {

        console.log(error);

      }

    });

}
editEmployee(employee: Employee) {
  this.router.navigate(['/edit', employee.empID]);
  }
    loadEmployees() {

    this.employeeService.getEmployees().subscribe({

      next: (response: Employee[]) => {

        this.employees = response;

        this.cdr.detectChanges();

      },

      error: (error) => {

        console.log(error);

      }

    });

  }
  deleteEmployee(id: number) {

    const confirmDelete = confirm(
      "Are you sure you want to inactivate this employee?"
    );

    if (!confirmDelete) return;

    this.employeeService.inactivateEmployee(id).subscribe({

      next: () => {

        alert("Employee Inactivated Successfully");

        // Refresh employee list
        this.loadEmployees();

      },

      error: (error) => {

        console.log(error);

      }

    });

  }
}
