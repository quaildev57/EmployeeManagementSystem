import { Routes } from '@angular/router';
import { Login } from './components/login/login';
import { Dashboard } from './components/dashboard/dashboard';
import { EmployeeList } from './components/employee-list/employee-list';
import { AddEmployee } from './components/add-employee/add-employee';
import { authGuard } from './guards/auth-guard';
import { loginGuard } from './guards/login-guard';

export const routes: Routes = [
    {
        path: '',
        component: Login,
        canActivate: [loginGuard] //login is left unprotected cuz anyone should be able to sign in
       
    },
    {
        path: 'login',
        component: Login,
        canActivate: [loginGuard]
       
    },
    {
        path: 'dashboard',
        component: Dashboard,
        canActivate: [authGuard]
    },
    {
        path: 'employees',
        component: EmployeeList,
        canActivate: [authGuard]
    },
    {
        path: 'add-employee',
        component: AddEmployee,
        canActivate: [authGuard]
    },
    {
        path: 'edit/:id',
        component: AddEmployee,
        canActivate: [authGuard]
    }

];