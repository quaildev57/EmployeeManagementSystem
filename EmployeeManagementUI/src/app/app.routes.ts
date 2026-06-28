import { Routes } from '@angular/router';
import { Login } from './components/login/login';
import { Dashboard } from './components/dashboard/dashboard';
import { EmployeeList } from './components/employee-list/employee-list';

export const routes: Routes = [
    {
        path: '',
        component: Login
    },
    {
        path: 'login',
        component: Login
    },
    {
        path: 'dashboard',
        component: Dashboard
    },
    {
        path: 'employees',
        component: EmployeeList
    }
];