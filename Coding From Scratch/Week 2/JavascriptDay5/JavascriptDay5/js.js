//function first() {

//    for (i = 100; i > 0; i--) {
//        console.log(i);
//    }
//}

//function second() {
//    for (i = 2; i <= 100; i++) {
//        if (i % 2 === 0)
//        console.log(i);
//    }
//}

//function Execute() {
//    for (i = 0; i <= 100; i++) {
//        if (i % 2 === 0) {
//            console.log(i + " is even");
//        }
//        else if (i % 2 === 1) {
//            console.log(i + " is odd");
//        }

//    }
//}
//"use strict";
//function Execute() {
//    var val1 = prompt("Put your number in");
//    var val2 = prompt("Put your other number in");
//    var k = parseInt(val1) + parseInt(val2);
//    alert(k);
//}
//"use strict";
//var myArr = [];
//var i;
//function Execute() {
//    for (i = 0; i <= 101; i++) {
//        if (i % 2 === 0) {
//            console.log("is even");
//            myArr.push("is even");
//        }
//        else if (i % 2 === 1) {
//            console.log(i);
//            myArr.push(i);
//        }

        
//    }
    
//}

"use strict";
function Execute() {
    var question = prompt("Please write \"add\" or \"subtract\"");
   
    if (question === "add") {
        add();
    }
    else if (question === "subtract") {
        subtract();
    }

}

function add() {
    var val1 = prompt("Put your number in");
    var val2 = prompt("Put your other number in");
    var k = parseInt(val1) + parseInt(val2);
    alert(k);
}

function subtract() {
    var val1 = prompt("Put your number in");
    var val2 = prompt("Put your other number in");
    var k = parseInt(val1) - parseInt(val2);
    alert(k);
}
