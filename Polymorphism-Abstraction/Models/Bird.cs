using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Polymorphism_Abstraction.Models
//{
//    internal class Bird : Animal
//    {
//        public string Type { get; set; }

//        public override void Sound()
//        {
//            Console.WriteLine("Bird sound");
//        }

//            //public override string GetDate()
//            //{
//            //   return base.GetDate();  


//            //}



//    } 
//}




namespace Polymorphism_Abstraction.Models
{
    internal abstract class Bird : Animal
    {
        public string Type { get; set; }

        public override void Sound()
        {
            Console.WriteLine("Bird sound");
        }

        //public override void Eating()
        //{
        //    Console.WriteLine("Bird eating");
        //}
        
    }
}