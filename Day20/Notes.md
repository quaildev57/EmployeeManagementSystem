# Day 20 Notes – Angular Routing & Navigation

## Topics Covered

* Angular Routing
* Routes Configuration
* RouterOutlet
* Navigation Between Components
* Login Component
* Dashboard Component
* Employee List Component
* Single Page Applications (SPA)
* Component Hierarchy

---

## What is Routing?

Routing allows Angular to display different components based on the URL without reloading the browser.

Example:

```
/login

/dashboard

/employees
```

Each URL maps to a component.

---

## Routes Configuration

Routes are defined inside:

```
app.routes.ts
```

Example:

```typescript
export const routes: Routes = [
    {
        path:'',
        component: Login
    },
    {
        path:'dashboard',
        component: Dashboard
    },
    {
        path:'employees',
        component: EmployeeList
    }
];
```

---

## RouterOutlet

RouterOutlet is a placeholder where Angular dynamically loads components according to the current route.

Example:

```html
<router-outlet></router-outlet>
```

---

## Application Structure

```
App Component
│
├── Navbar
│
└── RouterOutlet
      │
      ├── Login
      ├── Dashboard
      └── Employee List
```

Navbar remains visible while only the RouterOutlet content changes.

---

## Single Page Application (SPA)

Angular applications do not reload the entire page during navigation.

Instead,

```
URL Changes

↓

Angular Router

↓

Loads Component

↓

Updates RouterOutlet
```

Result:

* Faster navigation
* Better user experience
* Reduced server requests

---

## Login Component

Created Login Component as the application's landing page.

Basic UI includes:

* Username field
* Password field
* Login button

---

## Dashboard Component

Created placeholder Dashboard component for authenticated users.

---

## Employee List Component

Created placeholder Employee List component.

---

## Component Hierarchy

```
App Component
│
├── Navbar
│
└── RouterOutlet
      │
      ├── Login
      ├── Dashboard
      └── Employee List
```

The App Component acts as the root component while RouterOutlet dynamically displays child components.

---

## Commands Used

Generate Components

```bash
ng g c components/login

ng g c components/dashboard

ng g c components/employee-list
```

Run Angular

```bash
ng serve
```

---

## Challenges Faced

* Understood the distinction between Components and Routes.
* Resolved RouterOutlet warning by recognizing that imported directives should be used within templates.
* Learned the purpose of RouterOutlet as the rendering placeholder for routed components.

---

## Key Learning

Angular Routing enables Single Page Applications by dynamically rendering components inside RouterOutlet based on the current URL while preserving shared components like the Navbar.
