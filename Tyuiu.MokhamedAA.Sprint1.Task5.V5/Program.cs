using Tyuiu.MokhamedAA.Sprint1.Task5.V5.Lib;
namespace Tyuiu.MokhamedAA.Sprint1.Task5.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите положительное вещественное число x: ");
            double x = double.Parse(Console.ReadLine());

       
            if (x <= 0)
            {
                Console.WriteLine("Число должно быть положительным.");
                return;
            }

            
            double part = x - Math.Floor(x);

           
            int d = (int)(part * 10);

  
            Console.WriteLine($"Первая цифра дробной части числа {x} - это {d}");

            Console.ReadKey();
        }
    }
}
