//========== Generic functions ============//

function identity<T>(arg: T){
    return arg;
}

let output= identity<string>("the string");
let outNum= identity<number>(25);
let outbool= identity<boolean>(true);
console.log(`${outNum} ${outbool} ${output}`);

function getArray<T>(items: T[]):T[]{
    return new Array().concat(items)
}

let num=getArray<number>([100,200,300]);
let str= getArray<string>(["hello","world"]);

num.push(400);
str.push("hi");


function display<T,U>(id:T , name:U): void{
    console.log(`${typeof(id)} ${typeof(name)}`)
}

display<number,string>(1,"Dev");

//============ Generic Class ===============//

class keyValuePair<T,U>
{
    private key: T;
    private value: U;

    setKeyValue(key: T, value: U): void{
        this.key=key;
        this.value=value;
    }

    display():void{
        console.log(`key= ${this.key} value= ${this.value}`)
    }

}

let obj1= new keyValuePair<number,string>();
obj1.setKeyValue(1,"dev");
obj1.display();
let obj2= new keyValuePair<string,number>();
obj2.setKeyValue("devanshu",2);
obj2.display();

//========== Generic Interface ===========//

interface IKeyValue<T,U>{
    process(key: T, value: U)
}

class kvproccess<T,U> implements IKeyValue<T,U>{
    process(key: T, val:U):void{
        console.log(`key= ${key} value= ${val}`);
    }
}

let proc: IKeyValue<number,string>=new kvproccess();
proc.process(25,"June");

var moduleprac : string="Hello";
