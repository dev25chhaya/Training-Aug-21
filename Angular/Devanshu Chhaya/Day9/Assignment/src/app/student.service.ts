import { Injectable } from '@angular/core';
import { combineLatestInit } from 'rxjs/internal/observable/combineLatest';
import { LogService } from './log.service';
import { Student } from './student';
import { STUDENTS } from './student-storage';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor(private logService: LogService) { }
  index: number = 0;

  getStudents(): Student[] {
    // STUDENTS.forEach(element => {
    //   console.log(element);
    // });
    this.logService.messages = 'Student: All students fetched';
    console.log(this.logService.messages);
    return STUDENTS;
  }

  createStudent(stu: Student) {
    // var newStu: Student = {
    //   rollNumber: id, name: name, standard: std
    // }
    STUDENTS.push(stu);
    this.logService.messages = 'Student: new student is entered';
    console.log(this.logService.messages);
  }

  updateStudent(stu: Student) {
    STUDENTS.forEach(element => {
      if (element.rollNumber == stu.rollNumber) {
        element.name = stu.name;
        element.standard = stu.standard;
        this.logService.messages = 'Student: Student is updated';
        console.log(this.logService.messages);
      }
    });
  }

  deleteStudent(rollNum: number) {

    // STUDENTS.forEach(element => {
    //   if(!(element.name==name)){
    //     // stu.rollNumber=element.rollNumber;
    //     // stu.name=element.name;
    //     // stu.standard=element.standard;
    //     console.log("Student Not found");

    //   }
    //   else{
    //     this.index=STUDENTS.indexOf(stu);
    //   STUDENTS.splice(this.index,1);
    //   }

    // });
    var stu: Student | null;
    for (var s of STUDENTS) {
      if (s.rollNumber == rollNum) {
        stu = s;
        this.index = STUDENTS.indexOf(stu);
        STUDENTS.splice(this.index, 1);
        this.logService.messages='Student: Studetn is deleted';
        console.log(this.logService.messages);
        break;
      }
    }


  }
}

