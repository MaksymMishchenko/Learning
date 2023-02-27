import { NgModule } from "@angular/core";
import { CommentsComponent } from './components/comments/comments.component';

@NgModule({
  declarations: [
    CommentsComponent
  ],
  exports: [CommentsComponent]
})

export class CommentsModule {

}