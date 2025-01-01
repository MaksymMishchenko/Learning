import { Component, EventEmitter, Input, OnInit, Output } from "@angular/core";
import { ActiveCommentInterface } from "../../types/activeComment.interface";
import { ActiveCommentTypeEnum } from "../../types/activeCommentType.enum";
import { CommentInterface } from "../../types/comment.interface";

@Component({
    selector: 'comment',
    templateUrl: './comment.component.html'
})

export class CommentComponent implements OnInit {
    @Input() currentUserId!: string
    @Input() replies!: CommentInterface[];

   @Output() setActiveComment = new EventEmitter<ActiveCommentInterface | null>()

    canReply: boolean = false;
    canEdit: boolean = false;
    canDelete: boolean = false;
    activeCommentType = ActiveCommentTypeEnum;

    @Input() comment!: CommentInterface;

    ngOnInit(): void {
        const fiveMinutes = 300000;
        const timePassed = new Date().getTime() - new Date(this.comment.createdAt).getTime() > fiveMinutes;
        this.canReply = Boolean(this.currentUserId);
        this.canEdit = this.currentUserId === this.comment.userId && !timePassed;
        this.canDelete = this.currentUserId === this.comment.userId && !timePassed && this.replies.length === 0;
    }
}