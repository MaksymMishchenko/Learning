import { Component, OnInit } from '@angular/core';
import { Observable, Subscription } from 'rxjs';
import { interval } from 'rxjs';
import { map, filter } from 'rxjs/operators';
import { AppCounterService } from './services/app-counter.service';
import { LocalCounterService } from './services/local-counter.service';

export interface Post {

  title: string
  text: string
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  providers: [LocalCounterService]
})
export class AppComponent {
  search = ''
  searchField = 'title'
  sub: Subscription

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
  stop() {
    this.sub.unsubscribe()
  }
  //increase(){
  //this.appCounterService.increase();
  //}

  //decrease(){
  //this.appCounterService.decrease();
  //}

  constructor(public appCounterService: AppCounterService, public localCounterService: LocalCounterService) {
    const intervalStream$ = interval(1000)
    this.sub = intervalStream$
      .pipe(
        filter((value) => value % 2 === 0),
        map((value) => `Map value: ${value}`),
      )
      .subscribe((value) => console.log(value))
  }
}
