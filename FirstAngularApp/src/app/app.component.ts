import { Component, OnInit } from '@angular/core';

export interface Post {
  title: string
  text: string
  id?: number
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {

  posts: Post[] = [
    { title: 'lorem1', text: 'Lorem ipsum1', id: 1 },
    { title: 'lorem2', text: 'Lorem ipsum2', id: 2 }
  ]

  ngOnInit(){
setTimeout(() => {
  console.log('Timeout'),
  this.posts[0] = {
    title: 'Changed',
    text: 'changed2',
    id: 3
  }
}, 5000)
  }

  updatePosts(post: Post) {
    this.posts.unshift(post)
    console.log('Post', post)
  }
  removePost(id: number){
    this.posts = this.posts.filter(p=>p.id !==id)
  }
}
