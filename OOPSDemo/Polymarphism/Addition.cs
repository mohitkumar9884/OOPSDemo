using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo.Polymarphism
{
    internal class Addition
    {
        public static void Add(int x, int y)
        {
            int z = x + y;
            Console.WriteLine("Sum:"+z);
        }
        //changing numbers of parameter from 1st to 2nd method
        public static void Add(int x,int y,int z)
        {
            int res = x + y;
            Console.WriteLine("Sum:"+ res);
        }
        //changing one Parameter datatype from 2nd method to 3rd method 
        public static void Add(int x,int y,double z)
        {
            double res = x + y+z;
            Console.WriteLine("Sum:" + res);
        }
        //
        public static void Add(int x, long y, int z)
        {
            long res = x + y + z;
            Console.WriteLine("Sum:" + res);
        }
    }
}
