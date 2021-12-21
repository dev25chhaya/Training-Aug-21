import { Component, OnInit } from '@angular/core';
import { Student } from '../student';
import { StudentService } from '../student.service';

@Component({
  selector: 'app-students',
  templateUrl: './students.component.html',
  styleUrls: ['./students.component.css']
})
export class StudentsComponent implements OnInit {

  students: Student[]=[];
  isActive: boolean=false;
  isAdding: boolean=false;
  constructor(private studentService: StudentService) { }

  getStudents(): void{
    this.students=this.studentService.getStudents();
  }

  toggle(){
    if(this.isAdding==false){
      this.isAdding=true;
    }
    else{
      this.isAdding=false;
    }
  }

  addStudent(stu : Student): void{
    
    this.studentService.createStudent(stu);
  }

  stu:Student={"rollNumber":0,"name":"name","standard":0};

  updateStudent(id: number, name: string, standard: number): void{
    if(this.isActive==false){
      this.isActive=true;
    }
    else{
      this.isActive=false;
    }
    this.stu={"rollNumber":id,"name":name,"standard":standard};
    this.studentService.updateStudent({"rollNumber":id,"name":name,"standard":standard})  
  }

  deleteStudent(id: number):void{
    this.studentService.deleteStudent(id);
  }

  ngOnInit(): void {
    this.getStudents();
  }

}
