using Polymorphism_Abstraction.Serevices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstraction.Serevices
{
    internal class CalculateService : ICalculateService, ICommonService
    {
        public void SumNumbers(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }
        public int GetSumNumbersFromArray(int[] numbers)
        {

            int sum = 0;

            foreach (int item in numbers)
            {
             sum+= item;
            
            
            
            }
            return sum;
           

        }

        public string FullData()
        {
            throw new NotImplementedException();
        }
    }
}

