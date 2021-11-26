
// import { Employee } from "./module";

// let imported= new Employee("Dev",25);
// imported.displayEmployee();

// //==================

// import * as all from "./module";

// console.log(all.age);
// let practice=new all.Employee("Dev",6);

// //=================

// import { Employee as Associate } from "./module"
// let obj = new Associate("James Bond" , 3);

// //================

/// <reference  path="module.ts"/>

export class Employee {
    empCode: number;
    empName: string;
    constructor(name: string, code: number) {
        this.empName = StringUtility.ToCapital(name);
        this.empCode = code;
    }
    displayEmployee() {
        console.log ("Employee Code: " + this.empCode + ", Employee Name: " + this.empName );
    }
}
