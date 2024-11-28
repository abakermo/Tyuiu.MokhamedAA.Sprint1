
using Tyuiu.MokhamedAA.Sprint1.Task6.V2.Lib;
namespace Tyuiu.MokhamedAA.Sprint1.Task6.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string maybeAGreeting;

            Console.WriteLine("Введите текст: ");
            maybeAGreeting = Console.ReadLine();

            if (ds.CheckHello(maybeAGreeting))
            {
                Console.WriteLine("Ваш текст содержит Hello ");
            }
            else
            {
                Console.WriteLine("Ваш текст не содержит Hello ");
            }
            Console.ReadKey();
        }
    }
}
