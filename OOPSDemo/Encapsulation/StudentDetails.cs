using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo.Encapsulation
{
    internal class StudentDetails
    {
        
        private string studentName;
        private int age;

        //Properties
        public string Name
        {
            get { return studentName; }

            set
            {
                if (value.Length >= 3)
                    studentName = value;
                else
                    Console.WriteLine("Please enter valid name,name should consists of min 3 characters");
            }
        }
        public int Age
        {
            get { return age; }

            set
            {
                if (value > 0)
                    age = value;
                else Console.WriteLine("Age should be greater than zero");
            }
        }

        public void StudentData()
        {
            Console.WriteLine("Name:{0},Age:{1}",Name,age);
        }

    }
}
