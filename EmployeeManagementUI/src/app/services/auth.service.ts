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

}