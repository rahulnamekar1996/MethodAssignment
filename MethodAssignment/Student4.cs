using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    internal class Student4
    { 
        public string Name { get; set; }
        public int Age { get; set; }

     
        public void Initialize(string name, int age)
        {
            
            Name = name;
            Age = age;
        }

     
        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }


    }
}
