"use strict";

//function divDemoModify() {
//    var div = document.getElementById("divDemo");
//    console.log(div);
//    console.log(div.innerHTML);
//    div.innerHTML = "Hjnkojlikjol";
//}


//function divDemoModify() {
//    var div = document.getElementById("divDemo");
//    //var k = 0;
//    console.log(div);
//    console.log(div.innerHTML);
//    for (var k = 0; k < 101; k++) {
//        div.innerHTML += k+'-';
//    }
//}

//function divDemoModifyVerticle() {
//    var div = document.getElementById("divDemo");
//       for (var k = 0; k < 101; k++) {
//        div.innerHTML += '<p>' + k + '</p>';
//    }
//}

//function divDemoModify() {
//    var div = document.getElementById("divDemo");
//    for (var k = 0; k < 101; k++) {
//        div.innerHTML += '<p class ="square"> </p>';
//    }
//}

//function divDemoModifyVerticleFormal() {
//    var div = document.getElementById("divDemo");
//    for (var k = 1; k < 101; k++) {
//        var paragraph = document.createElement('p');
//        //var cssClass = document.createAttribute("class");
//        //cssclass.value = "square";
//        paragraph.setAttribute("class", "square");
//        div.appendChild(paragraph);
//    }
//}

//function multiDivTarget() {
//    var nodes = document.getElementsByTagName("div");
//    console.log(nodes);

//    //for  (var div in nodes) {
//    //    nodes[div].innerHTML = "Hello";
//    //}

//    for (var k = 0; k < nodes.length; k++) {
//        nodes[k].innerHTML = "Hello";
//    }
//}

//function multiDivTarget() {
//    var nodes = document.getElementsByTagName("div");
////    console.log(nodes);
////    //for  (var div in nodes) {
////    //nodes[div].innerHTML = "Hello";
////    //}
//    var length = nodes.length;
//    for (var k = 0; k < length; k++) {

//        for (var r = 0; r < 10; r++) {
//            nodes[k].innerHTML += '<p class="square"></p>';
//        }
//    }
//}

//function multiDivTardetClassName() {

//    var nodes = document.getElementsByClassName("square");
//    var length = nodes.length;
//    var convert = [];
    //for (var k = 0; k < length; k++) {
    //    convert.push(nodes[k]);
    //}
    //for (var k = 0; k < length; k++) {
    //    convert[k].className = "circle";
    //}

//    for (var k = 0; i < nodes.length; i = 0) {
//        nodes[k].className = "circle";
//    }
//}
//function multiDivTargetName() {
//    var nodes = document.getElementsByName("josh");

//    for (var k = 0; k < nodes.length; k++) {
//        nodes[k].value = "oeiffoe;hiwee re eop wp;ou";
//    }
//}

function tenCircles() {
    var inputOne = document.getElementById("inputDemoAlert2");
    inputOne.addEventListener("click", function () {
        var nodes = document.querySelector("#hhjj");
        for (var o = 0; o < 11; o++) {
            nodes.innerHTML += '<p class ="circle"> </p>';
        }
    });
   
}

function AttachEventListeners() {
    var inputOne = document.getElementById("inputDemoAlert");
    inputOne.addEventListener("click", function () {
        alert("Hello");
    });
}

AttachEventListeners();