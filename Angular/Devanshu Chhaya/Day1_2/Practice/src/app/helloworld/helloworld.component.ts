import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-helloworld',
  templateUrl: './helloworld.component.html',
  styleUrls: ['./helloworld.component.css']
})
export class HelloworldComponent implements OnInit {
  Messege="Hello Everyone Good Evening Form the hello component"
  myname="Devanshu";
  surname="Chhaya";
  isDisabled=false;

  OnClick(){
    if(this.isDisabled==false){
      this.isDisabled=true;
    }
    else{
      this.isDisabled=false;
    }
  }

  ShowAlert(msg: string){
    alert("This is the simple example of the event binding"+ msg);
  }

  constructor() { }

  ngOnInit(): void {
  }

}
