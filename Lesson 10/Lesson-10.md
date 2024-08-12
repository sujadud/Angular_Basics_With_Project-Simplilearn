# Angular Basics - Simplilearn

## Lesson 10 - What's new with Angular 10

What's in it for you?

- Angular Versions
- What's new with Angular 10?
- How to update to Angular 10?

### 10.2 Angular Versions

1. Angular 1
2. Angular 2
3. Angular 4
4. Angular 5
5. Angular 6
6. Angular 7
7. Angular 8
8. Angular 9
9. Angular 10

| Version | Key Features |
|---|---|
| AngularJS 1.x | DOM manipulation, Two-way data binding, MVC, Directives, Services, Dependency injection |
| Angular 2 | Component-based architecture, TypeScript, improved performance |
| Angular 4 | Smaller bundle size, improved performance, Angular CLI enhancements |
| Angular 5 | Build optimizer, compiler improvements, Angular Universal (SSR) |
| Angular 6 (LTS) | NgRx integration, CLI workspace, Angular Elements |
| Angular 7 | Virtual scrolling, CLI prompts, performance improvements |
| Angular 8 (LTS) | Lazy loading, differential loading, TypeScript 3.1, CLI updates |
| Angular 9 | Ivy renderer by default, improved template type checking |
| Angular 10 | Language service improvements, stricter type checking, default browser configuration |

### 10.3 What's new with Angular 10?

- Older version of TypeTypeScript not supported
- Warnings about CommonJS imports
- Optional strict setting
- Ngcc features
- Compailer update
- URL routing updation
- Deprecated APIs
- Bug fixes
- New default browser configuration
- Core
- Converting pre lvy code
- Sercvice workers

#### 10.3.2 Angular 10 official release notes for detailed information on each new features and changes

1. **TypeScript Compatibility**:

    - Angular 10 dropped support for older TypeScript versions (prior to TypeScript 3.9). It encourages developers to use more recent TypeScript versions for better language features and performance.

2. **CommonJS Imports Warnings**:

    - Angular now warns when you use CommonJS-style imports (e.g., `require('module')`) instead of ES6 imports (`import { ... } from 'module'`). This promotes better compatibility with modern JavaScript modules.

3. **Optional Strict Mode**:

    - Angular 10 introduced a strict mode configuration option (`strictTemplates`). When enabled, it enforces stricter template type checking, improving code quality and catching potential issues early.

4. **Ngcc (Angular Compatibility Compiler) Enhancements**:

    - Ngcc is responsible for transforming Angular libraries into a format compatible with Ivy (Angular’s new rendering engine).
    - Angular 10 improved Ngcc’s performance and handling of third-party libraries.

5. **Compiler Update**:

    - The Angular compiler received updates, enhancing performance and reducing bundle size.
    - These improvements benefit both development and production builds.

6. **URL Routing Update**:

    - Angular’s router now supports relative link resolution for lazy-loaded modules. This simplifies navigation and improves maintainability.

7. **Deprecated APIs**:

    - Deprecated APIs were removed in Angular 10. Developers should update their code to use recommended alternatives.

8. **Bug Fixes**:

    - Angular 10 addressed various bugs and issues reported by the community.

9. **New Default Browser Configuration**:

    - Angular now sets the default browser configuration to use `es2015` for differential loading. This ensures better compatibility with modern browsers.

10. **Core Improvements**:

    -   The core Angular framework received enhancements, including better performance and stability.

11. **Converting Pre-Ivy Code**:

    -   Angular 10 continued the migration path from View Engine (pre-Ivy) to Ivy. Developers can gradually update their applications to leverage Ivy’s benefits.

12. **Service Workers**:

    -   Service worker support was improved, enabling better Progressive Web App (PWA) experiences.

### 10.4 How to update to Angular 10?

To update your Angular application from older version to version 10, follow these steps:

### Step 1: Upgrade Angular CLI Globally

1. **Update Angular CLI globally**:
   Open your terminal and run the following command to update the Angular CLI globally to version 10:

   ```bash
   npm install -g @angular/cli@10
   ```

2. **Verify the Update**:
   After installation, check the version to ensure it's updated:

   ```bash
   ng version
   ```

### Step 2: Update Angular CLI Locally in the Project

1. **Navigate to Your Project Directory**:

   ```bash
   cd your-project-directory
   ```

2. **Update Angular CLI and Core**:
   Use the Angular CLI command to update the core framework and CLI in your project:

   ```bash
   ng update @angular/core @angular/cli
   ```

### Step 3: Update Other Angular Dependencies

Angular typically updates other dependencies like Angular Material, RxJS, etc., during a major version upgrade. Use the following commands to update them:

1. **Update Angular Material (if used)**:

   ```bash
   ng update @angular/material
   ```

2. **Update other dependencies**:
   Check the output from the previous `ng update` commands. If there are other packages that need updating, you’ll see suggestions in the terminal. You can update them with similar `ng update` commands or manually adjust the `package.json` and then run `npm install`.

### Step 4: Fix Breaking Changes (if any)

Angular provides a detailed [update guide](https://update.angular.io/) for handling specific breaking changes and recommended fixes between versions.

1. **Visit Angular Update Guide**:
   Go to the [Angular Update Guide](https://update.angular.io/) and select your current version (9.x) and the target version (10.x). This guide will provide detailed steps on handling breaking changes.

2. **Test Your Application**:
   After upgrading, thoroughly test your application to ensure everything works as expected. Pay attention to the console for any warnings or errors related to the update.

### Step 5: Cleanup and Final Check

1. **Remove deprecated code**:
   Angular might deprecate certain APIs between major versions. Consider refactoring any deprecated code.

2. **Run and Test Your Application**:
   Run the application using:

   ```bash
   ng serve
   ```

   Ensure everything is functioning properly. If any issues arise, refer to the Angular documentation or the console output for guidance.
and
Following these steps should successfully upgrade your old project to Angular 10. Be sure to test thoroughly after the upgrade to catch any issues early.
