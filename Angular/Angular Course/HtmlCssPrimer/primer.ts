import * as NameAndLocation from "./modules/NameAndWeather";
import { Info as Duplicate } from "./modules/DuplicateClass";
import { TempConverter } from "./modules/TempConverte"

let name = new NameAndLocation.Info("Maks", "Mischenko");
let location = new NameAndLocation.Location("London");
let tConverter = TempConverter.converterFtoC("170");

name.printMsg();
location.getCity();

let info1 = new Duplicate("Maks", "Mischenko")
info1.printDublicateMsg();
console.log(tConverter)

let tuple: [string, string, string];
tuple = ["London", "raining", TempConverter.converterFtoC("38")];
console.log(`It is ${tuple[2]} degrees C and ${tuple[1]} in ${tuple[0]}`);

let cities: { [index: string]: [string, string] } = {};
cities["London"] = ["sunny", TempConverter.converterFtoC("75")];
cities["Berlin"] = ["snowing", TempConverter.converterFtoC("85")];
cities["Kyiv"] = ["rainy", TempConverter.converterFtoC("85")];

for (let key in cities) {
console.log(`${key}: ${[key][0]}, ${[key][1]}`)
}