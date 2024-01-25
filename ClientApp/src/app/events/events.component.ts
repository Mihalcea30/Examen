import {Component, OnInit} from '@angular/core';
import {ClientDetailService} from "../shared/client-detail.service";
import {EventsService} from "../shared/events.service";

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.css']
})


export class EventsComponent implements OnInit{
  constructor(public service : EventsService) {
  }

  ngOnInit(): void {
    this.service.refreshList()
  }

}
