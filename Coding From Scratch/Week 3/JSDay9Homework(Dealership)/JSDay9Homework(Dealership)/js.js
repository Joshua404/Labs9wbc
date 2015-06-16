"use strict";

var id = 0;
var storage = [];
var guid = 0;

function Vehicle(make, model, color, type, year, tranny, drive, condition, url, id) {
    this.make = make;
    this.model = model;
    this.color = color;
    this.type = type;
    this.year = year;
    this.tranny = tranny;
    this.drive = drive;
    this.condition = condition;
    this.url = url;
    this.id = id;
    this.isDeleted = false;

}


function create() {

    var vehicleMake = $("#inputVehicleMake").val();
    var vehicleModel = $("#inputVehicleModel").val();
    var vehicleColor = $("#inputVehicleColor").val();
    var vehicleType = $("#inputVehicleType").val();
    var vehicleYear = $("#inputVehicleYear").val();
    var vehicleTranny = $("#inputVehicleTranny").val();
    var vehicleDrive = $("#inputVehicleDrive").val();
    var vehicleCondition = $("#inputVehicleCondition").val();
    var pictureURL = $("#inputURL").val();

    var vehicle = new Vehicle(vehicleMake, vehicleModel, vehicleColor, vehicleType, vehicleYear, vehicleTranny, vehicleDrive, vehicleCondition, pictureURL, id);

    storage.push(vehicle);
    var vpic = vehicle.url;

    id++;

    $("#tableDisplayInventory tr:last").after('<tr id="tableRow' + vehicle.id + '">\
                                               <td>' + vehicle.make + '</td>\
                                               <td>' + vehicle.model + '</td>\
                                               <td>' + vehicle.color + '</td>\
                                               <td>' + vehicle.type + '</td>\
                                               <td>' + vehicle.year + '</td>\
                                               <td>' + vehicle.tranny + '</td>\
                                               <td>' + vehicle.drive + '</td>\
                                               <td>' + vehicle.condition + '</td>\
                                               <td> <img src="' + vpic + '"/> </td>\
                                               <td>\
                                                    <input type="button" value="Delete" onclick="removeTableRow(' + vehicle.id + ')" />\
                                                    <input type="button" value="Edit" onclick="showModal(' + vehicle.id + ')" />\
                                               </td></tr>');

}



function removeTableRow(key) {


    storage[key].isDeleted = true;
    $("#tableRow" + key).remove();
}


function showModal(key) {
    var vehicle = storage[key];

    $("#editVehicleMake").val(vehicle.make);
    $("#editVehicleModel").val(vehicle.model);
    $("#editVehicleColor").val(vehicle.color);
    $("#editVehicleType").val(vehicle.type);
    $("#editVehicleYear").val(vehicle.year);
    $("#editVehicleTranny").val(vehicle.tranny);
    $("#editVehicleDrive").val(vehicle.drive);
    $("#editVehicleCondition").val(vehicle.condition);
    $("#editURL").val(vehicle.url);


    guid = key;

    $("#modalEdit").modal("show");

}


function updateVehicle() {
    storage[guid].make = $("#editVehicleMake").val();
    storage[guid].model = $("#editVehicleModel").val();
    storage[guid].color = $("#editVehicleColor").val();
    storage[guid].type = $("#editVehicleType").val();
    storage[guid].year = $("#editVehicleYear").val();
    storage[guid].tranny = $("#editVehicleTranny").val();
    storage[guid].drive = $("#editVehicleDrive").val();
    storage[guid].condition = $("#editVehicleCondition").val();
    storage[guid].url = $("#editURL").val();

    var vehicle = storage[guid];
    var vpic = vehicle.url;

    $("#tableRow" + guid).html('<td>' + vehicle.make + '</td>\
                                               <td>' + vehicle.model + '</td>\
                                               <td>' + vehicle.color + '</td>\
                                               <td>' + vehicle.type + '</td>\
                                               <td>' + vehicle.year + '</td>\
                                               <td>' + vehicle.tranny + '</td>\
                                               <td>' + vehicle.drive + '</td>\
                                               <td>' + vehicle.condition + '</td>\
                                               <td> <img src="' + vpic + '"/> </td>\
                                               <td>\
                                                    <input type="button" value="Delete" onclick="removeTableRow(' + guid + ')" />\
                                                    <input type="button" value="Edit" onclick="showModal(' + guid + ')" />\
                                               </td>');



         $("#modalEdit").modal("hide");

}


$("#inputButton").click(create);
$("#editButton").click(updateVehicle);