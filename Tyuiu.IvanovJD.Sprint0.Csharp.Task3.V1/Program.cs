using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovJD.Sprint0.Csharp.Task4.V1.Lib;

namespace Tyuiu.IvanovJD.Sprint0.Csharp.Task4.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1,5));
            Console.WriteLine(DataService.Substraction(6, 5));
            Console.WriteLine(DataService.Multiplication(3, 5));
            Console.WriteLine(DataService.Division(10, 5));
            Console.ReadKey();

        }
    }
}
