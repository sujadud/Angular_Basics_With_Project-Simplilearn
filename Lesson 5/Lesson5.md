# Angular Basics - Simplilearn

## Lesson 5 - Angular Forms

What's in it for you?

- Introduction to Angular Forms
- Types of Form Building
- Form Control and Grouping
- Form Demo

### 5.1 Inroduction to Angular Forms

In Angular, forms are essential for handling user input. They allow you to coordinate data-bound controls, track changes, validate input, and handle errors.

- Forms are an integral part of a web application.
- Forms are used to **log in**, to **update a profile,** to **enter sensitive informaiton,** and to perform many other **data-entry tasks**.

### 5.2 Types of Form Building

In Angular, There are two main approaches to creating forms in Angular:

1. Template-Driven
2. Reactive Forms

#### 5.2.1 Template Driven

- Directives
- Module classes
- JSON values
- Validation

### Reactive Forms

- Components manage the data-flow
- Code-driven
- No two-way data binding
- Synchronous creation

### 5.3 Form Control and Form Group

#### 5.3.1 Form Control

- **Form Control** is a class that enable validation.
- For each input field an **instance of this class** is created.
- These instances help check the values of the field and see if they are **touched, untouched and dirty**.

#### 5.3.2 Form Group

- FormGroup class represents a group of controls.
- A form can have multiple control groups.
- The Form Group class returns True if all the controls are valid.
- It also provides all the validation errors.

### 5.4 Form Demo

In the demo we will learn about:

- Import and use Angular Form.
- Angular Directives: **ngModel**, **ngSubmit**,
- Makeing variable inside html **#login**.
- Data passing using **submit(login)** method.
- Add validation using **ngIf**.

ex: I'm added bootstrap also in the project. To add bootstrap using this cmd:

    npm install bootstrap

After install we need to add it on `Angular.json` file.

    "styles": [
    "src/styles.css",
    "node_modules/bootstrap/dist/css/bootstrap.min.css"
    ],
    "scripts": [
    "node_modules/bootstrap/dist/js/bootstrap.bundle.min.js"
    ]

Then import it on main `app.component.css` file.

    @import '~bootstrap/dist/css/bootstrap.min.css';

🚀 Enjoy Bootstrap inside the project. 🎉 Happy coding! 💻
