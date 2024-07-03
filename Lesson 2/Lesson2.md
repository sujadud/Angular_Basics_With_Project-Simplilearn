
# Angular Basics - Simplilearn

## Lessons to learn

 1. What is Angular?
 2. Angular Hello World!
 3. Angular Components
 4. Angular Dependency Injection
 5. Angular Forms
 6. Angular Services
 7. Angular Bootstrap
 8. React vs Angular vs Vue
 9. What's new with Angular 10
 10. Angular Interview Questions

## Lesson 2 - Angular Hello World with Demo

### 2.1 Angular Prerequisites

1. NodeJS
2. Angular CLI
3. VS Code

#### 2.1.1 NodeJS

Angular uses Node.js as its ase for large part of its build environment.
In this repo I've used **[Node v18.20.3 (LTS)](https://nodejs.org/en/blog/release/v18.20.3)**

#### 2.1.2 Angular CLI

Angular team has created a command-line interface (CLI) tool to make it easier to bootstrap and Angular applications.
In this repo I've used Angular CLI 15.
To install Angular CLI version 15 with Node.js v18.20.3 (LTS), follow these steps:

1. Open a terminal or command prompt.
2. Check Node.js version:
    > node -v
3. Install Angular CLI version 15:

    > npm install -g @angular/cli@15

4. Verify Angular CLI installation:

    > ng version

It will show up this informations:

   > Angular CLI: 15.2.11
    Node: 18.20.3
    Package Manager: npm 10.7.0
    OS: win32 x64

#### 2.1.3 VS Code

Visual Studio Code is a powerful source code editor that is available on Windows, MacOS and Linux platforms.
Download the latest [Visual Studio Code](https://code.visualstudio.com/Download) on your system.

### 2.1 Angular Demo

Create a folder in your File Manager/Desktop and open it on vscode.
To create our first app using Angular need to open terminal on vscode use this command.

   > ng new Hello-world

#### 2.1.2 Follow the Prompts

- You may be prompted to add Angular routing. Type `y` (yes).
- Choose the stylesheet format (CSS) form the options.

Wait for a moment to create the project.

#### 2.1.3 Serve the Application

When it's done change the directory:
> cd Hello-world

**Serve the Application**: Run the following command to serve the application:
> ng serve

**Access the Application**: Open your web browser and navigate to `http://localhost:4200`. You should see the default Angular welcome page.

**In this Hello World project, we deliberately modified the text to test its functionality.**
> `<span>{{ title }} app is running!</span>`

This line of code is changed.
> `<span>Hey! Welcome to this Anguler Tutorial</span>`
