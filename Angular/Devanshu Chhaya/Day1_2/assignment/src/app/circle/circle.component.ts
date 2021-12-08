import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-circle',
  templateUrl: './circle.component.html',
  styleUrls: ['./circle.component.css']
})
export class CircleComponent implements OnInit {

  redious: number | undefined;
  area: number | undefined;

  findArea() {
    if (this.redious == undefined) {
      alert("Please enter a redious")
    }
    else if (this.redious <= 0) {
      alert("Please enter positive value")
    }
    else {
      this.area = 3.14 * this.redious * this.redious;
    }
  }

  clear(){
    this.redious=undefined;
    this.area=undefined;
  }

  constructor() { }

  ngOnInit(): void {
  }

}
