import { Component, Input, OnInit, Output,EventEmitter } from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent implements OnInit {

  @Input() item="";

  @Output() newEvent =new EventEmitter<string>();

  addNewItem(value: string){
    this.newEvent.emit(value);
  }

  
  constructor() { }

  ngOnInit(): void {
  }

}
