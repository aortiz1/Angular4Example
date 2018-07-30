import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';

@Injectable({
  providedIn: 'root'
})
export class ExampleService {

  constructor(private http:Http) {  }

  getRepositories(userName:String){
    return this.http.get('')
  }
}
