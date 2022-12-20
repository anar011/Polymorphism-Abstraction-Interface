using Polymorphism_Abstraction.Serevices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstraction
{
    internal class Person :   Test, IPerson
    {
     

        public void GetNmae()
        {
            Console.WriteLine("Cavid");
        }

    }
}
