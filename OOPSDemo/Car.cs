using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    internal class Car
    {
        //Attributes or Variables
        public string model;
        public string colour;
        public double price;

        public void Drive()
        {
            Console.WriteLine("Turn On Ignition");
            Console.WriteLine("Car Can Drive");
        }
        public void CarDetails()
        {
            Console.WriteLine("Model:{0} Colour:{1} Price:{2}",model,colour,price);
        }
    }
}
