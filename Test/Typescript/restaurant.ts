import * as restaurant from "../Test/test"

var restaurants: restaurant.Restaurants[]=[];

function addRestaurant(id:number,name: string, address: string, country: string, status: string){

        restaurants.push(new restaurant.Restaurants(id,name,address,country,status))
    }

var tables: restaurant.tables[]=[];

function addtable(id: number, num: number, dianinghall: string, sittig: number){
    tables.push(new restaurant.tables(id,num,dianinghall,sittig))
}

var cust: restaurant.Customer[]=[];

function addCust(id: number,name: string, email: string){
    cust.push(new restaurant.Customer(id,name,email))
}

var bookings: restaurant.Booking[]=[];

function bookTable(id: number,Timing: Date, Hall: string, number: number, custid:number){
    var currentDate: Date= new Date();
    var difference= Math.abs(currentDate.getTime()-Timing.getTime());
    var DiffDays= Math.ceil(difference/(1000*3600*24));

    if(DiffDays>30){
        console.log("Sorry! You can't Book the table now");
    }
    else{
        if(currentDate.getDay()==Timing.getDay() && currentDate.getMonth()== Timing.getMonth() && currentDate.getFullYear()== Timing.getFullYear()){
            if(Timing.getHours()-currentDate.getHours()<6){
                console.log("Sorry! You can't book now")
            }
            else{
                bookings.push(new restaurant.Booking(id,Timing,Hall,number,custid))
            }    
        }
        else{
            bookings.push(new restaurant.Booking(id,Timing,Hall,number,custId))
        }
    }

}

var choice: number= 1


switch(choice){
    case 1:
        var id=1;
        var nameofRas="FoodZone";
        var address="Near Busstation, Dwarka-361335, Gujarat";
        var country="india";
        var Status="Open";

        addRestaurant(id,nameofRas,address,country,Status);
        
        restaurants.forEach(element => {
            element.display();
        });

    case 2:
        var id=1;
        var TableNum=1;
        var dianing="Gujarati";
        var sitting=5;
        var customerId=1;
        addtable(id,TableNum,dianing,sitting);

        tables.forEach(ele=>{
            ele.display();
        })

    case 3:
        var id=1;
        var Name="Dev";
        var email="asdas@gmail.com"

        addCust(id,Name,email);

        cust.forEach(element => {
            element.display();
        });
    case 4:
        var id=1;
        var Timing: Date= new Date("2022-01-01");
        Timing.setHours(16);
        var hall="Gujartai";
        var table=1;
        var custId=1;

        bookTable(id,Timing,hall,table,custId);

        bookings.forEach(element => {
            element.display();
        });
}
