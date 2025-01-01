"use strict";
var Info = (function () {
    function Info(name, surname) {
        this.name = name;
        this.surname = surname;
    }
    Info.prototype.printDublicateMsg = function () {
        console.log("My name is: " + this.name);
        console.log("The eather is: " + this.surname);
    };
    return Info;
}());
exports.Info = Info;
