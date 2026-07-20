import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../../core/services/employee.service';
import { Employee } from '../../shared/models/employee';
import { CommonModule } from '@angular/common';
import {ChangeDetectorRef} from '@angular/core';
import { Router } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { RouterLink } from '@angular/router';
@Component({
  selector: 'app-employee-list',
  imports: [CommonModule, FormsModule, RouterLink],
  templateUrl: './employees.html',
  styleUrl: './employees.scss',
  standalone: true,
})
export class EmployeeList implements OnInit {

  employees: Employee[] = [];
  filteredEmployees: Employee[] = [];
  searchText = "";
  sortDirection = true; // true matlab ascending
  currentSort = "";
  selectedFilter = "all";

  constructor(private employeeService: EmployeeService,
    private cdr: ChangeDetectorRef,
    private router: Router) {}

ngOnInit(): void {

  this.loadEmployees();

}
editEmployee(employee: Employee) {
  this.router.navigate(['/edit', employee.empID]);
  }
    loadEmployees() {

    this.employeeService.getEmployees().subscribe({

      next: (response: Employee[]) => {

        this.employees = response;
        //this.filteredEmployees = response;
        this.applyFilters();
        this.cdr.detectChanges();

      },

      error: (error) => {

        console.log(error);

      }

    });

  }
  inactivateEmployee(id: number) {

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
  applyFilters() {

  // Start with all employees
  let result = [...this.employees];

  // Filter by Active / Inactive
  if (this.selectedFilter === "active") {

    result = result.filter(emp => emp.isActive);

  }
  else if (this.selectedFilter === "inactive") {

    result = result.filter(emp => !emp.isActive);

  }

  // Search
  const search = this.searchText.toLowerCase().trim();

  if (search !== "") {

    result = result.filter(emp =>

      emp.empID.toString().includes(search) ||

      emp.fullName.toLowerCase().includes(search) ||

      emp.email.toLowerCase().includes(search) ||

      emp.phone.toLowerCase().includes(search) ||

      emp.deptID.toString().includes(search) ||

      emp.salary.toString().includes(search)

    );

  }

  this.filteredEmployees = result;

}
sortEmployees(column: string) {

  if (this.currentSort === column) {

    this.sortDirection = !this.sortDirection;

  } else {

    this.currentSort = column;
    this.sortDirection = true;

  }

  this.filteredEmployees.sort((a: any, b: any) => {

    let valueA = a[column];
    let valueB = b[column];

    if (typeof valueA === 'string') {

      valueA = valueA.toLowerCase();
      valueB = valueB.toLowerCase();

    }

    if (valueA < valueB)
      return this.sortDirection ? -1 : 1;

    if (valueA > valueB)
      return this.sortDirection ? 1 : -1;

    return 0;

  });

}
}
