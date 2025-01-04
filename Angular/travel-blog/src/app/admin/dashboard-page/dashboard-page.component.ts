import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { Post } from 'src/app/shared/components/interfaces';
import { PostsService } from 'src/app/shared/posts.service';

@Component({
  selector: 'app-dashboard-page',
  templateUrl: './dashboard-page.component.html',
  styleUrls: ['./dashboard-page.component.scss']
})
export class DashboardPageComponent implements OnInit, OnDestroy {

  posts: Post[] = []
  pSub!: Subscription
  dSub!: Subscription
  searchStr = ''

  constructor(public postsService: PostsService) { }

  ngOnInit(): void {
    this.pSub = this.postsService.getAllPosts().subscribe((post => {
      this.posts = post
    }))
  }

  remove(id: any) {
    this.dSub = this.postsService.removePost(id).subscribe(() => {
      this.posts = this.posts.filter(post => post.id !== id)
    })
  }

  ngOnDestroy() {
    if (this.pSub) {
      this.pSub.unsubscribe()
    }

    if (this.dSub) {
      this.dSub.unsubscribe()
    }
  }
}
