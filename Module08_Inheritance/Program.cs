//Joshua Pickenpaugh, IN2017, Adv.C#
//October 7th, 2015, Inheritance

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object instantiation:
            Duck duck1 = new Duck();
            duck1.Hello();

            //Inherited from Animal class:
            duck1.Sound();
            duck1.dude();
            
            
            Console.ReadKey();
        }
    }

    class Animal : Dude
    {
        public void Sound()
        {
            Console.WriteLine("Noise!!!");
        }
    }

    class Dude
    {
        public void dude()
        {
            Console.WriteLine("DUDE");
        }
    }

    //Derived class is "Duck":
    class Duck : Animal
    {
        public void Hello()
        {
            Console.WriteLine("Hello from Class Duck, Method Hello.");
        }
    }
}
