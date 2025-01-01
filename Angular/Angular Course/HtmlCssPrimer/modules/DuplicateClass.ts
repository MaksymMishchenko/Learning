export class Info {
    name: string;
    surname: string

    constructor(name, surname){
        this.name = name;
        this.surname = surname;
    }

    printDublicateMsg() {
        console.log("My name is: " + this.name)
        console.log("The eather is: " + this.surname)
    }
}