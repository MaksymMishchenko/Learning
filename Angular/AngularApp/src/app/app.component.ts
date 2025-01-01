import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {

  objs = [
    { title: 'Post 1', author: 'Max 1', comments: [
        { name: 'Artur', text: 'lorem 1' },
        { name: 'Artur', text: 'lorem 2' },
        { name: 'Artur', text: 'lorem 3' },
      ]},
    { title: 'Post 2', author: 'Max 2', comments: [
        { name: 'Artur 1', text: 'lorem 1' },
        { name: 'Artur 1', text: 'lorem 2' },
        { name: 'Artur 1', text: 'lorem 3' },
      ]}
  ]
}
