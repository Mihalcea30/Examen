import { Injectable } from '@angular/core';
import {environment} from "../../environments/environment";
//import {}
import {HttpClient} from "@angular/common/http";
import {Eveniment} from "./events.model.ts";

@Injectable({
  providedIn: 'root'
})
export class EventsService {

  url:string = environment.apiBaseUrl + '/Events'
  list:Eveniment[] = [];

  formData : Eveniment = new Eveniment()
  constructor(private http : HttpClient) { }
  refreshList(){
    this.http.get(this.url)
      .subscribe({
        next :res =>{
          this.list = res as Eveniment[]
        },
        error: err => {console.log(err)}

      })
  }
  postServiceDetail(){
    return this.http.post(this.url,this.formData)
  }


}
