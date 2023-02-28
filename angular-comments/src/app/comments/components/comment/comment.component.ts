import { Component, Input, OnInit } from "@angular/core";
import { CommentInterface } from "../../types/comment.interface";

@Component({
    selector: 'comment',
    templateUrl: './comment.component.html'
})

export class CommentComponent implements OnInit {
    @Input() currentUserId!: string
    @Input() replies!: CommentInterface[];
    canReply: boolean = false;
    canEdit: boolean = false;
    canDelete: boolean = false;

    @Input() comment!: CommentInterface;

    ngOnInit(): void {
        const fiveMinutes = 300000;
        const timePassed = new Date().getTime() - new Date(this.comment.createdAt).getTime() > fiveMinutes;
        this.canReply = Boolean(this.currentUserId);
        this.canEdit = this.currentUserId === this.comment.userId && !timePassed;
        this.canDelete = this.currentUserId === this.comment.userId && !timePassed && this.replies.length === 0;
    }
}