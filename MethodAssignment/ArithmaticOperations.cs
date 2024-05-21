using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class ArithmaticOperations
    {
      
        public void Add()
        {
            int num1 = 10;
            int num2 = 5;
            int result = num1 + num2;
            Console.WriteLine("Addition Result: " + result);
        }

        
        public void Subtract()
        {
            int num1 = 10;
            int num2 = 5;
            int result = num1 - num2;
            Console.WriteLine("Subtraction Result: " + result);
        }

       
        public void Multiply()
        {
            int num1 = 10;
            int num2 = 5;
            int result = num1 * num2;
            Console.WriteLine("Multiplication Result: " + result);
        }
        
        public void Divide()
        {
            int num1 = 10;
            int num2 = 5;
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
