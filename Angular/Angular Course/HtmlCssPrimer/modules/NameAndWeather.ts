export class Info {
    name: string
    surname: string

    constructor(name, surname) {
        this.name = name;
        this.surname = surname
    }

    printMsg() {
        console.log("My name is: " + this.name)
        console.log("The eather is: " + this.surname)
    }
}

export class Location {
    city: string

    constructor(city) {
        this.city = city;
    }

    getCity(){
        return "You are in " + this.city;
    }
}