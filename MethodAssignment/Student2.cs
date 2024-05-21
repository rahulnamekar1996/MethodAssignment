using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    internal class Student2
    {
        private int id;
        private string name;

        public void setCustomData(int customId, string customName)
        {
       
            this.id = customId;
            this.name = customName;
        }

        public void displayData()
        {
            Console.WriteLine("Student ID: " + this.id);
            Console.WriteLine("Student Name: " + this.name);
        }

    }
}
