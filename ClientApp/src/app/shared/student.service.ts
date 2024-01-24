import { Injectable } from '@angular/core';
import {environment} from "../../environments/environment";
import {Student} from "./student.model.ts";
import {HttpClient} from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  url:string = environment.apiBaseUrl + '/Students'
  list:Student[] = [];

  //formData : ClientDetail = new ClientDetail()
  constructor(private http : HttpClient) { }
  refreshList(){
    this.http.get(this.url)
      .subscribe({
        next :res =>{
          this.list = res as Student[]
        },
        error: err => {console.log(err)}

      })
  }
  /*postClientDetail(){
    return this.http.post(this.url,this.formData)
  }*/
}
