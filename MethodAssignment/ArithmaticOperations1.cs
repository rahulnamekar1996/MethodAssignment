using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class ArithmaticOperations1
    {
        public void Add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Addition Result: " + result);
        }

        // Method for subtraction with parameter passing
        public void Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine("Subtraction Result: " + result);
        }

        // Method for multiplication with parameter passing
        public void Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine("Multiplication Result: " + result);
        }

        // Method for division with parameter passing
        public void Divide(int num1, int num2)
        {
            if (num2 != 0)
            {
                double result = (double)num1 / num2;
                Console.WriteLine("Division Result: " + result);
            }
            else
            {
                Console.WriteLine("Cannot divide by zero!");
            }
        }

    }
}
