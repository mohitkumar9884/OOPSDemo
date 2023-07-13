using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo.Polymarphism
{
    internal class Employee
    {
        public string name;
        public double salary;

        public virtual void GetSalary()
        {
            Console.WriteLine("21000");
        }

        public void EmployeeDetails()
        { 
            Console.WriteLine("Name:{0} Salary:{1}" ,name,salary);
        }
    }
    class PartTime:Employee
    {
        public override void GetSalary()
        {
            Console.WriteLine("9000");
        }
    }
}
