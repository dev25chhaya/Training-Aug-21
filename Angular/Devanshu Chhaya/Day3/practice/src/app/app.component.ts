import { Component } from '@angular/core';
import { Item } from './item';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  statuscode: string="offline";

  constructor(){
    this.statuscode= Math.random()>.5?"online": "offline";
  } 

  getColor(){
    return this.statuscode==="offline"? "red":"blue";
  }
  
   canSave =  false;
   isSpecial = false;
   ischanged = false;

   currentClasses={};

   currentStyles: Record<string,string>={};

   setCurrentClasses(){
     this.currentClasses={
       savable: this.canSave,
       modified: this.ischanged,
       special: this.isSpecial
     };
   }

   ngOnInit(){
     this.setCurrentClasses();
     this.setCurrentStyle(); 
   }
  
   // style directive

   currentStyle={};

   fontSize= false;
   fontWeight= false;
   fontColor= false;

   setCurrentStyle(){
     this.currentStyle={
       'font-size': this.fontSize? '36px':'24px',
       'font-weight': this.fontWeight? 'bold':'Normal',
       'color': this.fontColor? 'blue':'red'
     };
   }

   //ngif

  istrue= false;

  ifprac(){
    if(this.istrue==false)
      this.istrue=true;
    else
      this.istrue=false;
  }

  //ngfor

  names: string[]=["Ajay","Milan","Dinesh"];

  addname(){
    this.names.push("Pavan")
  }

  //ng switch

  myvalue=2;

  darkmodeClasses={};

  setDarkModeClasses(){
    this.darkmodeClasses={
      darkmode : true,
    }
  }

}
