import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import {Navbar} from './components/navbar/navbar';
//import { RouterOutlet } from '@angular/router';
@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Navbar],
    //imports: [Navbar, RouterOutlet],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('EmployeeManagementUI');
}
