import { Component, OnInit,Output, EventEmitter, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { IStudent } from '../student';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {

  @Output() stuEvent= new EventEmitter<IStudent>();

  @ViewChild('f') studentForm?: NgForm;

  onSubmit(stuForm: IStudent){
    this.stuEvent.emit(stuForm);
  }
  constructor() { }

  ngOnInit(): void {
  }

}
