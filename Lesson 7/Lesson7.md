# Angular Basics - Simplilearn

### 07 Angular Bootstrap

#### 7.1 What is Bootstrap?

**Bootstrap** is a powerful toolkit - a collection of HTML, CSS, and JavaScript tools for creating and building web pages and web applications.

It is a free and open source project, hosted on **GitHub, and originally created by (and for) Twitter.**

#### 7.2 Embedding Bootstrap Into Angular

- **Bootstrap CDN:**
 Bootstrap CDN is a public content delivery network. It enables users to load CSS, JavaScript and images remotely from its servers.

- **Bootstrap NPM**
Bootstrap, jQuery and other packages and frameworks can be installed on the command prompt.

#### 7.3 Creating an Application with Angular Bootstrap

In this demo project we will name it

    ng new DemoComponents

and install jQuery using `npm`

    npm install jquery

Then we will install Bootstrap:

    npm install bootstrap

After install we need to configure our `angular.json` file:

    "styles": [
    "src/styles.css",
    "node_modules/bootstrap/dist/css/bootstrap.min.css"
    ],
    "scripts": [
    "node_modules/bootstrap/dist/js/bootstrap.bundle.min.js"
    ]

🚀 See my project. 🎉 Happy coding! 💻
