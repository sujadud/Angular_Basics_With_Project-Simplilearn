# Angular Basics - Simplilearn

## Lesson 3 - Angular Comoponents
### What's in it for you
- What are Angular Components?
- Creating an Angular Comoponent.
- Componet Decorator Metadata.

#### 3.2 What are Angular Components?
1. Most basic building block of an application.
2. Angular components are a subset of directives.
3. Only one component can be instantiated per element in a template.
4. @Component decorator provides additional metada
5. Component must belong to the Ng module.
6. Components implement Life-cycle hooks.

#### 3.3 Creating an Angular Comoponent.
To create an Angular component, we'll create a new project name DemoComponents.
1. Open vscode and in the terminal type the command:

    `ng new DemoComponents`

2. Exclude the project using terminal:

    `ng serve`

or

    `ng s`

3. Navigate to your project directory:

    `cd DemoComponents`

4. Generate a new component:

    `ng generate component textcomponent`

or 

    `ng g c TextComponent`

It will generate a new component in side the project location `DemoComponents/src/app/text-component`.
By default, this command creates the following files:

 1. A directory named after the component (text-component).
 2.   A component file (`text-component.component.ts`).
 3.  A template file (`text-component.component.html`).
 4.    A CSS file (`text-component.component.css`).
 5.    A testing specification file (`text-component.component.spec.ts`).

**Explanation:**
1.  **A Directory Named After the Component:**
    
    -   The Angular CLI creates a directory with the same name as your component /text-component. This directory contains all the component-related files.
2.  **Component File (`text-component.component.ts`):**
    
    -   This TypeScript file defines the behavior of your component.
    -   It contains the component class with properties, methods, and lifecycle hooks.
    -   You’ll write your component logic here, such as handling data, events, and interactions.
3.  **Template File (`text-component.component.html`):**
    
    -   The HTML template file defines the structure of your component’s UI.
    -   You’ll write the HTML markup here, including placeholders for dynamic data using Angular bindings (e.g.,  `{{ property }}`).
4.  **CSS File (`text-component.component.css`):**
    
    -   This optional file contains styles specific to your component.
    -   You can define CSS rules to style your component’s elements.
    -   The styles defined here only apply to this component.
5.  **Testing Specification File (`text-component.component.spec.ts`):**
    
    -   This file is for unit testing your component.
    -   It contains test cases to ensure your component behaves correctly.
    -   Writing tests helps maintain code quality and catch issues early.

Also, we have seen `/src/app/app.module.ts` is updated. The `/src/app/app.module.ts` file in an Angular application is the root module where you configure module imports, declare components, provide services, set up routing, and handle other app-level configurations. It’s a central place for managing your app’s structure and functionality.

#### 3.3 Componet Decorator Metadata.
The **Component Decorator Metadata** in Angular provides essential information about a class marked as an Angular component.

 1. Selector
 2.  Template
 3.  Template URL
 4.  Styles
 5.  StyleURLs
 6.  Providers 
 7.  Animations
 
Let’s break down the Angular Component Decorator Metadata:

1.  **Selector:**
    
    -   Specifies the HTML selector for the component.
    -   Determines how you use the component in templates (e.g.,  `<app-my-component>`).
2.  **Template:**
    
    -   Defines the component’s UI structure using an inline template (HTML markup).
    -   Example:  `template: '<p>Hello, Angular!</p>'`.
3.  **Template URL:**
    
    -   An alternative to inline templates.
    -   Points to an external HTML file containing the component’s UI.
    -   Example:  `templateUrl: './my-component.component.html'`.
4.  **Styles:**
    
    -   Defines CSS styles specific to the component.
    -   Inline styles within the  `styles`  property.
    -   Example:  `styles: ['p { color: blue; }']`.
5.  **Style URLs:**
    
    -   External CSS files linked to the component.
    -   Example:  `styleUrls: ['./my-component.component.css']`.
6.  **Providers:**
    
    -   Specifies services or dependencies available to the component.
    -   Used for dependency injection.
    -   Example:  `providers: [MyService]`.
7.  **Animations:**
    
    -   Configures animations for the component (if needed).
    -   Helps create smooth transitions and visual effects.

**Let's go, into the code.**
