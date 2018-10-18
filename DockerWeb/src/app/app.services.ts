import { Injectable, Component,OnInit } from '@angular/core';
import { Http, Headers, Response, RequestOptions, URLSearchParams  } from '@angular/http';
import { Observable, of } from 'rxjs';  

@Injectable()
export class AppServices {

    constructor(private http: Http) { }



public GetProducts():Observable<any>{
    return this.http.get("http://localhost:4300/api/product"); 
}

private extractData(res: Response) {
    let body = res.json();
    return body || {};
}


}