using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovJD.Sprint0.Csharp.Task5.V1.Lib;

namespace Tyuiu.IvanovJD.Sprint0.Csharp.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B" + DataService.Addition(10, 5));
            Console.WriteLine("A - B" + DataService.Substraction(15, 5));
            Console.WriteLine("A * B" + DataService.Multiplication(17, 5));
            Console.WriteLine("A / B" + DataService.Division(9, 3));
            Console.ReadKey();
        }
    }
}
