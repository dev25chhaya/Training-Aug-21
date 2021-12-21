import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { HtmlFilesComponent } from './html-files/html-files.component';
import { Day1HtmlComponent } from './HtmlAssignment/day1-html/day1-html.component';
import { Day2HtmlComponent } from './HtmlAssignment/day2-html/day2-html.component';
import { Day1CSSComponent } from './CssAssignment/day1-css/day1-css.component';
import { CssFilesComponent } from './css-files/css-files.component';
import { Day2CSSComponent } from './CssAssignment/day2-css/day2-css.component';
import { AuthGuard } from './auth.guard';
import { LoginComponent } from './login/login.component';
import { AUTH_PROVIDERS } from './auth.service';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HtmlFilesComponent,
    Day1HtmlComponent,
    Day2HtmlComponent,
    Day1CSSComponent,
    CssFilesComponent,
    Day2CSSComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [AuthGuard,AUTH_PROVIDERS],
  bootstrap: [AppComponent]
})
export class AppModule { }
