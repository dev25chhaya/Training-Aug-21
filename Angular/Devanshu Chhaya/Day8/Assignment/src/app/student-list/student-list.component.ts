import { Component, Input, OnInit } from '@angular/core';
import { IStudent } from '../student';


@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.css']
})
export class StudentListComponent implements OnInit {

  @Input() studentData: IStudent[]=[];


  constructor() { }

  ngOnInit(): void {
  }

}
