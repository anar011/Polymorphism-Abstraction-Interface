using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Polymorphism_Abstraction.Models
//{
//    internal class Animal
//    {
//        public int id { get; set; }
//        public string Name { get; set; }
//        public string Color { get; set; }

//        public virtual void Sound()
//        {
//            Console.WriteLine("Animal sound");
//        }

        
//    }       
      
    
//}


namespace Polymorphism_Abstraction.Models
{
    internal abstract class Animal
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }

        public abstract void Eating();


    }
   

}