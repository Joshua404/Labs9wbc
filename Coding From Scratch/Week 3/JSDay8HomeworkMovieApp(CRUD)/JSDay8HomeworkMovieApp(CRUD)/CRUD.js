"use strict";
//Afternoon project!

//Make a movie app that has full CRUD!

//For you movie object, please include a movie title, a movie director, year released, and critic rating.

var guid = 0;

// Storage of Movie Data
var storage = [];

// Movie Object Constructor
function Movie(movieTitle, movieDirector, yearReleased, criticRating, id) {
    this.movieTitle = movieTitle;
    this.movieDirector = movieDirector;
    this.yearReleased = yearReleased;
    this.criticRating = criticRating;
    this.id = id;
}

// Create Function
function create(form) {
    // SR: To create movies as data.
    // Generate #ID for movie
    var id = storage.length;

    // Creation of movies via user interaction
    var movie = new Movie(form.inputMovieTitle.value, form.inputMovieDirector.value, form.inputYearReleased.value, form.inputCriticRating.value, id);

    // Add movie to MovieData
    storage.push(movie);

    // Display Movie to index.html
    // Target desired location
    var tbody = document.getElementById("tbodyDisplayMovies");

    // Adding the data to the html.table to display to user
    tbody.innerHTML += '<tr id="tableRow' + movie.id + '">\
    <td>' + movie.movieTitle + '</td><td>' + movie.movieDirector + '</td><td>' + movie.yearReleased + '</td><td>' + movie.criticRating + '</td><td>\
    <input type="button" value="Remove" onclick="removeTableRow(' + movie.id + ', this)" />\
    <input type="button" value="Edit" onclick="showModal(' + movie.id + ')" /></td></tr>';
}

function removeTableRow(key, row) {
    storage[key] = null;
    var pos = row.parentNode.parentNode;
    document.getElementById("tableDisplayMovies").deleteRow(pos.rowIndex);
}

function showModal(key) {
    var movie = storage[key];

    document.getElementById("editMovieTitle").value = movie.movieTitle;
    document.getElementById("editMovieDirector").value = movie.movieDirector;
    document.getElementById("editYearReleased").value = movie.yearReleased;
    document.getElementById("editCriticRating").value = movie.criticRating;

    guid = key;
    $("#modalEdit").modal("show");
}

function update(form) {
    storage[guid].title = form.editMovieTitle.value;
    storage[guid].director = form.editMovieDirector.value;
    storage[guid].released = form.editYearReleased.value;
    storage[guid].rating = form.editCriticRating.value;

    var row = document.getElementById("tableRow" + guid);

    var movie = storage[guid];

    row.innerHTML = '<td>' +
    movie.title + '</td><td>' + movie.director + '</td><td>' +
    movie.released + '</td><td>' + movie.rating +
    '</td><td><input type="button" value="Remove" onclick="removeTableRow(' +
    movie.id + ', this)"/><input type="button" value="Edit" onclick="showModal(' + movie.id + ')" /></td>'


    $("#modalEdit").modal("hide");
}