import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  username: string = "";
  password: string = "";

  login() {
    if (this.username == "" || this.password == "") {
      alert("UserName or Password should not be empty")
    }

    else if(this.username == "admin" && this.password == "admin") {
        alert("You have successfully loggedin!!");
        this.username = "";
        this.password = ""
      }
    
    else{
      alert("Username or Password is Invalid")
    }
 
    }
  
  constructor() { }

  ngOnInit(): void {
  }

}
