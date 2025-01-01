"use strict";
var Info = (function () {
    function Info(name, surname) {
        this.name = name;
        this.surname = surname;
    }
    Info.prototype.printMsg = function () {
        console.log("My name is: " + this.name);
        console.log("The eather is: " + this.surname);
    };
    return Info;
}());
exports.Info = Info;
var Location = (function () {
    function Location(city) {
        this.city = city;
    }
    Location.prototype.getCity = function () {
        return "You are in " + this.city;
    };
    return Location;
}());
exports.Location = Location;
