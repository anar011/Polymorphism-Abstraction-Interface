using Polymorphism_Abstraction.Services2.Interface2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstraction.Services2
{
    internal class Calculation : ICalculation
    {
          public double Calculate(int num1, int num2, string operation)
        {
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    return result;

                case "-":
                    result = num2 - num1;
                    return result;
                case "*":
                    result = num1 * num2;
                    return result;


                case "/":
                    result = num2 / num1;
                    return result;

                default:

                    Console.WriteLine( "Please add correct operation");
                    return result;
            }
        }

        void ICalculation.Calculate(int num1, int num2, string operation)
        {
           
        }
    }
}
