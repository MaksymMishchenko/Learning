import { Component } from '@angular/core';
import { Model, ToDoItems } from './model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  model = new Model();

  getName() {
    return this.model.user;
  }

  getTodoItems() {
    return this.model.items.filter((item: { done: any; }) => !item.done);
  }

  addItem(value: string) {
    if (!value.trim()) {
      return
    }
    this.model.items.push(new ToDoItems(value, false))
  }
}
