﻿using OOPSDemo.Polymarphism;
using System.Collections;

namespace OOPSDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please chose any one program from below options");
            Console.WriteLine("1.ClassAndObject concept\n2.Inheritance\n3.Method overloading\n4.Method overriding");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                    case 1:
                    Car car1 = new Car();
                    car1.model = "Mustang";
                    car1.colour = "Matt Black";
                    car1.price = 7500000;
                    car1.CarDetails();
                    Car car2 = new Car();
                    car2.model = "Merc";
                    car2.colour = "Jupiter Red";
                    car2.price = 7000000;
                    car2.CarDetails();
                    break;
                    case 2:
                     Lion lion = new Lion();
                    lion.name = "Simba";
                    lion.Run();
                    break;
                    case 3:
                    Addition.Add(20, 40);
                    Addition.Add(20, 40, 60.45);
                    break;
                    default :
                    Console.WriteLine("Please chose a program within given options");
                    break;

            }
                   
           
        }
    }          
}
        
    
