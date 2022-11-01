import { ComponentFixture, TestBed } from '@angular/core/testing';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { Subject } from 'rxjs';

import { RoutingComponent } from './routing.component';

class RouterStub {
  navigate(path: string[]) {
  }
}

class ActivatedRouteStub {
  // специальный класс в rxjs который работает как Observable, но при этом позволяет емитить и новые события
  private subject = new Subject<Params>()
  push(params: Params) {
    // тут мы емитим эти события
    this.subject.next(params)
  }

  // обращаемся к парамс и получаем Observable на который ссможем подписаться ниже.
  get params(){
    return this.subject.asObservable()
  }
}

describe('RoutingComponent', () => {
  let component: RoutingComponent;
  let fixture: ComponentFixture<RoutingComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [RoutingComponent],
      providers: [
        { provide: Router, useClass: RouterStub },
        { provide: ActivatedRoute, useClass: ActivatedRouteStub }
      ]
    })

    fixture = TestBed.createComponent(RoutingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges()
  });

  it('should be defined', () => {
    expect(component).toBeDefined();
  });

  it('should navigate to posts if go back', () => {
    let router = TestBed.inject(Router)
    let spy = spyOn(router, 'navigate')

    component.goBack()

    expect(spy).toHaveBeenCalledWith(['/posts'])
  })

  it('should navigate to 404 if id = 0', () => {
    let router = TestBed.inject(Router)
    let route: any = TestBed.inject(ActivatedRoute)
    let spy = spyOn(router, 'navigate')
    route.push({id: '0'})

    expect(spy).toHaveBeenCalledWith(['/404'])
  })
});
