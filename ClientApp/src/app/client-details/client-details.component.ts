import { Component, OnInit } from '@angular/core';
import {ClientDetailService} from "../shared/client-detail.service";

@Component({
  selector: 'app-client-details',
  templateUrl: './client-details.component.html',
  styleUrls: ['./client-details.component.css']
})
export class ClientDetailsComponent implements OnInit{
    constructor(public service : ClientDetailService) {
    }

  ngOnInit(): void {
    this.service.refreshList()
  }

}
