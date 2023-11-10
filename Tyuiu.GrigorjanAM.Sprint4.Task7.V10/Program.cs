using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GrigorjanAM.Sprint4.Task7.V10.Lib;

namespace Tyuiu.GrigorjanAM.Sprint4.Task7.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Григорян А. М. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Григорян Арсен Мовсесович | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, преобразующую строку с числами в матрицу 3х4,       *");
            Console.WriteLine("* а затем вычисляющую сумму нечётных элементов матрицы.                   *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string str = "695847142536";
            //Console.WriteLine("Исходная строка: " + str);

            int n = 3;
            int m = 4;
            int[,] mx = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mx[i, j] = int.Parse(str.Substring(i * m + j, 1));
                }
            }

            Console.WriteLine("Матрица: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{mx[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Сумма нечётных элементов матрицы = " + ds.Calculate(n, m, str));
            Console.ReadKey();
       
        }
    }
}
