using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo.Abstraction
{
    internal abstract class ATM
    {
        public void WithDrawMoney()
        {
            Console.WriteLine("You can withdraw money from atm machine");
        }
        public abstract void ConnectingToBackEnd();
    }
}
