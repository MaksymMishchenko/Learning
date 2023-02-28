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
    this.commentsService.createComment(text, parentId).subscribe((createdComment) => {
      this.comments = [...this.comments, createdComment];
    })
  }

  getReplies(commentId: string): CommentInterface[] {
    return this.comments.filter(comment => comment.parentId === commentId)
      .sort((a, b) =>
        new Date(a.createdAt).getTime() -
        new Date(b.createdAt).getTime());
  }

  ngOnDestroy(): void {
    if (this.commentsSubscription) {
      this.commentsSubscription.unsubscribe();
    };
  }
}
