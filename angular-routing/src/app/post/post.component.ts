import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { PostsService } from '../posts.service';

@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.scss']
})
export class PostComponent implements OnInit {
  post: any

  constructor(private route: ActivatedRoute,
    private postsSevice: PostsService) { }

  ngOnInit(): void {
    this.route.params.subscribe((params: Params) => {
      console.log('params', params)
     this.post = this.postsSevice.getById(+params.id)
    })
  }
}
