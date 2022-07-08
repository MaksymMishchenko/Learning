import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { catchError, delay, Observable, throwError } from "rxjs";

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
        return this.httpClient.post<Todo>('https://jsonplaceholder.typicode.com/todos', newTodo, {
            headers: new HttpHeaders({
                'MyCustomHeader': Math.random().toString()
            })
        })
    }

    fetchTodos(): Observable<Todo[]> {
        return this.httpClient.get<Todo[]>('https://jsonplaceholder.typicode.com/todos?_limit=2')
            .pipe(
                delay(500),
                catchError(error => {
                    console.log('Error:', error.message)
                    return throwError(error)
                }))
    }

    removeTodos(id: number): Observable<void> {
        return this.httpClient.delete<void>(`https://jsonplaceholder.typicode.com/todos/${id}`);
    }
    todoComplete(id: number): Observable<Todo> {
        return this.httpClient.put<Todo>(`https://jsonplaceholder.typicode.com/todos/${id}`, {
            completed: true
        })
    }
}