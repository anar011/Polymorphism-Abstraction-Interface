



using Polymorphism_Abstraction;
using Polymorphism_Abstraction.Models;
using Polymorphism_Abstraction.Serevices;
using Polymorphism_Abstraction.Serevices.Interfaces;
using Polymorphism_Abstraction.Services2;
//Animal animal = new Animal();
//animal.Sound();

//Bird bird= new Bird();

//bird.Sound();
//bird.Eating();
//Shark shark = new Shark();  
//shark.Sound();  
//shark.Eating();
//Car car = new Car();

//car.Test();
//GetNums(new int[] { 1, 2, 3, 4, 5, 6 });

//static void GetNums(int[] arr)
//{
//    foreach (var item in arr)
//    {
//        Console.WriteLine(item);
//    }

//}

//GetNums( 1, 2, 3, 4, 5, 6 );

//static void GetNums(int num2, params int[] arr )
//{
//    foreach (var item in arr)
//    {
//        Console.WriteLine(item);
//    }

//}

//Int32 num = new Int32();
//num = 40;

//int num = 40;
//Console.WriteLine(num);

//String str = new string("Salam");


//string str = "Salam";

//Console.WriteLine("Salam");


//CalculateService service = new CalculateService();

//ICalculateService service1 = new CalculateService();


//service.SumNumbers(3,6);

//service1.SumNumbers(100,500);

//IPerson person = new Person();
//person.GetNmae();

//ICalculateService service = new CalculateService();

//int result = service.GetSumNumbersFromArray(new int[] { 1, 2, 3, 4, 5 });

#region Calculation



Calculate()
static void Calculate()
{
    Calculation calculation = new();

    Console.WriteLine("Add first number :);

    int number1 = (int)float.Parse(Console.ReadLine())

    Console.WriteLine("Add operation :");
  
    string operation = int.Parse(Console.ReadLine());
    Console.WriteLine("Add second number :);
        int number2 = int.Parse(Console.ReadLine());
    var result = calculation.Calculate(number1, number2, operation);
    Console.WriteLine(result);


}

#endregion


