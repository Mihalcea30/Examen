import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
//import {HttpClientModule} from "@angular/common/http";
import { AppComponent } from './app.component';
import { ClientDetailsComponent } from './client-details/client-details.component';
import { ClientDetailsFormComponent } from './client-details/client-details-form/client-details-form.component';
import {HttpClient, HttpClientModule} from "@angular/common/http";
import {FormsModule} from "@angular/forms";
import { StudentComponent } from './student/student.component';
import { EventsComponent } from './events/events.component';
import { EventsFormComponent } from './events/events-form/events-form.component';
import { ParticipantsComponent } from './participants/participants.component';

@NgModule({
  declarations: [
    AppComponent,
    ClientDetailsComponent,
    ClientDetailsFormComponent,
    StudentComponent,
    EventsComponent,
    EventsFormComponent,
    ParticipantsComponent,
    EventsComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
