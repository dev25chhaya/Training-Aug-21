// First try

// var Myname:string ="Devanshu"
// console.log(Myname);

//DataType

// let Isone:boolean=true
// console.log(Isone);

// let mark=true;
// console.log(mark);

//====== Numbers ==========//

// let decimal: number = 6;
// let hex: number = 0xf00d;
// let binary: number = 0b1010;
// let octal: number = 0o744;
// // let big: bigint = 100n;

// console.log(decimal+" "+hex+" "+binary+" "+octal+" ");

// let myNumber: number = 12345;  
// let myNumber_1: number = 12.8789;  
// let myNumber_2: number = 12667.976;  
// let myNumber_3: number = 12.5779;  
// let myNumber_4: number = 1234;  
// let myNumber_5 = new Number(123);  
  
// console.log("Number Method: toExponential()");  
// console.log(myNumber.toExponential());   
// console.log(myNumber.toExponential(2));  
  
// console.log("Number Method: toString()");  
// console.log(myNumber.toString());  
// console.log(myNumber.toString(4));  
  
// console.log("Number Method: toFixed()");  
// console.log(myNumber_1.toFixed());  
// console.log(myNumber_1.toFixed(3));  
  
// console.log("Number Method: toLocaleString()");  
// console.log(myNumber_2.toLocaleString()); 
  
// console.log("Number Method: toPrecision()");  
// console.log(myNumber_3.toPrecision(1));   
// console.log(myNumber_3.toPrecision(3));  
  
// console.log("Number Method: tovalueOf()");  
// console.log(myNumber_5)  
// console.log(myNumber_5.valueOf())  
// console.log(typeof myNumber)  


//========= String ==============//

// let color: string = "blue";
// color = 'red';

// console.log(color);

// let intro:any="My age is"
// intro=18;

// console.log(intro);

// let str1: string = 'Hello';  
// let str2: string = 'JavaTpoint';  
// //String Concatenation  
// console.log("Combined Result: " +str1.concat(str2));  
// //String charAt  
// console.log("Character At 4: " +str2.charAt(4));  
// //String indexOf  
// console.log("Index of T: " +str2.indexOf('T'));  
// //String replace  
// console.log("After Replacement: " +str1.replace('Hello', 'Welcome to'));  
// //String uppercase  
// console.log("UpperCase: " +str2.toUpperCase());  

//======== Array =============//

// let fruits: string[] = ['Apple', 'Orange', 'Banana']; 
// for(var index in fruits){
//     console.log(fruits[index]);
// }

// var alpha = ["a", "b", "c"]; 
// var num = [1, 2, 3];

// var alphaNum = alpha.concat(num); 
// console.log("alphaNumeric : " + alphaNum );

// function isBigEnough(element, index, array) { 
//     return (element >= 10); 
//  } 
           
//  var passed = [12, 130, 44].every(isBigEnough); 
//  console.log("Test Value : " + passed );

//  var passed2 = [12, 5, 8, 130, 44].filter(isBigEnough); 
// console.log("Test Value : " + passed2 );

// let num = [7, 8, 9];
// num.forEach(function (value) {
//   console.log(value);
// });

// var index = [12, 5, 8, 130, 44].indexOf(8); 
// console.log("index is : " + index );

// var arr = new Array("First","Second","Third"); 
          
// var str = arr.join(); 
// console.log("str : " + str );  
          
// var str = arr.join(", "); 
// console.log("str : " + str );  
          
// var str = arr.join(" + "); 
// console.log("str : " + str );

// var index = [12, 5, 8, 130, 8].lastIndexOf(8); 
// console.log("index is : " + index );

// var numbers = [1, 4, 9]; 
// var roots = numbers.map(Math.sqrt); 
// console.log("roots is : " + roots );

// var numbers = [1, 4, 9]; 
          
// var element = numbers.pop(); 
// console.log("element is : " + element );  
          
// var element = numbers.pop(); 
// console.log("element is : " + element );

// var numbers = new Array(1, 4, 9); 
// var length = numbers.push(10); 
// console.log("new numbers is : " + numbers );  
// length = numbers.push(20); 
// console.log("new numbers is : " + numbers );

// var total = [0, 1, 2, 3].reduce(function(a, b){ return a + b; }); 
// console.log("total is : " + total );

// var total = [0, 1, 2, 3].reduceRight(function(a, b){ return a + b; }); 
// console.log("total is : " + total );

// var arr = [0, 1, 2, 3].reverse(); 
// console.log("Reversed array is : " + arr );

// var arr = [10, 1, 2, 3].shift(); 
// console.log("Shifted value is : " + arr );

// var arr = ["orange", "mango", "banana", "sugar", "tea"]; 
// console.log("arr.slice( 1, 2) : " + arr.slice( 1, 2) );  
// console.log("arr.slice( 1, 3) : " + arr.slice( 1, 3) );

// function isBigEnough(element, index, array) { 
//     return (element >= 10); 
           
//  } 
           
//  var retval = [2, 5, 8, 1, 4].some(isBigEnough);
//  console.log("Returned value is : " + retval ); 
           
//  var retval = [12, 5, 8, 1, 4].some(isBigEnough); 
//  console.log("Returned value is : " + retval );

// var arr = new Array("orange", "mango", "banana", "sugar"); 
// var sorted = arr.sort(); 
// console.log("Returned string is : " + sorted );

// var arr = ["orange", "mango", "banana", "sugar", "tea"];  
// var removed = arr.splice(2, 0, "water");  
// console.log("After adding 1: " + arr );  
// console.log("removed is: " + removed); 
          
// removed = arr.splice(3, 1);  
// console.log("After removing 1: " + arr );  
// console.log("removed is: " + removed);

// var arr = new Array("orange", "mango", "banana", "sugar");         
// var str = arr.toString(); 
// console.log("Returned string is : " + str );

// var arr = new Array("orange", "mango", "banana", "sugar"); 
// var length = arr.unshift("water"); 
// console.log("Returned array is : " + arr );
// console.log("Length of the array is : " + length );

