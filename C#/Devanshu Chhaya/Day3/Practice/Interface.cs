using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePrac
{
    interface IVehical
    {
        void changeGear(int a);
        void speedUp(int a);
        void breakSpeed(int a);

    }

    class car : IVehical
    {
        int gear;
        int speed;

        public void changeGear(int number)
        {
            gear = number;
        }

        public void speedUp(int kmph)
        {
            speed = speed + kmph;
        }

        public void breakSpeed(int decr)
        {
            speed = speed - decr;
        }

        public void display()
        {
            changeGear(5);
            speedUp(55);
            breakSpeed(25);

            Console.WriteLine("Gear: " + gear + " speed: " + speed);

            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            car myCar = new car();
            myCar.display();
            Console.ReadKey();
        }
    }
}
