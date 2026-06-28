# Day 19 Notes – Angular Data Binding & Component Fundamentals

## Topics Covered

* Introduction to Angular Data Binding
* Interpolation
* Property Binding
* Event Binding
* Two-Way Data Binding (Concept)
* Standalone Components
* Component Communication
* Navbar Component Implementation

---

## Angular Data Binding

Data Binding is the mechanism that enables communication between the application's TypeScript code and the HTML template.

Angular provides four types of data binding:

1. Interpolation
2. Property Binding
3. Event Binding
4. Two-Way Data Binding

---

## 1. Interpolation

Used to display TypeScript data inside HTML.

Example:

```html
<h2>{{ title }}</h2>
```

```typescript
title = "Employee Management System";
```

Output:

```
Employee Management System
```

---

## 2. Property Binding

Used to bind a TypeScript variable to an HTML property.

Syntax:

```html
<img [src]="imageUrl">
```

Example:

```typescript
imageUrl = "logo.png";
```

Property Binding is represented using square brackets `[]`.

---

## 3. Event Binding

Used to execute TypeScript methods in response to user actions.

Syntax:

```html
<button (click)="showMessage()">
```

Example:

```typescript
showMessage()
{
    alert("Welcome");
}
```

Event Binding is represented using parentheses `()`.

---

## 4. Two-Way Data Binding

Allows synchronization between HTML input fields and TypeScript variables.

Syntax:

```html
<input [(ngModel)]="username">
```

Concept Covered:

* Changes made in HTML automatically update TypeScript variables.
* Changes in TypeScript automatically update the HTML.

(Practical implementation will be covered during Login Form development.)

---

## Angular Component Communication

HTML interacts with TypeScript through data binding.

Example:

```
HTML
     ↓
(click)

TypeScript Function

↓

UI Updates
```

---

## Navbar Component

Implemented a reusable Navbar component.

Component Structure:

* navbar.ts
* navbar.html
* navbar.css

Implemented:

* Title variable
* Username variable
* Event handling using button click
* Alert message

---

## Standalone Components

Angular 22 uses Standalone Components instead of NgModules.

Benefits:

* Simpler project structure
* Reduced boilerplate code
* Easier dependency management

---

## Commands Used

Generate Component

```bash
ng g c components/navbar
```

Run Angular

```bash
ng serve
```

---

## Challenges Faced

* Angular CLI initially failed because commands were executed outside the Angular workspace.
* Understood the importance of executing Angular CLI commands from the project directory containing `angular.json`.
* Encountered TypeScript 6 editor warning related to `outDir`, verified that the project compiled successfully and identified it as a non-blocking editor warning.

---

## Key Learning

Angular uses data binding to establish seamless communication between HTML templates and TypeScript logic, enabling dynamic and interactive web applications while maintaining a clean component-based architecture.
