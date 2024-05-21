using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
     public class SquareCalculator
    {
      
        public void SquareNoReturnType()
        {
            int number = 5;
            int square = number * number;
            Console.WriteLine("Square of " + number + " is: " + square);
        }

        
        public int SquareWithReturnType()
        {
            int number = 5;
            return number * number;
        }

       
        public void SquareWithParameterNoReturnType(int number)
        {
            int square = number * number;
            Console.WriteLine("Square of " + number + " is: " + square);
        }

      
        public int SquareWithParameterAndReturnType(int number)
        {
            return number * number;
        }


    }
}
