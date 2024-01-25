import { Component } from '@angular/core';
import {EventsService} from "../../shared/events.service";
import {NgForm} from "@angular/forms";
import {Eveniment} from "../../shared/events.model.ts";

@Component({
  selector: 'app-events-form',
  templateUrl: './events-form.component.html',
  styleUrls: ['./events-form.component.css']
})
export class EventsFormComponent {

  constructor(public service: EventsService) {
  }

  onSubmit(form: NgForm) {
    this.service.postServiceDetail()
      .subscribe({
        next: res  => {
          this.service.list = res as Eveniment[]
        },
        error: (err: any) => {
          console.log(err)
        }
      })

  }
}


