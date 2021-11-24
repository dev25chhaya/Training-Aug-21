class Point{
    x:number;
    y:number;
    
}
class Point2{
    x=0;
    y=0;

}

const pt= new Point2();
console.log(pt.x+" "+pt.y);

class Car { 
    engine:string; 
    
    constructor(engine:string) { 
       this.engine = engine 
    }  
    
    disp():void { 
       console.log("Function displays Engine is  :   "+this.engine) 
    } 
 } 
 
 //create an object 
 var car = new Car("XXSY1")
 
 //access the field 
 console.log("Reading attribute value Engine as :  "+car.engine)  
 
 //access the function
 car.disp()

class Name{
    name : string;

    constructor(){
        this.name="devanshu"
    }
}

const obj = new Name()
console.log(obj);


//========= inheritance ==========//

class Animal{
    name: string;
    constructor(animal: string){
        this.name=animal;
    }

    move(disInMeter: number=0){
        console.log(this.name+" moved"+disInMeter);
    }
}

class Snake extends Animal{
    constructor(name: string){
        super(name);
    }
    move(disInMeter=5){
        console.log("Slithering...");
        super.move(disInMeter);
    }
}

let sam= new Snake("Sammy the python");
sam.move();

class Octopus {
    readonly name: string;
    readonly numberOfLegs: number = 8;
   
    constructor(theName: string) {
      this.name = theName;
    }
  }
   
  let dad = new Octopus("Man with the 8 strong legs");

//========== Interface ===========//

interface LabeledValue{
    label: string;
}

function printLabel(labelobj: LabeledValue){
    console.log(labelobj.label);
}

let myobj= {label:"hello"};
printLabel(myobj);

interface IEmployee{
    empCode:number;
    name: string;
    getSalary:(empCode: number) => void;
}

class Employee implements IEmployee{
    empCode: number;
    name:string;

    constructor(code: number, name: string){
        this.empCode=code;
        this.name=name;
    }

    getSalary(empCode:number):void{
        var asl:number=20000;
        console.log(asl);
    }
}

let object= new Employee(1,"Dev");
object.getSalary(2);

interface IPerson { 
    firstName:string, 
    lastName:string, 
    sayHi: ()=>string 
 } 
 
 var customer:IPerson = { 
    firstName:"Tom",
    lastName:"Hanks", 
    sayHi: ():string =>{return "Hi there"} 
 } 
 
 console.log("Customer Object ") 
 console.log(customer.firstName) 
 console.log(customer.lastName) 
 console.log(customer.sayHi())  
 