import { Directive, ElementRef, Input, OnChanges, SimpleChanges } from '@angular/core';

@Directive({
  selector: '[appColor]'
})
export class ColorDirective implements OnChanges {

  defaultColor = 'blue'
  @Input('appColor') color!: string

  constructor(private el: ElementRef) { }

  ngOnChanges(changes: SimpleChanges): void {
    this.el.nativeElement.style.backgroundColor = this.color || this.defaultColor
  }
}
