import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Employee } from '../models/employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  private apiUrl = "https://localhost:7033/api/Employee";

  constructor(private http: HttpClient) { }

  getEmployees() {

    const token = localStorage.getItem("token");
    console.log("Employee Token:", token);
return this.http.get<Employee[]>(
  this.apiUrl,
  {
    headers: {
      Authorization: `Bearer ${token}`
    }
  }
);

  }
  addEmployee(employee: Employee) {

  const token = localStorage.getItem("token");

  return this.http.post(
    this.apiUrl,
    employee,
    {
      headers: {
        Authorization: `Bearer ${token}`
      }
    }
  );

}
updateEmployee(employee: Employee) {

  const token = localStorage.getItem("token");

  return this.http.put(
    this.apiUrl,
    employee,
    {
      headers: {
        Authorization: `Bearer ${token}`
      }
    }
  );

}
getEmployeeById(id: number) {

  const token = localStorage.getItem("token");

  return this.http.get<Employee>(
    `${this.apiUrl}/${id}`,
    {
      headers: {
        Authorization: `Bearer ${token}`
      }
    }
  );

}
 
}