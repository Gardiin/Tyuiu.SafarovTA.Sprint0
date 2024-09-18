using Tyuiu.SafarovTA.Sprint0.Task5.V0.Lib;
namespace Tyuiu.SafarovTA.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(5, 5));
            Console.WriteLine("A - B = " + DataService.Subtraction(5, 5));
            Console.WriteLine("A * B = " + DataService.Multiplication(5, 5));
            Console.WriteLine("A / B = " + DataService.Division(5, 5));
            Console.ReadKey();
        }
    }
}
