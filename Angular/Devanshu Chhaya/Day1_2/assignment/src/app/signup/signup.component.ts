import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {

  name:string="";
  address: string="";
  pannumber: string="";

  onsignup(){
    if(this.name=="" || this.address=="" || this.pannumber==""){
      alert("Please fill all the fields")
    }
    else{
      alert("Successfully registered!!");
      this.address="";
      this.name="";
      this.pannumber=""
    }
  }

  constructor() { }

  ngOnInit(): void {
  }

}
