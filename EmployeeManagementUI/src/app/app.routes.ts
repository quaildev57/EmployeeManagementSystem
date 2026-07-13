import { Routes } from '@angular/router';
import { Login } from './pages/login/login';
import { Dashboard } from './pages/dashboard/dashboard';
import { EmployeeList } from './pages/employees/employees';
import { AddEmployee } from './pages/employee-form/employee-form';
import { authGuard } from './core/guards/auth-guard';
import { loginGuard } from './core/guards/login-guard';

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