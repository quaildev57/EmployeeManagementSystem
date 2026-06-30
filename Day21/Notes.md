# Day 21 Notes – Angular Forms & Two-Way Data Binding

## Topics Covered

* Angular Forms
* FormsModule
* Two-Way Data Binding (`ngModel`)
* Template-Driven Forms
* Event Binding with Forms
* Capturing User Input
* DOM (Document Object Model)
* Angular vs JavaScript Form Handling

---

## Angular Forms

Angular provides built-in support for creating and managing forms. For simple forms, Angular uses **Template-Driven Forms**, which rely on the `FormsModule`.

Before using `ngModel`, `FormsModule` must be imported into the component.

Example:

```typescript
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-login',
  imports: [FormsModule],
})
```

---

## Two-Way Data Binding (`ngModel`)

Two-way data binding synchronizes the value between the HTML input element and the TypeScript variable.

Syntax:

```html
<input [(ngModel)]="username">
```

Example:

```typescript
username = "";
```

If the user types:

```
Hrishita
```

Angular automatically updates:

```typescript
username = "Hrishita";
```

Similarly, if the variable changes in TypeScript:

```typescript
this.username = "Admin";
```

the textbox updates automatically.

---

## Data Flow using ngModel

```
User Input
     │
     ▼
HTML Input Field
     │
     ▼
ngModel
     │
     ▼
TypeScript Variable
     │
     ▼
Interpolation / Business Logic
```

---

## Interpolation vs Two-Way Data Binding

### Interpolation

Used to display data.

```html
{{ username }}
```

Flow:

```
TypeScript
      │
      ▼
HTML
```

It is **one-way** and does not capture user input.

---

### Two-Way Data Binding

```html
[(ngModel)]="username"
```

Flow:

```
TypeScript
      ⇅
HTML
```

Both the UI and the variable remain synchronized.

---

## Event Binding

Used to invoke TypeScript methods from HTML.

Example:

```html
<button (click)="login()">
```

Example Method:

```typescript
login()
{
    console.log(this.username);
    console.log(this.password);
}
```

---

## Document Object Model (DOM)

The DOM (Document Object Model) is the browser's internal tree representation of an HTML document.

Example:

```
Document
│
└── html
      │
      ├── head
      │
      └── body
            │
            ├── input
            ├── button
            └── p
```

JavaScript accesses HTML elements through the DOM.

Example:

```javascript
document.getElementById("username").value;
```

Angular abstracts this interaction by binding HTML directly to TypeScript variables using `ngModel`.

---

## Angular vs Plain JavaScript

### JavaScript

* Manual DOM manipulation
* Explicit retrieval of input values
* More repetitive code

Example:

```javascript
document.getElementById("username").value;
document.getElementById("password").value;
```

---

### Angular

```html
<input [(ngModel)]="username">
<input [(ngModel)]="password">
```

TypeScript:

```typescript
console.log(this.username);
console.log(this.password);
```

Angular automatically synchronizes the UI and application state.

---

## Login Component

Implemented:

* Username field
* Password field
* Login button
* User input capture using `ngModel`
* Login method to access user-entered values

---

## Key Learning

Angular minimizes direct DOM manipulation by maintaining synchronization between HTML templates and TypeScript variables through data binding. This improves maintainability, readability, and scalability while enabling interactive web applications with minimal boilerplate code.
