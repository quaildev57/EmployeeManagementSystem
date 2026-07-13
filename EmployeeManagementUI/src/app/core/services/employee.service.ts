import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Employee } from '../../shared/models/employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  private apiUrl = "https://localhost:7033/api/Employee";

  constructor(private http: HttpClient) { }

  // Get All Employees
  getEmployees() {

    return this.http.get<Employee[]>(this.apiUrl);

  }

  // Get Employee By ID
  getEmployeeById(id: number) {

    return this.http.get<Employee>(
      `${this.apiUrl}/${id}`
    );

  }

  // Add Employee
  addEmployee(employee: Employee) {

    return this.http.post(
      this.apiUrl,
      employee
    );

  }

  // Update Employee
  updateEmployee(employee: Employee) {

    return this.http.put(
      this.apiUrl,
      employee
    );

  }

  // Soft Delete / Inactivate Employee
  inactivateEmployee(id: number) {

    return this.http.put(
      `${this.apiUrl}/inactivate/${id}`,
      {}
    );

  }

}

/* earlier:
const token = localStorage.getItem("token");

headers: {
    Authorization: `Bearer ${token}`
}

i.e. now authentication is handled by the authInterceptor, 
so we don't need to manually set the Authorization header in each service method. */
