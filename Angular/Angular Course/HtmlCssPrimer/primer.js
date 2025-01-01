"use strict";
var NameAndLocation = require("./modules/NameAndWeather");
var DuplicateClass_1 = require("./modules/DuplicateClass");
var TempConverte_1 = require("./modules/TempConverte");
var name = new NameAndLocation.Info("Maks", "Mischenko");
var location = new NameAndLocation.Location("London");
var tConverter = TempConverte_1.TempConverter.converterFtoC("170");
name.printMsg();
location.getCity();
var info1 = new DuplicateClass_1.Info("Maks", "Mischenko");
info1.printDublicateMsg();
console.log(tConverter);
var tuple;
tuple = ["London", "raining", TempConverte_1.TempConverter.converterFtoC("38")];
console.log("It is " + tuple[2] + " degrees C and " + tuple[1] + " in " + tuple[0]);
var cities = {};
cities["London"] = ["sunny", TempConverte_1.TempConverter.converterFtoC("75")];
cities["Berlin"] = ["snowing", TempConverte_1.TempConverter.converterFtoC("85")];
cities["Kyiv"] = ["rainy", TempConverte_1.TempConverter.converterFtoC("85")];
for (var key in cities) {
    console.log(key + ": " + [key][0] + ", " + [key][1]);
}
