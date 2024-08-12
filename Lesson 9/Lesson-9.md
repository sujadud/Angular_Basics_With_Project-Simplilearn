# Angular Basics - Simplilearn

## Lesson 9 - React vs Angular vs Vue

Comparison beetween ReactJS, Angular and Vue with respect to..

 1. Features
 2. Use Case
 3. Performance
 4. Data binding
 5. Scripting
 6. Testing
 7. Community Support
 8. Growth Curve

### 9.1. Salient Features

 | ReactJS | Angular | VueJS |
|---|---|---|
| Open source, front-end **JavaScript library**.  | Open source, **JavaScript  framework**.  | Open source, **JavaScript  framework**.  |
| Used to develop web nad mobile applications  | Primarily aimed to develop single page applications  |   Used to develop user interfaces and single page applications |
|  Developed by **Facebook** |  Developed by **Google** | Developed by **Evan You**, an ex Google employee  |
|  React represents the view part of the **MVC framework** | Angular is a full fledged **MVC framework** | Vue is focused on the **View and Model** layer of the MVC framework |

MVC is an architectural pattern that separates the application layer into Model, View and Controller.

|   |   |   |
|---|---|---|
|  | Model  |  |
|  View | << | Controller  |
**Model** relates to all data related logic
**View** is used for the IJI logic of the application
**Controller** is an interface between the Model and View

### 9.1 Use Case

**React:** Facebook, Netflix, Instagram, Airbnb, Dropbox, WhatsApp, etc.
**Angular:** Forbes, Nike, Upwork, Sony, HBO.
**Vue:** Adobe, Alibaba, Grammerly, 9GAG, Xiaomi.

### 9.2 Performance

| ReactJS | Angular | VueJS |
|---|---|---|
| Reackt uses **virtual DOM** to fill in data in the HTML DOM  | Angular uses **real DOM**.  | Vue uses **virtual DOM** as an adopted concept of React  |
| A **virtual DOM** only looks at the differences between the previous and current HTML and changes the part that is required to be updated  | This **will update** the entire tree structure of HTML tags unit it reaches the data to be updated |  Vue updates any altered HTML and does not update the entire tree |
|  Virtual DOM makes extremely fast |  It is time-consuming, risky and can attact a lot of bugs | This ensures faster and bug-free performance  |

### 9.3 Data Binding

Data binding is a process that allow an Internet user to manipulate Web page elements using Web browser.

It is used in Web pages that contain interactive components such as forms, calculators, tutorials, and games.

| ReactJS | Angular | VueJS |
|---|---|---|
| React only uses **one-way binding**.  | Angular uses **two-way binding**.  | Vue uses **reactive two-way data binding**.  |
| First, the **model state** is updated, and then it renders the change in the UI element(view). | Any changes made in the **UI element** is reflected in the corresponding **model** state and vice versa.  | Vue uses **reactive two-way data binding**. |
| Improves performance since everything is modular and fast | This approch adversely affects the performance. | It automatically picks the correct way to update the element based on the input type. |

### 9.4 Scripting langulage

| ReactJS | Angular | VueJS |
|---|---|---|
|  React combines **UI** templates and **JavaScript logic.** The result is called **JSX.** React only requires the knowledge of JavaScript. |  Angular uses templates that are enhanced **HTML with Angular Directives**. Angular requires the knowledge of the specific syntax. | Vue.js uses **HTML-based template** syntax. All Vue.js templates are valid HTML that can be parsed by parsers |

### 9.5 Testing

| ReactJS | Angular | VueJS |
|---|---|---|
|  **Jest** is used by Facebook to run tests on React. It's embedded in every React library and requires zero configuration. | Angular uses **Jasmine** to run various testes. The **Jasmin framework** allows virious functionalities to write different kinds of tests cases. | Vue CLI has built-in options for unit testing with **Jest** or **Mocha**. Vue's **single-file components** make it straight forward to write unit tests for components in isolation. |

### 9.6 Community  support

| ReactJS | Angular | VueJS |
|---|---|---|
| A few popular Github repositories on react are ***reactjs101, reactjs.org, reason-react, react-paginate*** | ***Angular, angular.js, angular-cli, angular-seed*** are a few Github repositories. | ***Vue-awesome-swiper, vuejs.org, vue-Apollo*** have gained popularity |
| At the time of writing, there were about, **1m - Repositories** **5M - Commits** **1M - Issues** | Conversely, there were about, **556K - Repositoties** **1M - Commits** **570K - Issues** | Vue has about, **308K - Repositoties** **812K - Commits** **302K - Issues** |
| Over the past **two** years, there have approximately **360 million** React-JS downloads. source: npm-stat_ com |  Angular has had approximately **38 million** downloads in the past 2 years. source: npm-stat_ com  |  Vue on the other hand, has had approximately **63 million** downloads in the past 2 years. source: npm-stat_ com |
