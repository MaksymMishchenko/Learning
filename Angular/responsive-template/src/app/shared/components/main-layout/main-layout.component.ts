import { Component } from '@angular/core';

@Component({
  selector: 'app-main-layout',
  templateUrl: './main-layout.component.html',
  styleUrls: ['./main-layout.component.scss']
})
export class MainLayoutComponent {

  toggleMenu(event: Event) {
    event.preventDefault();
    var menu = document.getElementById('main-menu');
    menu!.classList.toggle('is-open');

  }
}
