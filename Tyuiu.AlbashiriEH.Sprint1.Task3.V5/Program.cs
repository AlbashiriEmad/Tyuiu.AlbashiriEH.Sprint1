using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AlbashiriEH.Sprint1.Task3.V5.Lib;

namespace Tyuiu.AlbashiriEH.Sprint1.Task3.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Содномов В.М. | СмартБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Class Math                                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Содномов Валерий Михайлович | СмартБ-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления расстояния между населенными пунктами,    *");
            Console.WriteLine("* изображенными на карте. Ответ округлите до 3 знаков после запятой.      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите масштаб карты:   ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите расстояние между точками:   ");
            double y = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Расстояние между населенными пунтками равняется:  " + Math.Round(ds.DistanceLength(x, y)), 3);
            Console.ReadKey();
        }
    }
}
