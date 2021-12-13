import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-name-editor',
  templateUrl: './name-editor.component.html',
  styleUrls: ['./name-editor.component.css']
})
export class NameEditorComponent implements OnInit {

  // name= new FormControl('Dev');
  // update(){
  //   this.name.setValue("Chhaya")
  // }
  
  constructor(private fb: FormBuilder) { }

  profileForm = this.fb.group({
    firstName: ['',[Validators.required,Validators.maxLength(5)]],
    lastName: ['',Validators.required],
    email:['',Validators.required,Validators.email],
    address: this.fb.group({
      street: [''],
      city: [''],
      state: [''],
      zip: ['']
    }),
    aliases: this.fb.array([
      this.fb.control('')
    ])
  });

  get aliases(){
    return this.profileForm.get('aliases') as FormArray;
  }

  addAlias(){
    this.aliases.push(this.fb.control(''));
  }

  removeAlias(){
    this.aliases.removeAt;
  }

  onSubmit(){
    console.warn(this.profileForm);
  }

  updateProfile(){
    this.profileForm.patchValue({
      firstName: 'Devansu',
      address: {
        street:'Dwarka'
      }
    });
  }

  


  ngOnInit(): void {
  }


}
