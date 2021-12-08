import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { RectangleComponent } from './rectangle/rectangle.component';
import { LoginComponent } from './login/login.component';
import { CircleComponent } from './circle/circle.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { SignupComponent } from './signup/signup.component';

@NgModule({
  declarations: [
    AppComponent,
    RectangleComponent,
    LoginComponent,
    CircleComponent,
    SidebarComponent,
    SignupComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
