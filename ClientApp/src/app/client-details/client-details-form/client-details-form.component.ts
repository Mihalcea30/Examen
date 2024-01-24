import { Component } from '@angular/core';
import {ClientDetailService} from "../../shared/client-detail.service";
import {NgForm} from "@angular/forms";
import {ClientDetail} from "../../shared/client-detail.model.ts";

@Component({
  selector: 'app-client-details-form',
  templateUrl: './client-details-form.component.html',
  styleUrls: ['./client-details-form.component.css']
})
export class ClientDetailsFormComponent {
  constructor(public service : ClientDetailService) {
  }
  onSubmit(form:NgForm){
    this.service.postClientDetail()
      .subscribe({
        next: res => {
          this.service.list = res as ClientDetail[]
        },
        error: err => {
          console.log(err)
        }
      })
  }

}

