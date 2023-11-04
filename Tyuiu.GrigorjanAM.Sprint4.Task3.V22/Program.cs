using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GrigorjanAM.Sprint4.Task3.V22.Lib;

namespace Tyuiu.GrigorjanAM.Sprint4.Task3.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Григорян А. М. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Григорян Арсен Мовсесович | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, выводящую максимальный элемент первой строки матрицы*");
            Console.WriteLine("* 5х5, заполненной статич. эл-тами от 4 до 9.                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] matrix = { { 4, 4, 7, 8, 9 },
                            { 9, 5, 9, 7, 8 },
                            { 7, 4, 9, 4, 6 },
                            { 4, 4, 7, 4, 4 },
                            { 4, 5, 8, 6, 7 } };
            Console.WriteLine("(4, 4, 7, 8, 9)");
            Console.WriteLine("(9, 5, 9, 7, 8)");
            Console.WriteLine("(7, 4, 9, 4, 6)");
            Console.WriteLine("(4, 4, 7, 4, 4)");
            Console.WriteLine("(4, 5, 8, 6, 7)");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Максимальный элемент первой строки матрицы  = " + ds.Calculate(matrix));
            Console.ReadKey();

        }
    }
}
