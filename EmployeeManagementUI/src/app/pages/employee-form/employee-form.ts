import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { EmployeeService } from '../../core/services/employee.service';
import { Employee } from '../../shared/models/employee';
import { ActivatedRoute, Router, RouterLink } from '@angular/router';
import { ChangeDetectorRef } from '@angular/core';

@Component({
  selector: 'app-add-employee',
  standalone: true,
  imports: [FormsModule, RouterLink],
  templateUrl: './employee-form.html',
  styleUrl: './employee-form.scss'
})
export class AddEmployee implements OnInit {
  ngOnInit(): void {

  const id = Number(this.route.snapshot.paramMap.get('id'));

  if (id) {

    this.employeeService.getEmployeeById(id).subscribe({

      next: (response: Employee) => {

        console.log(response);

        this.employee = response;

        this.cdr.detectChanges();

      },

      error: (error) => {

        console.log(error);

      }

    });

  }

}
employee: Employee = {

  empID: 0,
  fullName: '',
  gender: '',
  dob: '2004-01-15',     
  address: 'Delhi',
  phone: '',
  email: '',
  deptID: 1,
  userID: 1,
  joinDate: '2026-07-06', // for testing
  salary: 0,
  isActive: true
 };

  constructor(
  private employeeService: EmployeeService,
  private route: ActivatedRoute,
  private router: Router,
  private cdr: ChangeDetectorRef
) {}
saveEmployee() {

  console.log("EmpID =", this.employee.empID);

  if (this.employee.empID === 0) {

    console.log("Calling ADD API");

    this.employeeService.addEmployee(this.employee).subscribe({
      next: () => {
        alert("Employee Added Successfully");
        this.router.navigate(['/employees']);
      }
    });

  } else {

    console.log("Calling UPDATE API");

    this.employeeService.updateEmployee(this.employee).subscribe({
      next: () => {
        alert("Employee Updated Successfully");
        this.router.navigate(['/employees']);
      }
    });

  }

}

}