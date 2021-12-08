import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-rectangle',
  templateUrl: './rectangle.component.html',
  styleUrls: ['./rectangle.component.css']
})
export class RectangleComponent implements OnInit {

  length: number|undefined=undefined;
  width: number|undefined=undefined;
  area: number|undefined=undefined;
  errorline: string=""

  findArea(){
    if(this.length==undefined || this.width==undefined){
      alert("Length or width should not be empty")    
    }
    else{
      this.area=this.length*this.width;
    }
  }

  clear(){
    this.length=undefined;
    this.width=undefined;
    this.area=undefined;
  }

  



  constructor() { }

  ngOnInit(): void {
  }

}
