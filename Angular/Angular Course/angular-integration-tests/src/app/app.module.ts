import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { CounterComponent } from './counter/counter.component';
import { PostsComponent } from './posts/posts.component';
import { RoutingComponent } from './routing/routing.component';
import { NavbarComponent } from './navbar/navbar.component';
import { ColorDirective } from './directives/color.directive';

@NgModule({
  declarations: [
    AppComponent,
    CounterComponent,
    PostsComponent,
    RoutingComponent,
    NavbarComponent,
    ColorDirective
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot([])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
