import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

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

  author: Promise<string> = new Promise<string>(author => {
    setTimeout(() => {
      author('Max')
    }, 2000)
  })

  date: Observable<Date> = new Observable<Date>(obs => {
    setInterval(() => {
      obs.next(new Date())
    }, 1000)
  })

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
