import { Component, OnInit } from '@angular/core';
import { Todo, TodoService } from './todo.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})

export class AppComponent implements OnInit {

  todos: Todo[] = []
  todoTitle = ""
  loading = false

  constructor(private todosService: TodoService) { }

  ngOnInit() {
    this.fetchTodos()
  }

  addTodo() {
    if (!this.todoTitle.trim()) {
      return
    }

    this.todosService.addTodo({
      completed: false,
      title: this.todoTitle
    })
      .subscribe(todo => {
        this.todos.push(todo)
        this.todoTitle = ''
      })
  }

  fetchTodos() {
    this.loading = true
    
      this.todosService.fetchTodos()
      .subscribe(todos => {
        this.todos = todos
        this.loading = false
      })
  }

  removeTodo(id: any): void {
    this.todosService.removeTodos(id)
      .subscribe(() => { })
    this.todos = this.todos.filter(t => t.id !== id)
  }

}
