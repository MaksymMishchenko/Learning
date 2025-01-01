import { FormBuilder } from "@angular/forms"
import { CounterComponent } from "./counter.component"

describe('CounterComponent', () => {

    let component: CounterComponent

    beforeEach(() => {
        component = new CounterComponent(new FormBuilder)
    }

    )
    it('should increment counter by 1', () => {
        component.increment()
        expect(component.counter).toBe(1)
    })

    it('should decrement counter by -1', () => {
        component.decrement()
        expect(component.counter).toBe(-1)
    })

    it('should increment value by event emitter', () => {
        let result: number
        component.counterEmitter.subscribe(value => result = value)
        component.increment()
        expect(result!).toBe(1)
    })

    it('should create form with two controls', () => {
        expect(component.form.contains('login')).toBeTruthy()
        expect(component.form.contains('email')).toBeTruthy()
    })

    it('should return false if form control login valid', () => {
        const control = component.form.get('login')
        control?.setValue('')
        expect(control?.valid).toBeFalsy()
    })
})