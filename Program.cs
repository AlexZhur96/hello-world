using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; // Добавил static System.Console, чтобы не писать Console в коде
 
namespace HelloWorldConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Привет, мир!"); //WriteLine(" "); вывод текст в консоль

            ReadKey();                //ReadKey(); задерживает консоль на экране
        }
    }
}
