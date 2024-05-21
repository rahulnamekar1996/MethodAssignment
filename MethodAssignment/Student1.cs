using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    internal class Student1
    {
        private int id;

        public int getId()
        {
            
            return 12345;
        }

        public void displayData()
        {
            
            int retrievedId = getId();

         
            this.id = retrievedId;

       
            Console.WriteLine("Student ID: " + this.id);
        }

    }
}
