import { Component } from '@angular/core';

export interface Post{
  title: string
  text: string
  id?: number
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  posts: Post[] = [
    { title:'lorem1', text:'Lorem ipsum1', id: 1},
    { title:'lorem2', text:'Lorem ipsum2', id: 2}
  ]
}
