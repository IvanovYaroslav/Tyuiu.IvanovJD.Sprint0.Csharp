using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovJD.Sprint0.Csharp.Task7.V1.Lib;

namespace Tyuiu.IvanovJD.Sprint0.Csharp.Task7.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт №0 | Выполнил: Иванов Я. Д. | ПКТБ-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #0                                                                *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                              *");
            Console.WriteLine("* Задания #7                                                               *");
            Console.WriteLine("* Вариант #0                                                               *");
            Console.WriteLine("* Выполнил: Иванов Ярослав Дмитриевич  | ПКТБ-23-2                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать консольную программуна С#, которая суммирует значения двух      *");
            Console.WriteLine("* одинаковых массивов по длинне                                            *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Значение элементов Массива №1");
            for (int i = 0; i < arrayNums1.Length; i++)
            {
                Console.WriteLine(arrayNums1[i] + ", ");
            }

            Console.WriteLine();

            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Значение элементов Массива №2");
            for (int i = 0; i < arrayNums1.Length; i++)
            {
                Console.WriteLine(arrayNums2[i] + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            if (arrayNums1.Length == arrayNums2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);

                Console.WriteLine("Сумма элементов массива равна:");
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.WriteLine(resultArray[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Исзодные массивы имеют разное количество элементов");
            }
            Console.ReadKey();
        }
    }
}
