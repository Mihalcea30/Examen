import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {environment} from "../../environments/environment";
import {ClientDetail} from "./client-detail.model.ts";

@Injectable({
  providedIn: 'root'
})
export class ClientDetailService {
  url:string = environment.apiBaseUrl + '/Clients'
  list:ClientDetail[] = [];
  formData : ClientDetail = new ClientDetail()
  constructor(private http : HttpClient) { }
  refreshList(){
    this.http.get(this.url)
      .subscribe({
        next :res =>{
          this.list = res as ClientDetail[]
        },
        error: err => {console.log(err)}

      })
  }
  postClientDetail(){
    return this.http.post(this.url,this.formData)
  }
}

