import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from './auth.guard';
import { CssFilesComponent } from './css-files/css-files.component';
import { Day1CSSComponent } from './CssAssignment/day1-css/day1-css.component';
import { Day2CSSComponent } from './CssAssignment/day2-css/day2-css.component';
import { HomeComponent } from './home/home.component';
import { HtmlFilesComponent } from './html-files/html-files.component';
import { Day1HtmlComponent } from './HtmlAssignment/day1-html/day1-html.component';
import { Day2HtmlComponent } from './HtmlAssignment/day2-html/day2-html.component';
import { LoginComponent } from './login/login.component';

const routes: Routes = [
  {
    path:'home',
    component:HomeComponent,
    canActivate:[AuthGuard]
    // children:[
    //   {
    //     path:'html',
    //     component:HtmlFilesComponent
    //   }

    // ]
  },
  {
    path:'html',
    component:HtmlFilesComponent,
    canActivate:[AuthGuard],
    children:[
      {
        path:'day1',
        component:Day1HtmlComponent,
        
      },
      {
        path:'day2',
        component:Day2HtmlComponent
      }
    ]
  },
  {
    path:'css',
    component:CssFilesComponent,
    children:[
      {
        path:'day1',
        component:Day1CSSComponent
      },
      {
        path:'day2',
        component:Day2CSSComponent
      }
    ]
  },
  {
    path:'login',
    component:LoginComponent
  },
  {
    path:'',
    component:HomeComponent
    // pathMatch:'full'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
