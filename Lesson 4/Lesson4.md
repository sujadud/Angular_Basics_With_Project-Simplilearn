## 4. Angular Dependency Injection
What's in it for you?

 - What is Dependency Injection?
 - Demerit of Not Using DI
 - DI as a Design Pattern
 - DI Demo
 
### 4.1 What is Dependency Injection?
**Dependency Injection (DI)**  in Angular is a design pattern and mechanism for creating and delivering some parts of an application to other parts that require them.
 - To avoid rewriting of code, Angular Services can be used.
 - These services can then be **injected** into the components that require that service.
 - Dependency Injection or DI keeps the code flexible, testable and mutable.
 - Classes can inhrit external logic withot knowing how to create it.
 - DI is benefits directives, pipes and components.
 

### 4.2 Demerit of Not Using DI
Let's condider a **PostalDetails** class that is dependent on the **Number** and the **Address** class. 

    class Number{
	    constructor(){}
    }
    
    class Address{
	    constructor(){}
    }
    
    class PostalDetails{
	    Number;
	    Address;
	    constructor(){
		    this.Number = new Number();
		    this.Address = new Address();
	    }
    }

In the **PostalDetails** class the constructor copies the **Number** and the **Address**. New **PostalDetails** class the contractor ancient a unique number and address, now all of this look simple as a problem with this code. 

The **Number** and **Address** class contructors now expect perameters.

    class Number{
    	    constructor(parameter){}
        }
        
        class Address{
    	    constructor(parameter){}
        }
        
        class PostalDetails{
    	    Number;
    	    Address;
    	    constructor(){
    		    this.Number = new Number();
    		    this.Address = new Address();
    	    }
        }

Maybe change the numbers class the **PostalDetails** class gets broken overcome this for we need to do if we need to pass parameter to the **Number** constructor. So this applies to **Address** as well the first drawback of using the traditional network is that, the code is not very flexible anytime the dependency change the **PostalDetails** class needs to be changed as well, and the second drawback is the code is not suitable for testing? 
Once you instantiate the **PostalDetails**  you get the same number and address even if you change the **Number** and **Address** classes everytime what and these classes are in done dependent on other classes then is going to be a change reaction. So to overcome this we make this of dependency induction.

### 4.3  DI as a Design Pattern
Now, let's look DI as pattern. 

    class PostalDetails{
		Number;
	  	Address;
    	constructor(number, address){
	    	this.Number = number;
    		this.Address = address;
    	}
    }

Dependency injection as you all known as according pattern where a class receive dependency from an external source problem creating them on its own so hear in the above example, we have moved definition of dependencies from inside the constructor to the constructors parameters for the postal details class doesn't create the dependency anymore. So that we overcome the drawbacks of not using DI.

So, now that you know what exactly dependency injection is and how vital it is, let's look at a simple demonstration to understand the concept better.

### 4.4 DI Demo 
Now services, classes, modules, components, all of these are benefactors of dependency induction. So in the demo, I am going to be showing how to injection can be used for the help of services and injecting the services into classes for the main thought behind this is:

 - Normally, components are used to ensure  a good use experience.
 - In order ot execute tasks, using **Services** is ideal.
 - A component can delegete tasks **like feteching data from the serverm validating user input, or logging directly** to the console to the Service.
 - These tasks can be made available to any **component in the app**.

**Use Case:**

 - Create a Service that performs the task of displaying an employee list.
 - Inject the service into the class using Dependency Injection.

**Let's go, into the code.**
