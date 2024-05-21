using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class Student5
    {
        // Properties
        public string Name { get; set; }
        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int Mark3 { get; set; }

        // Constructor
        public Student5(string name, int mark1, int mark2, int mark3)
        {
            Name = name;
            Mark1 = mark1;
            Mark2 = mark2;
            Mark3 = mark3;
        }

        // Method to calculate percentage
        public double CalculatePercentage()
        {
            int totalMarks = Mark1 + Mark2 + Mark3;
            return (double)totalMarks / 3;
        }
        // Method to display student data
        public void DisplayStudentData()
        {
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Marks: ");
            Console.WriteLine("Mark 1: " + Mark1);
            Console.WriteLine("Mark 2: " + Mark2);
            Console.WriteLine("Mark 3: " + Mark3);
        }

        // Method with parameter list
        public void UpdateMarks(int mark1, int mark2, int mark3)
        {
            Mark1 = mark1;
            Mark2 = mark2;
            Mark3 = mark3;
            Console.WriteLine("Marks updated successfully.");
        }

    }
}
