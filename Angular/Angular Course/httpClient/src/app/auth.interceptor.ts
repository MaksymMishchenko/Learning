import { HttpEvent, HttpEventType, HttpHandler, HttpInterceptor, HttpRequest } from "@angular/common/http";
import { Observable, tap } from "rxjs";

export class AuthInterceptor implements HttpInterceptor{
    
    intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        console.log('Intercept', req)
        const cloned = req.clone() 
        return next.handle(cloned).pipe(
            tap(event=>{
                if(event.type === HttpEventType.Response)
                {
                    console.log('Intercept Response', event)
                }
            })
        )
    }
}