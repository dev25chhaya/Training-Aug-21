// Online table reservation in the restaurant for specific date and time. This will
    // Provide the list of restaurants in the country so that the user can choose accordingly.
    // Provide the list of tables available for online reservation at different dining rooms in the restaurant.
    // Mention the number of guests that can be accommodated on the particular table.
    // Accept the booking for tables.
    // Online table reservations are done 6hrs in advance for the current date.
    // Table reservation can be done up to one month in advance.
    // Give a token number to the customer as an acknowledgement of booking.
export enum Countries{
    "india",
    "Australia",
    "USA",
}

export class Restaurants {
    RestaurantId: number;
    RestaurantName: string;
    Address: string;
    Contry: string;
    Status: string;
    
    constructor(id:number, name: string, address: string, country: string, status: string){
        this.RestaurantId=id;
        this.Status=status;
        this.RestaurantName=name;
        this.Address=address;
        this.Contry=country;
    }

    display(){
        console.log(`RestaurantName: ${this.RestaurantName} || Address: ${this.Address} || Country: ${this.Contry} || Status:${this.Status}`)
    }
}

export class tables{
    RestaurantId: number;
    TableNumber: number;
    DianingHall:string;
    Capacity: number;

    constructor(id: number,tableno: number, DianingHall: string, sittig: number){
        this.RestaurantId=id;
        this.TableNumber=tableno;
        this.DianingHall=DianingHall;
        this.Capacity=sittig;
    }

    display(){
        console.log(`TableNo: ${this.TableNumber} || DianingHall: ${this.DianingHall} || Capacity: ${this.Capacity}`)
    }

}

export class Customer {
    id: number;
    Name: string;
    email: string;

    constructor(id: number, Name: string, email: string) {
        this.id=id;
        this.Name=Name;
        this.email=email;
    }

    display(){
        console.log(`Id: ${this.id} || Name: ${this.Name} || Email: ${this.email}`)
    }
}

export class Booking{
    bookingId: number;
    customerId: number;
    bookingTiming: Date;
    DianingHall: string;
    TableNumber: number;

    constructor (id: number, timing: Date, Hall: string, tnumber: number, custid: number){
        this.bookingId=id;
        this.bookingTiming=timing;
        this.DianingHall=Hall;
        this.TableNumber=tnumber;
        this.customerId=custid;
    }

    display(){
        console.log(`BookingId: ${this.bookingId} || CustomerId: ${this.customerId} || Timing: ${this.bookingTiming} || DianingHall: ${this.DianingHall} || TableNumber: ${this.TableNumber}`)
    }

}


