import { Injectable } from '@angular/core';
import { Student } from './student';

@Injectable({
  providedIn: 'root'
})
export class LogService {

  constructor() { }

  messages: string=""

  // add (message:string){
  //   this.messages.push(message);
  // }

  // clear(){
  //   this.messages=[];
  // }
}
