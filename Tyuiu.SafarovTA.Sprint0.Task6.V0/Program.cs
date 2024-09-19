using Tyuiu.SafarovTA.Sprint0.Task6.V0.Lib;
namespace Tyuiu.SafarovTA.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Сумма = " + DataService.AdditionArray(numsArray));
            Console.WriteLine("Разность = " + DataService.SubtractionArray(numsArray));
            Console.WriteLine("Произведение = " + DataService.MultiplicationArray(numsArray));
            Console.ReadKey();
        }
    }
}
