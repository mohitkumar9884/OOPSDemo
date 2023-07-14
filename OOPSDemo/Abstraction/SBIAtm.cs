using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo.Abstraction
{
    internal class SBIAtm:ATM
    {
        public override void ConnectingToBackEnd()
        {
            Console.WriteLine("Connecting to backend");
        }
    }
}
