import { ComponentFixture, TestBed } from "@angular/core/testing"
import { By } from "@angular/platform-browser"
import { expand } from "rxjs"
import { CounterComponent } from "./counter.component"

describe('CounterComponent', () => {
  let component: CounterComponent
  let fixture: ComponentFixture<CounterComponent>

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CounterComponent]
    })

    fixture = TestBed.createComponent(CounterComponent)
    component = fixture.componentInstance
    // fixture.debugElement
    // fixture.nativeElement
  })

  it('should be created', () => {
    expect(component).toBeDefined()
  })

  it('should render counter property', () => {
    let num = 42
    //меняем значение counter  
    component.counter = num

    // говорим ангуляру что мы присваиваем counter значение и применяем его
    fixture.detectChanges()

    //делаем запрос по шаблону
    let de = fixture.debugElement.query(By.css('.counter'))

    // в свойстве находится обычная джаваскрипт нода, которую мы можем проверять.
    let el: HTMLElement = de.nativeElement

    // передаем значение в строковом формате, потому что textContent свойство которое содержит строку
    expect(el.textContent).toContain(num.toString())
  })
})