import { Injectable } from "@angular/core"
import { LogService } from "./log.service"

@Injectable({
    providedIn: 'root'
})
export class AppCounterService {

    constructor(public logServive: LogService) { }
    counter = 0
    increase() {
        this.logServive.log('Clicked increase button')
        this.counter++
    }
    decrease() {
        this.logServive.log('Clicked decrease button')
        this.counter--
    }
}