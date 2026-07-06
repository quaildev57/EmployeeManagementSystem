import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../../services/employee.service';
import { Employee } from '../../models/employee';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-employee-list',
  imports: [CommonModule],
  templateUrl: './employee-list.html',
  styleUrl: './employee-list.css',
  standalone: true,
})
export class EmployeeList implements OnInit {

  employees: Employee[] = [];

  constructor(private employeeService: EmployeeService) {}

  ngOnInit(): void {

    this.employeeService.getEmployees().subscribe({

      next: (response: Employee[]) => {

        console.log(response);

        this.employees = response;
        console.log(this.employees);
        console.log(this.employees.length);
      },

      error: (error) => {

        console.log(error);

      }

    });

  }

}
