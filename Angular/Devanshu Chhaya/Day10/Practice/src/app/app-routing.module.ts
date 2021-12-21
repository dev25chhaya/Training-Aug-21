import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { ChildAComponent } from './child-a/child-a.component';
import { ChildBComponent } from './child-b/child-b.component';
import { FirstComponent } from './first/first.component';
import { HomeComponent } from './home/home.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { SecondComponent } from './second/second.component';
import { UserComponent } from './user/user.component';

const routes: Routes = [
  {
    path:'first-component',
    component: FirstComponent,
    children:[
      {
        path:'child-a',
        component: ChildAComponent
      },
      {
        path: 'child-b',
        component: ChildBComponent
      }
    ]
  },
  {
    path:'second-component',
    component: SecondComponent
  },
  {
    path:'user',
    component: UserComponent
  },
  {
    path:'user/:id/:name',
    component: UserComponent
  },
  {
    path:'home',
    component: HomeComponent,
  },
  {
    path:'',
    component: HomeComponent
  }
  // {
  //   path:'**',
  //   component: PageNotFoundComponent
  // }
]; 

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
