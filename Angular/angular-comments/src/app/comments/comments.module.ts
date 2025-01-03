import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { ReactiveFormsModule } from "@angular/forms";
import { CommentComponent } from "./components/comment/comment.component";
import { CommentFormComponent } from "./components/commentForm/commentForm.component";
import { CommentsComponent } from './components/comments/comments.component';
import { CommentsService } from "./services/comments.services";

@NgModule({
  declarations: [
    CommentsComponent,
    CommentComponent,
    CommentFormComponent
  ],
  imports:[CommonModule, ReactiveFormsModule],
  exports: [CommentsComponent],
  providers: [CommentsService]
})

export class CommentsModule {
}