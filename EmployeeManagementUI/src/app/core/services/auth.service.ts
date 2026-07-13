import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private apiUrl = "https://localhost:7033/api/Auth";

  constructor(private http: HttpClient) { }

  login(username: string, password: string) {

    return this.http.post(
      `${this.apiUrl}/login`,
      {
        username: username,
        password: password
      }
    );

  }
  getCurrentUser() {

  const token = localStorage.getItem("token");

  return this.http.get(
    `${this.apiUrl}/me`,
    {
      headers: {
        Authorization: `Bearer ${token}`
      }
    }
  );

}
logout(){
  localStorage.removeItem("token"); 
}

}