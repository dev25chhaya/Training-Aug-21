import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-calc',
  templateUrl: './calc.component.html',
  styleUrls: ['./calc.component.css']
})
export class CalcComponent implements OnInit {
  
  firstVal: number=0;
  secondVal: number=0;
  // name: string="dev";
  res: number=0;
  title: string="this is my title";

  add(){
    this.res=this.firstVal+this.secondVal;
  }

  sub(){
    this.res= this.firstVal-this.secondVal;
  }

  mul(){
    this.res= this.firstVal* this.secondVal;
  }

  constructor() { }

  ngOnInit(): void {
  }

}
