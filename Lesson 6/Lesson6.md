# Angular Basics - Simplilearn

## Lesson 5 - Angular Services

An Angular app divided into several components.

- Logo component
- Sign-in component
- Create-account component
- Image component
Now, these components are standard and each component a part of user interface.
Consider all these components performing common tasks like accessing the database, rendering images on the view, etc.

### Why Angular Services?

- To avoid rewriting of code, Angular Services are used.
- A service can be written once and injected into all the components that use that service.
- A service could be a function, variable or a feature that an application needs.

### What are Angular Services?

```markdown
|   |   |  --> | Component 1  | -->  |
| App  |  --> | Component 2  |  <-- | Service  |
|   |   |  --> |  Component 3 |  <-- |
```

- Normally, componensts are used to ensure a good user experience.
- In order to execute tasks, using Services in ideal.
- A component can delegate tasks like featching data from the server, validating user input, or logging directly to the console to the Service.
- These tasks can be made available to any component in the app.

### Features of Angular Services

- A Service is a Class
- Decotated with **@injective**
- They share the same piece of code
- Hold the business logic
- Interact with the backend
- Share data among components
- Services are singleton
- Registered on modules or components

### Services Demo

Use case -

 1. Create employee details such as name, employee ID and email ID.
 2. Click on the employee button to retrive an employee's data.
 3. Add the location for the employees in the list.
