"use strict";



function calculatePowerofTwo(form) {
    var number = parseInt(form.inputinteger.value);


    if (!isNaN(number)) {
        form.displayResults.value = number + calculate(number);
    }
    else {
        alert("Please Enter a Valid Number");
    }

    function calculate(value) {
        if (!(value & (value - 1))) {
            return " Is a power of two";
        }
        else {
            return " Is not a power of two";
        }
    }
}



//"use strict";



//function calculatePowerofTwo(form) {
//    var number = parseInt(form.inputinteger.value);


//    if (!isNaN(number)) {

//    }
//    else {
//        alert("Please Enter a Valid Number");
//    }

//    function calculate(value) {
//        if (!(number & (number - 1))) {
//            form.displayResults.value = number + " = power of two";
//        }
//        else {
//            form.displayResults.value = number + " Is Not a power of two";
//        }
//    }
//}