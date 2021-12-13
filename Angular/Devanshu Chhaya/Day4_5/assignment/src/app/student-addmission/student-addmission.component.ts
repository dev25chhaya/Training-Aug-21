import { Component, OnInit, ViewChild } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { IStudent } from '../student';

@Component({
  selector: 'app-student-addmission',
  templateUrl: './student-addmission.component.html',
  styleUrls: ['./student-addmission.component.css']
})
export class StudentAddmissionComponent implements OnInit {



  constructor(private fb: FormBuilder) { }

  addmissionForm = this.fb.group({
    Name: this.fb.group({
      firstName: ['', Validators.required],
      middleName: ['', Validators.required],
      lastName: ['', Validators.required],
    }),
    birthInfo: this.fb.group({
      dob: ['',Validators.required],
      placeofbirth: ['',Validators.required],
      firstLanguage: ['',Validators.required]
    }),
    address: this.fb.group({
      city: ['',Validators.required],
      state: ['',Validators.required],
      country: ['',Validators.required],
      pin: ['',Validators.required]
    }),
    father: this.fb.group({
      firstName: ['',Validators.required],
      middleName: ['',Validators.required],
      lastName: ['',Validators.required],
      email: ['',Validators.required],
      educationalQualification: ['',Validators.required],
      profession: ['',Validators.required],
      designation: ['',Validators.required],
      phoneNumber: ['',Validators.required],
    }),
    mother: this.fb.group({
      firstName: ['',Validators.required],
      middleName: ['',Validators.required],
      lastName: ['',Validators.required],
      email: ['',Validators.required],
      educationalQualification: ['',Validators.required],
      profession: ['',Validators.required],
      designation: ['',Validators.required],
      phoneNumber: ['',Validators.required],
    }),
    emergencyContectList:this.fb.array([
      this.fb.group({
        relation:['',Validators.required],
        phoneNumber:['',Validators.required],
      })
    ]),
    referenceThrough:[''],
    add:[''],
    phoneNum:['']
  });

  get emergencyContectList(){
    return this.addmissionForm.get("emergencyContectList") as FormArray;
  }

  addrelative(){
    this.emergencyContectList.push(this.fb.group({
      relation:['',Validators.required],
      phoneNumber:['',Validators.required],
    }))
  }

  get stufName(){
    return this.addmissionForm.get("Name");
  }

  get birthInfo(){
    return this.addmissionForm.get("birthInfo");
  }

  get address(){
    return this.addmissionForm.get("address");
  }

  get fatherInfo(){
    return this.addmissionForm.get("father");
  }

  get motherInfo(){
    return this.addmissionForm.get("mother");
  }

  get Info(){
    return this.addmissionForm.get("father");
  }

  get emergencyCon(){
    return this.addmissionForm.get("emergencyContectList")
  }
  // get fromControls(){
  //   return this.addmissionForm.controls;
  // }

  
  students:IStudent[]=[]
  stringdata:IStudent|undefined;
  
  onSubmit()
  { 
    // this.stringdata=this.addmissionForm.value;
    // if(this.stringdata==undefined){
    //   alert("Sorry")
    // }
    // else{
    //   this.students.push(this.stringdata);
    // }
    this.students.push(this.addmissionForm.value);
  }

  
  ngOnInit(): void {
  }


}
