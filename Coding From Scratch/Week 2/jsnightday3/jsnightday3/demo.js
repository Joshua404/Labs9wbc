var number = parseInt(prompt("Enter A Number :)"));
if (number === NaN) {
    alert("What You Entered Is BS");
}
else if (number > 2) {
    var prime = true;
    for (var i = 2; i < number; i++) {
        if (!(number % i)) {
            prime = false;
            break;
        }
    }
    alert("The Number "+ number + " Is prime: "+ prime);
}
else if (number === 2) {
    alert("The Number 2 is Prime: True");
}
else if (number <= 1) {
    alert("The Number is Screwed :) so call me maybe :)");
}
