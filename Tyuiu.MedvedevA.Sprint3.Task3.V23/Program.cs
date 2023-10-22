using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MedvedevA.Sprint3.Task3.V23.Lib;

namespace Tyuiu.MedvedevA.Sprint3.Task3.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value = 1, startValue = 1, stopValue = 6;
            Console.WriteLine($"Переменная X: {value}");
            Console.WriteLine($"Старт шага: {startValue}");
            Console.WriteLine($"Конец шага: {stopValue}");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write($"Сумма ряда = {dataService.GetMultiplySeries(value, startValue, stopValue)}");

            Console.ReadKey();
        }
    }
}
