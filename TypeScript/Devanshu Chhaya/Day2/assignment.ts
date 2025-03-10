// There is a retail shop which need to manage the inventory, whenever some purchase is being made product quantity should be reduced, 
// if quanity is less than 5 reorder request should be raised.

interface Iproducts {
    ProductId: number;
    ProductName: string;
    ProductQuantity: number;
    getProd: () => void;
    purchase: (purchaseQuantity: number) => void;
}

class product implements Iproducts {
    ProductId: number;
    ProductName: string;
    ProductQuantity: number;

    constructor(id: number, name: string, qua: number) {
        this.ProductId = id;
        this.ProductName = name;
        this.ProductQuantity = qua;
    }

    getProd() {
        console.log("ProductId: " + this.ProductId + " Name: " + this.ProductName + " Quantity " + this.ProductQuantity);
    }

    purchase(purchaseQuantity: number) {
        if (this.ProductQuantity == 0) {
            console.log("Sorry! the is not avilable");
        }
        else if (this.ProductQuantity < purchaseQuantity) {
            console.log("Only " + this.ProductQuantity + " " + this.ProductName + " are avilable")
        }
        else {
            this.ProductQuantity -= purchaseQuantity;
        }

    }

    toOrder = () => {
        if (this.ProductQuantity == 0) {
            console.log("Order some " + this.ProductName);
        }
    }
}


let prods: product[] = [
    new product(1, "Book", 25),
    new product(2, "Pencile", 10),
    new product(3, "Sharpnar", 20),
    new product(4, "Eraser", 5),
    new product(5, "TextBook", 50)
]

// store the product
function addpro(id: number, name: string, quantity: number) {
    if (quantity <= 0) {
        console.log("Please enter some quantity");
    }
    else {
        prods.push(new product(id, name, quantity))
    }
}



var choice: number = 1

switch (choice) {
    case 1:
        addpro(6, "Chart", 50);

        prods.forEach(element => {
            element.getProd();
        });
    
    case 2:

    // Purchase perticular product

     var prod= prods.filter((element,index,array)=>
         {return element.ProductId==1 })

     for(var i in prod){
         prod[i].purchase(25);
     }

     prods.forEach(element => {
         element.getProd();
     });

     case 3:

        prods.forEach(element => {
            element.toOrder();
        });
}

