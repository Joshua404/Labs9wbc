////object constructor

//var person = new object();

//person.name = "Joshua";
//person.age = 20;
//person.job = true;



////literal Notation
//var personOne = {};

//personOne.name = "Bob";
//personOne.age = 18;
//personOne.job = false;

//var personTwo = {
//    name: "Jason",
//    age: 25,
//    job: true
//};


//Coding Sprint
var person = new Object();

person.name = "Joshua";
person.age = 23;
person.job = true;
person.InSchool = true;
person.BlackPants = "Got Them";



//literal Notation
var personOne = {};

personOne.name = "Chaz :)";
personOne.age = 18;
personOne.job = false;
personOne.InSchool = "DropOut";
personOne.BlackPants = "Lost Them";

var personTwo = {
    name: "Jason",
    age: 25,
    job: true,
    school: "Graduated",
    BlackPants: "Sold Them",
};
//End Coding Sprint

    var personThree = {
        "Hello My Name is TOM": true,
        true: false,
        90: 45,
        personTwo: personOne
    };

    var personFour = {
        name: "Jackson",
        age: 27,
        job: "FBI",
        school: "Graduated",
        BlackPants: "Bought 10 Pair",
        car: true,
        mac: true,
        relationship: "complicated",
        Badass: "Check",
        resides: "New York"

    };
    console.log(personFour.name)
    console.log(personFour.age)
    console.log(personFour.job)
    console.log(personFour.school)
    console.log(personFour.BlackPants)
    console.log(personFour.car)
    console.log(personFour.mac)
    console.log(personFour.relationship)
    console.log(personFour.Badass)
    console.log(personFour.resides)

    var demo = {
        exampleone: function () {
            console.log(2 + 2);
        },
        bepolite: "Hello Sugar",
        partyinabottle: "Vodka",
        alert: ("There is a Bomb in Your Mac!!!"),
        exampletwo: function () {
            console.log(Shake);
        },
        car: "Learn To Drive",
        kitchen: "Learn To Cook",
        food: "hmmm, Steak and Eggs?",
        alert: ("I might Like You?"),
        moo: "I like Cow!!!",
    }

    //function loop() {
    //    for (var key in demo) {
    //        console.log(demo[key]);
    //    }
    //}


    //var father = new Person("Bob", 45, true, drivessafely);
    //function Person(name, age, job, drives) {

    //    this.name = name;
    //    this.age = age;
    //    this.job = job;
    //    this.cow = function () {
    //        alert("Hello");
    //    }
    //    this.drives = drives;

    //}

    //function drivesreallycrazy() {
    //    alert("I drive crazy!");
    //}

    //function drivessafely() {
    //    alert("I drive safely");
    //}



    var Pen1 = new pen("Blue", false, "Pink", "Obama", true);
    var Pen2 = new pen("Black", true, "Black", "Jason Bourne", false);
    var Pen3 = new pen("Green", false, "Yellow", "AI", true);
    var Pen4 = new pen("White", true, "Blue", "Steve Rogers", false);
    var Pen5 = new pen("Pink", true, "Black", "Putin", true);

    function pen(color, canWrite, inkColor, owner, isCapped) {

        this.color = color
        this.canWrite = canWrite
        this.inkColor = inkColor
        this.owner = owner
        this.isCapped = isCapped

    }



    var father = new Person("Bob", 45, true, drivessafely);
    function Person(name, age, job, drives) {

        this.name = name;
        this.age = age;
        this.job = job;
        this.cow = function () {
            alert("Hello");
        }
        this.drives = drives;
        var jgarr = [];
        jgarr.push(father);
        function loop() {
            for (var key in person) {
                console.log(person[key]);
            }
        }
    }

    function drivesreallycrazy() {
        alert("I drive crazy!");
    }

    function drivessafely() {
        alert("I drive safely");
    }






    function Automobile(type) {
        this.type = type;
    }
    Automobile.prototype.wheel = 4;
    Automobile.prototype.barf = function (){
        alert("Accelerating");
    }


    function car(name, color, make, model) {
        this.name = name
        this.color = color
        this.make = make
        this.model = model
    }

    var porsche = new car("Honey", "Black", "Porsche", "911");

    porsche.__proto__ = Automobile.prototype;

    function truck(hasFourWheelDrive, color) {
        this.name = name
        this.color = color
        this.make = make
        this.model = model
    }

    var atruck = new truck(true, "Green");

    function van(isHatchBack, color, make, model) {
        this.name = name
        this.color = color
        this.make = make
        this.model = model
    }

    var avan = new van(true, "(Barf) Tan", "Beats Me", "Bad Styling");


    var example = Object.create(Automobile.prototype);
    var demo = Object.create(null);