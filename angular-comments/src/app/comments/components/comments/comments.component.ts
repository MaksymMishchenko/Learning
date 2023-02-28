import { Component, Input, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { CommentsService } from '../../services/comments.services';
import { CommentInterface } from '../../types/comment.interface';

@Component({
  selector: 'comments',
  templateUrl: './comments.component.html'
})

export class CommentsComponent implements OnInit, OnDestroy {
  comments: CommentInterface[] = [];
  commentsSubscription!: Subscription;
  @Input() currentUserId!: string;

  constructor(private commentsService: CommentsService) { }

  ngOnInit(): void {
    this.commentsSubscription = this.commentsService.getComments()
      .subscribe((comments) => {
        this.comments = comments;
      });
  }

  addComment({ text, parentId }: { text: string, parentId: null | string }): void {
    console.log('AddComment', text, parentId);
  }

  ngOnDestroy(): void {
    if (this.commentsSubscription) {
      this.commentsSubscription.unsubscribe();
    };
  }
}
