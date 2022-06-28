import { Directive, ElementRef, Renderer2 } from '@angular/core';

@Directive({
  selector: '[appStyleDirective]'
})
export class StyleDirectiveDirective {

  constructor(private el: ElementRef, private renderer: Renderer2)  {
    this.renderer.setStyle(el.nativeElement, 'color','blue')
   }
}
