import { Component, ContentChild, ElementRef, Input, OnInit } from '@angular/core';
import { Post } from '../app.component';

@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.scss']
})
export class PostComponent implements OnInit {
  @Input() post: Post
  @ContentChild('info') infoRef: ElementRef

  constructor() { }

  ngOnInit(): void {
  }
}
