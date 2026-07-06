import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { EmployeeService } from '../../services/employee.service';
import { Employee } from '../../models/employee';

@Component({
  selector: 'app-add-employee',
  imports: [FormsModule],
  templateUrl: './add-employee.html',
  styleUrl: './add-employee.css'
})
export class AddEmployee {
employee: Employee = {

  empID: 0,
  fullName: '',
  gender: '',
  dob: '2004-01-15',      // ✅

  address: 'Delhi',

  phone: '',

  email: '',

  deptID: 1,

  userID: 1,

  joinDate: '2026-07-06', // ✅

  salary: 0,

  isActive: true


  };

  constructor(private employeeService: EmployeeService) {}

  saveEmployee() {

    this.employeeService.addEmployee(this.employee).subscribe({

      next: (response) => {

        console.log(response);
        alert("Employee Added Successfully!");

      },

error: (error) => {

  console.log(error);

  console.log("Status:", error.status);

  console.log("Message:", error.error);

  alert("Failed to Add Employee");

}

    });

  }

}