import { Pipe, PipeTransform } from "@angular/core";

@Pipe({
    name: 'mult'
})
export class MultByPipe implements PipeTransform {
    transform(number: number, pow: number = 2): number {
        return number * pow
    }
}