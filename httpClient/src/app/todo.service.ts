import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { delay, Observable } from "rxjs";

export interface Todo {
    completed: boolean,
    title: string,
    id?: number
}

@Injectable({
    providedIn: "root"
})

export class TodoService {
    constructor(private httpClient: HttpClient) { }

    addTodo(newTodo: Todo): Observable<Todo> {
        return this.httpClient.post<Todo>('https://jsonplaceholder.typicode.com/todos', newTodo)
    }

    fetchTodos(): Observable<Todo[]> {
        return this.httpClient.get<Todo[]>('https://jsonplaceholder.typicode.com/todos?_limit=2')
        .pipe(delay(500))
    }

    removeTodos(id: number): Observable<void>{
        return this.httpClient.delete<void>(`https://jsonplaceholder.typicode.com/todos/${id}`);
    }
}