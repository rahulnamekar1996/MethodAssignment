﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class ArithmaticOperations2
    {

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

      
        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

    
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

      
        public double Divide(int num1, int num2)
        {
            if (num2 != 0)
            {
                return (double)num1 / num2;
            }
            else
            {
                Console.WriteLine("Cannot divide by zero!");
                return double.NaN; 
            }
        }


    }
}
