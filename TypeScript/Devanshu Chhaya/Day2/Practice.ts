// //========= Functrions ============//

// function add(x: number, y: number): number{
//     return x+y;
// }

// let myAdd= function (x: number,y: number): number{
//     return x+y;
// }

// let myAdd2: (x: number,y: number)=> number= function(x:number, y:number): number{
//     return x+y;
// };

// function buildName(firstNeme: string , lastname?: string){
//     if(lastname)
//         return firstNeme+" "+lastname;
//     else return firstNeme;      
// }

// console.log(buildName("Dev"))

// function names(firstname: string, ...restoftheName: string[]){
//     return firstname+" "+restoftheName.join(",");
// }

// console.log(names("Dev","Ajay","Milan","Nilay","Dinesh"));


// //============= Function Type Expression ==================//

// function First(fn: (a: string)=> number){
//     fn("Hello world");
//     return 0;
// }

// function printtocon(s: string): number {
//     console.log(s);
//     return 0;
// }

// First(printtocon);

// //type alias

// type funcionforPrint = (a: string)=> void;
// function functionType(fn: funcionforPrint){
//     fn("Hello world");
//     return 0;
// }

// function printtoconsole(s: string): number {
//     console.log(s);
//     return 0;
// }

// First(printtoconsole);


// //======= generic function ===========//

// function FirstEle<Type>(arr: Type[]): Type | undefined{
//     return arr[0]
// }

// console.log(typeof(FirstEle(["a","b"])));


// //========== Tuples ==============//

// var myTuple= [10,"Hello"];
// console.log(myTuple[1])

// console.log(myTuple.length);

// let x: [string, number];

// x = ["hello", 10];

// console.log(x[0].substring(1));
// //=========== Union ============//

// var val: string | number
// val=12;

// console.log(val);

// val="Hello";

// console.log(val);

// function disp(names:string| string[]){
//     if(typeof names=="string"){
//         console.log(names);
//     }
//     else{
//         for(var i in names){
//             console.log(names[i])
//         }
//     }
// }

// disp(["hello","world"]);

//========= enum ===========//

// enum UserResponse{
//     No=1,
//     Yes
// }

// function useEnum (message: string, enumMem: UserResponse){
//     console.log(`${message} ${enumMem}`);
// }

// useEnum("The value of the No is",UserResponse.No);
// useEnum("The value of the Yes is",UserResponse.Yes);



