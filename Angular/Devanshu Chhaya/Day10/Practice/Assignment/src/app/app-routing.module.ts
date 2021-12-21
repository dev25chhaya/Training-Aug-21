import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { Day1Component } from './HTML/day1/day1.component';
// import { Day1ComponentCss } from './CSS/day1/day1.component';
import { Day2CssComponent } from './CSS/day2Css/day2.component';
import { Day1ComponentJS } from './JavaScriptAssignment/day1/day1.component';
import { Day2ComponentJS } from './JavaScriptAssignment/day2/day2.component';

const routes: Routes = [
  {
    path:'home',
    component:HomeComponent
  },
  {
    path:'html/day1',
    component:Day1Component
  },
  // {
  //   path:'css/day1',
  //   component: Day1ComponentCss
  // },
  {
    path:'css/day2',
    component: Day2CssComponent 
  },
  {
    path:'js/day1',
    component: Day1ComponentJS
  },
  {
    path:'js/day2',
    component: Day2ComponentJS
  },
  {
    path:'',
    component:HomeComponent
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
