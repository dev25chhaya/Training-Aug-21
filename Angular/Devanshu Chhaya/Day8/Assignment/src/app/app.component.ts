import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { IStudent } from './student';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})  
export class AppComponent {

  // student={
  //   firstName:'',
  //   lastName:'',
  //   standard:'',
  //   dob:'',
  // }

  students: IStudent[]=[];
  datastring: string='';


  addStudent(studentData: IStudent){
    // this.student.firstName=studentData.value.firstName;
    // this.student.lastName=studentData.value.lastName;
    // this.student.standard=studentData.value.standard;
    // this.student.dob=studentData.value.dob;
    
    this.students.push(studentData);
    // // this.datastring=stuFormData;
    // this.students.push(studentData);
    console.log(this.students)
  }
}
