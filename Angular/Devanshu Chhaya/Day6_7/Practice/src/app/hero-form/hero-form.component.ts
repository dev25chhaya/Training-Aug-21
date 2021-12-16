  import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-hero-form',
  templateUrl: './hero-form.component.html',
  styleUrls: ['./hero-form.component.css']
})
export class HeroFormComponent implements OnInit {

  @ViewChild('f') signupForm?: NgForm  ;

  defaultQuestion='pet'
  answer='';
  genders=["Male","Female"];

  submitted=false;

  user={
    username:'',
    email:'',
    secrateQuestion:'',
    answer:'',
    gender:''
  };

  // onSubmit(form: NgForm){
  //   console.log(form);
  // }

  onSubmit(){
    this.submitted=true;
    this.user.username=this.signupForm?.value.userdata.username;
    this.user.email=this.signupForm?.value.userdata.email;
    this.user.secrateQuestion=this.signupForm?.value.secret;
    this.user.answer=this.signupForm?.value.queAns;
    this.user.gender=this.signupForm?.value.gender;
  
    this.signupForm?.reset();
  }

  suggestUsername(){
    const name="TheUser";
    this.signupForm?.form.patchValue({
      userdata:{
        username: name
      }
    });
  }
  constructor() { }

  ngOnInit(): void {
  }

}
