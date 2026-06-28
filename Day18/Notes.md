# Day 18 Notes – Introduction to Angular

## Topics Covered

* Angular Framework Overview
* Angular CLI Installation
* Angular Project Creation
* Angular Project Structure
* Standalone Components
* Component Architecture
* Angular Application Bootstrapping

---

## What is Angular?

Angular is a TypeScript-based frontend framework developed by Google for building Single Page Applications (SPAs). It follows a component-based architecture where the user interface is divided into reusable components.

---

## Development Environment

* Installed Node.js v26.4.0
* Installed Angular CLI v22.0.0
* Created Angular project: **EmployeeManagementUI**
* Successfully ran the application using `ng serve`

---

## Angular Project Structure

### Important Files

**main.ts**

* Entry point of the Angular application.
* Bootstraps the root component.

**app.ts**

* Root component of the application.
* Defines component metadata such as selector, template, styles, and imports.

**app.html**

* HTML template rendered by the root component.

**app.css**

* Styles specific to the root component.

**app.routes.ts**

* Stores client-side routing configuration.

**app.config.ts**

* Registers application-wide providers and configuration.

---

## Components

A component is a reusable building block of the user interface.

Each component consists of:

* TypeScript file (Logic)
* HTML file (Template)
* CSS file (Styling)

Example:

Navbar Component

* navbar.ts
* navbar.html
* navbar.css

---

## Component Decorator

```typescript
@Component({
  selector: 'app-navbar',
  imports: [],
  templateUrl: './navbar.html',
  styleUrl: './navbar.css'
})
```

Purpose:

* Declares a class as an Angular component.
* Defines how Angular should render the component.

---

## Selector

```typescript
selector: 'app-navbar'
```

Allows the component to be used as:

```html
<app-navbar></app-navbar>
```

Angular replaces the custom tag with the component's HTML.

---

## Angular Component Tree

```
App Component
│
├── Navbar
├── Login
├── Dashboard
├── Employee List
└── Footer
```

The App Component acts as the root component and manages child components.

---

## Angular vs ASP.NET Core

| ASP.NET Core         | Angular                  |
| -------------------- | ------------------------ |
| Program.cs           | main.ts                  |
| Controller           | Component                |
| Service              | Service                  |
| Dependency Injection | Dependency Injection     |
| Route                | Route                    |
| Middleware           | HTTP Interceptor (later) |

---

## Commands Learned

Create Angular Project

```bash
ng new EmployeeManagementUI
```

Run Application

```bash
ng serve
```

Generate Component

```bash
ng generate component components/navbar
```

or

```bash
ng g c components/navbar
```

---

## Challenges Faced

* Angular CLI initially failed due to an incompatible Node.js version.
* Upgraded Node.js and Angular CLI to the latest supported versions.
* Encountered Angular workspace error while generating a component and understood that Angular commands must be executed from the project directory containing `angular.json`.

---

## Key Learning

Angular applications are built by composing reusable components, with the App Component acting as the root of the entire application. Understanding the project structure and component architecture is fundamental before developing complex user interfaces.
