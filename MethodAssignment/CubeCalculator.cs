using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
     
     public class CubeCalculator
    {
        static void Main(string[] args)
        {
            CubeWithoutReturnTypeAndParameter();


            int resultWithReturnType = CubeWithReturnType();
            Console.WriteLine($"Cube with return type: {resultWithReturnType}");


            int number = 5;
            CubeWithParameter(number);


            int resultWithParameterAndReturnType = CubeWithParameterAndReturnType(number);
            Console.WriteLine($"Cube with parameter and return type: {resultWithParameterAndReturnType}");




        }


        static void CubeWithoutReturnTypeAndParameter()
        {
            int number = 3; // Example number
            int cube = number * number * number;
            Console.WriteLine($"Cube without return type and parameter passing: {cube}");
        }

       
        static int CubeWithReturnType()
        {
            int number = 4; // Example number
            return number * number * number;
        }
    
        static void CubeWithParameter(int num)
        {
            int cube = num * num * num;
            Console.WriteLine($"Cube with parameter passing but without return type: {cube}");
        }

  
        static int CubeWithParameterAndReturnType(int num)
        {
            return num * num * num;
        }


    }
}

