"use strict";

function AttachEventListeners1() {
    var inputOne = document.getElementById("input1");
    inputOne.addEventListener("click", function () {
        addImage();
    });
}


function addImage() {
            var nodes = document.querySelector("#divOne");
            if(divOne) {
                //nodes.innerHTML = img http://www.http://cdn2.hubspot.net/hub/111839/file-16363314-jpg/images/facebook_thumbnail.jpg />
                    var img = new Image();

                img.onload = function() {
                    nodes.appendChild(img);
                };

                img.src = 'facebook_thumbnail.JPG';
            }
        }

  



function AttachEventListeners2() {
    var inputOne = document.getElementById("input2");
    inputOne.addEventListener("click", function () {
        draw10squares();
    });
}

function draw10squares() {
        var nodes = document.querySelector("#divTwo");
        for (var k = 1; k < 11; k++) {
            var paragraph = document.createElement('p');
            paragraph.setAttribute("class", "square");
            nodes.appendChild(paragraph);
        }
}

function AttachEventListeners3() {
    var inputOne = document.getElementById("input3");
    inputOne.addEventListener("click", function () {
        divHelloWorld();
    });
}

function divHelloWorld() {
    var div = document.getElementById("divThree");
       if (divThree) {
        div.innerHTML = '<h1>"Hello World!"</h1>';
    }
}



function AttachEventListeners4() {
    var inputOne = document.getElementById("input4");
    inputOne.addEventListener("click", function () {
        div1to100();
    });
}

function div1to100() {
        var div = document.getElementById("divFour");
        //var k = 0;
        console.log(div);
        console.log(div.innerHTML);
        for (var k = 0; k < 101; k++) {
            div.innerHTML += k+'-';
        }
}



function AttachEventListeners5() {
    var inputOne = document.getElementById("input5");
    inputOne.addEventListener("click", function () {
        div10circles();
    });
}

function div10circles() {
    var nodes = document.querySelector("#divFive");
    for (var k = 1; k < 11; k++) {
        var paragraph = document.createElement('p');
        paragraph.setAttribute("class", "circle");
        nodes.appendChild(paragraph);
    }
}
AttachEventListeners1();
AttachEventListeners2();
AttachEventListeners3();
AttachEventListeners4();
AttachEventListeners5();
