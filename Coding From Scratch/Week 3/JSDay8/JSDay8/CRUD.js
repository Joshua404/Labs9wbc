"use strict";

var guid = 0;
//Storage
var storage = [];

//Object Constructor
function Employee(name, department, title, salary, id) {
    this.name = name
    this.department = department
    this.title = title
    this.salary = salary
    this.id = id
}

//Create Function
function create(form) {

    var id = storage.length
    //create employee as an object using E. O. C.
    var employee = new Employee(form.inputEmployeeName.value, form.inputEmployeeDepartment.value, form.inputEmployeeJobTitle.value, form.inputEmployeeSalary.value, id)

    //Add employee to the storage array
    storage.push(employee);

    //Display employee to html
    //target the tbody
    var tbody = document.getElementById("tbodyDisplayEmployees");

    tbody.innerHTML += '<tr id="tableRow' + employee.id + '"><td>' +
        employee.name + '</td><td>' + employee.department + '</td><td>' +
        employee.title + '</td><td>' + employee.salary +
        '</td><td><input type="button" value="Delete" onclick="removeTableRow(' +
        employee.id + ', this)"/><input type="button" value="Edit" onclick="showModal(' + employee.id + ')" /></td></tr>';
}

//Delete Function
function removeTableRow(key, row) {


    //storage.splice(key, 1);
    //var pos = row.parentNode.parentNode;
    //document.getElementById("tableDisplayEmployees").deleteRow(pos.rowIndex);
    storage[key] = null;
    var pos = row.parentNode.parentNode;
    document.getElementById("tableDisplayEmployees").deleteRow(pos.rowIndex);
}


//Show modal and populate (1 of 2 edit)

function showModal(key) {
    var employee = storage[key];

    document.getElementById("editEmployeeName").value = employee.name;
    document.getElementById("editEmployeeDepartment").value = employee.department;
    document.getElementById("editEmployeeJobTitle").value = employee.title;
    document.getElementById("editEmployeeSalary").value = employee.salary;

    guid = key;
    $("#modalEdit").modal("show");
}

//Update and hide modal (2 of 2 edit)
function update(form) {
    storage[guid].name = form.editEmployeeName.value;
    storage[guid].department = form.editEmployeeDepartment.value;
    storage[guid].title = form.editEmployeeJobTitle.value;
    storage[guid].salary = form.editEmployeeSalary.value;

    var row = document.getElementById("tableRow" + guid);

    var employee = storage[guid];

    row.innerHTML = '<td>' +
    employee.name + '</td><td>' + employee.department + '</td><td>' +
    employee.title + '</td><td>' + employee.salary +
    '</td><td><input type="button" value="Delete" onclick="removeTableRow(' +
    employee.id + ', this)"/><input type="button" value="Edit" onclick="showModal(' + employee.id + ')" /></td>'


    $("#modalEdit").modal("hide");
}