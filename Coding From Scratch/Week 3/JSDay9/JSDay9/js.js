"use strict";

var id = 0;
var storage = [];
var guid = 0;


function Product(name, units, type, id) {
    this.name = name;
    this.units = units;
    this.type = type;
    this.id = id;
    this.isDeleted = false;

}

function create() {


    var productName = $("#inputProductName").val();
    var productUnits = $("#inputUnityQuantity").val();
    var productType = $("#selectType").val();


    var product = new Product(productName, productUnits, productType, id);

    storage.push(product);

    id++;

    $("#tableDisplayInventory tr:last").after('<tr id="tableRow' + product.id + '">\
                                               <td>' + product.name + '</td>\
                                               <td>' + product.units + '</td>\
                                               <td>' + product.type + '</td>\
                                               <td>\
                                                    <input type="button" value="Delete" onclick="removeTableRow(' + product.id + ')" />\
                                                    <input type="button" value="Edit" onclick="showModal(' + product.id + ')" />\
                                               </td></tr>');


}



function removeTableRow(key) {


    storage[key].isDeleted = true;
    $("#tableRow" + key).remove();
}


function showModal(key) {
    var product = storage[key];

    $("#editProductName").val(product.name);
    $("#editUnityQuantity").val(product.units);
    $("#editType").val(product.type);


    guid = key;

    $("#modalEdit").modal("show");

}


function updateProduct() {
    storage[guid].name = $("#editProductName").val();
    storage[guid].units = $("#editUnityQuantity").val();
    storage[guid].type = $("#editType").val();
    
    var product = storage[guid];


    $("#tableRow" + guid).html('<td>' + product.name + '</td>\
                               <td>' + product.units + '</td>\
                               <td>' + product.type + '</td>\
                               <td>\
                                    <input type="button" value="Delete" onclick="removeTableRow(' + guid + ')" />\
                                    <input type="button" value="Edit" onclick="showModal(' + guid + ')" />\
                               </td>');

    $("#modalEdit").modal("hide");
}


$("#inputButton").click(create);
$("#editButton").click(updateProduct);