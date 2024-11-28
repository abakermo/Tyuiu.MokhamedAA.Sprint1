using Tyuiu.MokhamedAA.Sprint1.Task7.V24.Lib;
namespace Tyuiu.MokhamedAA.Sprint1.Task7.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                        *");
            Console.WriteLine("***************************************************************************");




            DataService ds = new DataService();

            Console.Write("x=");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y=");
            double y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine(ds.Calculate(x, y));
        }
    }
}
