import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-sign-up-form',
  templateUrl: './sign-up-form.component.html',
  styleUrls: ['./sign-up-form.component.css']
})
export class SignUpFormComponent implements OnInit {

  @ViewChild('f') signupForm?: NgForm;

  submitted=false

  info={
    firstname:"",
    lastname:"",
    email:"",
    dob:"",
    city:"",
    state:"",
  }
  
  onSubmit(){
    this.submitted=true;

    this.info
  }
  
  constructor() { }

  ngOnInit(): void {
  }

}
