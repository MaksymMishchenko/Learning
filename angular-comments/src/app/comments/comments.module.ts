import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { CommentsComponent } from './components/comments/comments.component';
import { CommentsService } from "./services/comments.services";

@NgModule({
  declarations: [
    CommentsComponent
  ],
  imports:[CommonModule],
  exports: [CommentsComponent],
  providers: [CommentsService]
})

export class CommentsModule {
}