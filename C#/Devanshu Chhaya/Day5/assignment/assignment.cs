//Rambo Rental Bikes is looking for developing a system to calculate the rentals of the bikes. 
//System should accept the customer details, bike details and calculate the rental charges.

// DESCRIPTION OF PROJECTS

//System allows users to add customer details with bike rented. It computes rent for each customer. 
//Systems displays the Bike details with summation of days of hire and rental payment.   
    //FUNCTIONALITY AND TASK
    
//Define a class called Mobike with the following description: 

//Instance variables/data members: 

//BikeNumber – to store the bike’s number

//PhoneNumber – to store the phone number of the customer

//Name – to store the name of the customer
//Days – to store the number of days the bike is taken on rent o charge – to calculate and store the rental charge

//Member methods:

//void Input() – to input and store the detail of the customer.

//void Compute( ) – to compute the rental charge

//void display( ) – to display the details in the following format:

// Bike No.PhoneNo             No.of days         Charge

// The rent for a mobike is charged on the following basis:

//First five days Rs 500 per day

//Next five days Rs 400 per day

//Rest of the days Rs 200 per day

//Use collection Framework to store 10 Customer Details. Implement List operation add, delete, edit and search functionality


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    public class Mobike
    {
        
       public string Name, BikeNumber, PhoneNumber;
        int Days, charges;

        public void input()
        {
            Console.WriteLine("Name");
            Name = Console.ReadLine();
            Console.WriteLine("Bike Number");
            BikeNumber = Console.ReadLine();
            Console.WriteLine("phoneNumber");
            PhoneNumber =Console.ReadLine();
            Console.WriteLine("No of Days");
            Days = Convert.ToInt32(Console.ReadLine());

        }

        public void compute()
        {
            
            if (Days <= 5)
            {
                charges = Days * 500;               
            }
            if(Days>5 && Days <= 10)
            {
                charges = (5 * 500) + ((Days - 5) * 400);
            }
            if (Days > 10)
            {
                charges = (5 * 500) + (5 * 400) + ((Days - 10) * 200);
            }
        }

        public void display()
        {
            Console.WriteLine("BikeNumber: " + BikeNumber);
            Console.WriteLine("PhoneNumber: " + PhoneNumber);
            Console.WriteLine("No. Of Days: "+ Days);
            Console.WriteLine("Charges: "+charges);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Mobike> data = new List<Mobike>(10);

            Mobike[] arr = new Mobike[] { new Mobike(), new Mobike()};
            data.AddRange(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                data[i].input();
                data[i].compute();
            }
            for (int i = 0; i < arr.Length; i++)
            {
                data[i].display();
            }

            Console.WriteLine("Choose the option");


            Console.WriteLine("1: For Insert Data || 2: For Delete Data || 3: For Edit || 4: Search");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: data.Add(new Mobike());
                    
                    data[data.Count-1].input();
                    data[data.Count-1].compute();
                    for (int i = 0; i < data.Count; i++)
                    {
                        data[i].display();
                    }
                    break;

                case 2: data.RemoveAt(data.Count-1);
                    for (int i = 0; i < data.Count; i++)
                    {
                        data[i].display();
                    }
                    break;

                case 3: 
                    data[data.Count-1].display();
                    break;

            }

            


            Console.ReadLine();
        }
    }
}
