import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
//import {HttpClientModule} from "@angular/common/http";
import { AppComponent } from './app.component';
import { ClientDetailsComponent } from './client-details/client-details.component';
import { ClientDetailsFormComponent } from './client-details/client-details-form/client-details-form.component';
import {HttpClient, HttpClientModule} from "@angular/common/http";
import {FormsModule} from "@angular/forms";
import { StudentComponent } from './student/student.component';

@NgModule({
  declarations: [
    AppComponent,
    ClientDetailsComponent,
    ClientDetailsFormComponent,
    StudentComponent,
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
