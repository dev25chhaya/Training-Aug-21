// export let age: number=20;

// export class Employee{
//     empCode: number;
//     empName: string;
//     constructor(name: string, code: number){
//         this.empCode=code;
//         this.empName=name;
//     }
//     displayEmployee(){
//         console.log(`${this.empCode} || ${this.empName}`);
//     }
// }

// let name:string="dev";

namespace StringUtility {

    export function ToCapital(str: string): string {
        return str.toUpperCase();
    }

    export function SubString(str: string, from: number, length: number = 0): string {
        return str.substr(from, length);
    }
}