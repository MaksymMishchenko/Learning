import { transition, trigger, useAnimation } from '@angular/animations';
import { Component, OnInit } from '@angular/core';
import { bounce, bounceOutUp } from 'ng-animate';

@Component({
  selector: 'app-animate',
  template: `
  <button (click)="visible = !visible">Toogle</button>
  <hr>
  <div [@bounce] *ngIf="visible" class="box"></div>`,
  styleUrls: ['./animate.component.scss'],
  animations: [
    trigger('bounce', [
      transition('void => *', useAnimation(bounce, {
        params: {
          timing: 3,
          delay: 0.3
        }
      })),
      transition('* => void', useAnimation(bounceOutUp, {
        params: {
          timing: 3,
          delay: 0.3
        }
      }))
    ])
  ]
})
export class AnimateComponent implements OnInit {

  visible = true

  constructor() { }

  ngOnInit(): void {
  }

}
