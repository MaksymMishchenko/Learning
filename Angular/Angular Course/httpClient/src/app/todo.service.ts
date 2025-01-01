import { HttpClient, HttpEventType, HttpHeaders, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { catchError, delay, Observable, map, throwError, tap } from "rxjs";

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
            }),
        })
    }

    fetchTodos(): Observable<any> {

        let params = new HttpParams()
        params = params.append('_limit', '5')
        params = params.append('_limit', 'something')

        return this.httpClient.get<Todo[]>('https://jsonplaceholder.typicode.com/todos?', {
            params,
            observe: 'response'
        })
            .pipe(
                map(response => {
                    return response.body
                }),
                delay(500),
                catchError(error => {
                    console.log('Error:', error.message)
                    return throwError(error)
                }))
    }

    removeTodos(id: number): Observable<any> {
        return this.httpClient.delete<void>(`https://jsonplaceholder.typicode.com/todos/${id}`, {
            observe: 'events'
        }).pipe(
            tap(event=>{
                if(event.type === HttpEventType.Sent){
                    console.log('Sent', event)
                }

                if(event.type === HttpEventType.Response){
                    console.log('Response', event)
                }
            })
        )
    }
    todoComplete(id: number): Observable<any> {
        return this.httpClient.put<Todo>(`https://jsonplaceholder.typicode.com/todos/${id}`, {
            completed: true
        }, {
            responseType: 'json'
        })
    }
}