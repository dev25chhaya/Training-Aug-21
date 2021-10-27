//1.Create a reference type called Person.  
//Populate the Person class with the following properties to store the following information:

//First name
//Last name
//Email address
//Date of birth

//Add constructors that accept the following parameter lists:

//1.All four parameters

//2. First, Last, Email

//3. First, Last, Date of birth

//Add read-only properties that return the following computed information:


//1.Adult – whether or not the person is over 18

//2. Sun sign – the traditional western sun sign of this person

//3. Chinese sign – the chinese astrological sign (animal) of this person

//4. Birthday – whether or not today is the person’s birthday

//5. Screen name – a default screen name that you might see being offered to a first time user of AOL or Yahoo (e.g.John Doe born on Feburary 25th, 1980 might be jdoe225 or johndoe022580)

//Access these things from Console Application in the Main Function. Accept this data for 5 person and display the same. 
//Means create an object Array of 5 size and accept these details and display these details in tabular format.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class person
    {
        public string firstname
        {
            get; set;
        }

        public string lastname { get; set; }

        public string emailAddress { get; set; }

        public DateTime bdate { get; set; }

        public person(string fname, string lname, string email, DateTime date)
        {
            this.firstname = fname;
            this.lastname = lname;
            this.emailAddress = email;
            this.bdate = date;
        }

        public person(string fname, string lname, string email)
        {
            this.firstname = fname;
            this.lastname = lname;
            this.emailAddress = email;
        }

        public person(string fname, string lname, DateTime date)
        {
            this.firstname = fname;
            this.lastname = lname;
            this.bdate = date;
        }

        public string adult
        {
            get
            {
                DateTime dateTime = DateTime.Now;
                if (dateTime.Year - bdate.Year <= 18)
                {
                    string msg = "uner 18";
                    return msg;
                }
                else
                {
                    string msg = "Over 18";
                    return msg;
                }
                
            }
        }

        public string sunSign
        {
            get
            {
                
                if((bdate.Month==3&&bdate.Day>=13) || (bdate.Month==4 && bdate.Day<=12))
                {
                    string msg = "Pisces";
                    return msg;
                }
                if ((bdate.Month == 4 && bdate.Day >= 13) || (bdate.Month == 5 && bdate.Day <= 14))
                {
                    string msg = "Aries";
                    return msg;
                }
                if ((bdate.Month == 5 && bdate.Day >= 15) || (bdate.Month == 6 && bdate.Day <= 14))
                {
                    string msg = "Taurus";
                    return msg;
                }
                if ((bdate.Month == 6 && bdate.Day >= 15) || (bdate.Month == 7 && bdate.Day <= 14))
                {
                    string msg = "Gemini";
                    return msg;
                }
                if ((bdate.Month == 7 && bdate.Day >= 15) || (bdate.Month == 8 && bdate.Day <= 14))
                {
                    string msg = "Cancer";
                    return msg;
                }
                if ((bdate.Month == 8 && bdate.Day >= 15) || (bdate.Month == 9 && bdate.Day <= 15))
                {
                    string msg = "Leo";
                    return msg;
                }
                if ((bdate.Month == 9 && bdate.Day >= 16) || (bdate.Month == 10 && bdate.Day <= 15))
                {
                    string msg = "Virgo";
                    return msg;
                }
                if ((bdate.Month == 10 && bdate.Day >= 16) || (bdate.Month == 11 && bdate.Day <= 14))
                {
                    string msg = "Libra";
                    return msg;
                }
                if ((bdate.Month == 11 && bdate.Day >= 15) || (bdate.Month == 12 && bdate.Day <= 14))
                {
                    string msg = "Scorpio";
                    return msg;
                }
                if ((bdate.Month == 12 && bdate.Day >= 15) || (bdate.Month == 1 && bdate.Day <= 13))
                {
                    string msg = "Sagittarius";
                    return msg;
                }
                if ((bdate.Month == 1 && bdate.Day >= 14) || (bdate.Month == 2 && bdate.Day <= 11))
                {
                    string msg = "Capricorn";
                    return msg;
                }
                if ((bdate.Month == 2 && bdate.Day >= 12) || (bdate.Month == 3 && bdate.Day <= 12))
                {
                    string msg = "Capricorn";
                    return msg;
                }

                else
                {
                    string msg = "Please enter valid date";
                    return msg;
                }
            }
        }

        public string chineseSign
        {
            get
            {
                int add = 12;
                for(int i=1924; i<2043; i++)
                {
                    int j = 0;
                    if(bdate.Year==i+add && bdate.Year<2043)
                    {

                    }
                }
            }
        }

        public string birthday
        {
            get
            {
                DateTime today = DateTime.Now;
                if(today.Month==bdate.Month && today.Day == bdate.Day)
                {
                    string msg = "Happy Birthday";
                    return msg;
                }
                else
                {
                    string msg = "Today is not your bday";
                    return msg;
                }
            }
        }

        public string screenName
        {
            get
            {
                string defaultName = firstname.ToLower() + bdate.Month + bdate.Day;
                return defaultName;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new person[2];
            for ( int i=0; i <= persons.Length; i++)
            {
                Console.WriteLine("Enter the firstname, lastname, email and the birthday");
                string fname = Console.ReadLine();
                string lname = Console.ReadLine();
                string email = Console.ReadLine();
                DateTime btade =DateTime.Parse( Console.ReadLine());
                persons[i] = new person(fname, lname, email, btade);
                Console.WriteLine(persons[i].adult);
                Console.WriteLine(persons[i].sunSign);
                Console.WriteLine(persons[i].birthday);
                Console.WriteLine(persons[i].screenName);
                

            }
            Console.ReadLine();
        }
    }
}
