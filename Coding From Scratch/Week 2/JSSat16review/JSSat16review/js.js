//var sum = 9 + 5;
//var difference = 10 - 3;
//var product = 6 * 4;
//var quotient 28/7;
//var orderExampleOne = 7 * 2 +5;
//var orderExampleTwo = 5 + 5 * 5;
//var orderExampleThree = 10 - (7 + 5);
//var orderExampleFour = 5 * 3 + (10 + 2);


//console.log(sum);
//console.log(difference);
//console.log(product);
//console.log(quotient);
//console.log(orderExampleOne);
//console.log(orderExampleTwo);
//console.log(orderExampleThree);
//console.log(orderExampleFour);

//console.assert(sum === 14, "You LOSE");
//console.assert(difference === 7, "You LOSE");
//console.assert(product === 2342, "YOU DIE!!!");
//console.assert(quotient === 9378, "YOU LOSE");


//var big = prompt("Please Tell us Who You Want us to Kill?");
//alert(big);

//var small = prompt("Yo Chaz, How Old are You?");
//alert(small);

//var fff = confirm("Yes or NO");
//alert(fff);

//var demo1 = "Chaz dont use this one" + true; 
//var demo2 = "I am using this one" + null;
//var demo3 = "This one sucks" + undefined;
//var demo4 = "This one is is math" + 210;
//var demo5 = console.log + "I am logging some hot stuff";

//var ggg = "I wanna PARTY!!!";
//var hhh = "I wanna Blow Stuff up Virtualy";
//var jjj = "I love Hamburgers";

//var test39 = ggg.concat(hhh, jjj);

//var k = parseInt(prompt("Pick a number"));
//if (k === 10) {
//    console.log(k + " = 10");
//}

//else {
//    console.log(k + " is not = to 10");
//}



//    var k = parseInt(prompt("Pick a number"));
//if (k === 20) {
//    console.log(k + " = 20");
//}

//else if (k < 20) {
//    console.log(k + " is less than 20");
//}




//var k = parseInt(prompt("Pick a number"));
//if (k === 30) {
//    console.log(k + " = 30");
//}

//else if (k > 30) {
//    console.log(k + " is greater than 30");
//}

//else {
//    console.log(k + " is less than 30");
//}

var verify = prompt("What Do You Like?");

switch (verify.toLocaleLowerCase()) {
    case "":
        console.log("You entered nothing mr Loco");
        break;
    case "cats":
        console.log("You are Dispicable");
        break;
    case "funerals":
        console.log("You're Cute!");
        break;
}