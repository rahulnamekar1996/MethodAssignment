using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    internal class Student
    {
        private int id;
        private string name;

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void displayData()
        {

            id = 102;
            name = "prashant";


            Console.WriteLine("Updated id: " + id);
            Console.WriteLine("Updated name :" + name);
        }
    }
}
