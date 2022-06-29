import { Component } from '@angular/core';

export interface Post {
  title: string
  text: string
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  search = ''
  searchField = 'title'

  posts: Post[] = [
    { title: 'CSharp', text: 'As for me C# the best language in the world' },
    { title: 'Javascript', text: 'Javascript the best language in the world!!!' },
    { title: 'Sql', text: 'Sql the best language in the world. Do you agree with me?' }
  ]

  addPost() {
    this.posts.unshift(
      {
        title: 'Hello',
        text: 'World'
      })
  }
}
