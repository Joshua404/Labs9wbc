//Homework 19 May 2015
//Start HOMEWORK
//1

//Create an object using the constructor approach from this morning
//This object should have 3 properties
//Assign each property a value

var person = new object();

person.name = "Joshua";
person.age = 20;
person.job = true;


//2

//Create an object using literal notation initialized to an empty object
//This object should have 5 properties
//Assign each property a value

var personOne = {};

personOne.name = "Bob";
personOne.age = 18;
personOne.job = false;
personOne.porsche = "Check";
personOne.Badass = "You Betchya";

//3

//Create an object using literal notation initiazlied to a non-empty object
//with 5 properties. Ensure each property has a value

var personTwo = {
    name: "Jason",
    age: 25,
    job: true,
    LeatherJacket: true,
    Relationship: "Complicated",
};


//4

//Create an object with 3 properties and one method. Use any approach to create the
//object

var car80 = {
    make: Ford,
    model: Mustang,
    tranny: Auto,
    acc: function () {
        alert("Accelerating");}
};

//5

//Create an object constructor. The object constructor should take three parameters.
//	Create 3 objects with this object constructor

//	***DON'T FORGET TO PASS VALUES TO YOUR CONSTRUCTORS IF YOUR CONSTRUCTOR TAKES PARAMETERS***

//Add a method to the object constructor you just created that alerts("Hello!") when called.


var wrx = new car ("Subaru", "WRX", "Stick");
var brz = new car ("Subaru", "BRZ", "Stick");
var outback = new car ("Subaru", "Outback", "Automatic");
function car (make, model, tranny) {
    this.make = make
    this.model = model
    this.tranny = tranny
    this.hmb = function () {
        alert("Hello My Beloved!!");}
}

//6

//Create an object using literal notation initialized to a non-empty object with 5 properties
//Each property should have a value. Write a for-in loop that console.logs each value
//within the object to the console.

var person6 = {
    name: "Jason",
    age: 25,
    job: true,
    LeatherJacket: true,
    Relationship: "Complicated",

};
function loop() {
    for (var key in person6) {
        console.log(person6[key]);
    }
}

//7

//Create 3 object constructors
//1 Object constructor called Animal that takes in a parameter isAlive (boolean)
//Attach a method to the Animal's prototye that alerts("Running!");
//1 Object constructor called Person that takes 3 parameters (choose your parameters)
//1 Object constructor called Dog that takes 3 parameters (choose your parameters)
	
//Create 1 object using Person constructor. Then assign the Animal prototype to Person.
//Create 1 object using Dog constructor. Then assign the Animal prototype to Dog.
	
//***DON'T FORGET TO PASS VALUES TO YOUR CONSTRUCTORS IF YOUR CONSTRUCTOR TAKES PARAMETERS***
function Animal(type) {
    this.type = type;
}
Animal.prototype.cat = function () {
    alert("Running");
}


function person(name, haircolor, age, job) {
    this.name = name
    this.haircolor = haircolor
    this.age = age
    this.job = job
}

var person = new person("Adam", "Black", 26, true);

person.__proto__ = Animal.prototype;

function dog(name, color, sex) {
    this.name = name
    this.color = color
    this.sex = sex
}

var dog = new dog("Fred", "Green", "Male");
dog.__proto__ = Animal.prototype;

//8

//Create 1 object using Object.create(). Pass the Animal prototype into the Object.create() method.


var amess = Object.create(Animal.prototype);

//End HOMEWORK




