import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { Day2CssComponent } from './CSS/day2Css/day2.component';
import { HomeComponent } from './home/home.component';
import { Day1Component } from './HTML/day1/day1.component';
import { Day2ComponentJS } from './JavaScriptAssignment/day2/day2.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    Day1Component,
    Day2CssComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
