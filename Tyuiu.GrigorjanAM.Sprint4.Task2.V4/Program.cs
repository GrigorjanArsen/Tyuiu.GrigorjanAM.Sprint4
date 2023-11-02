using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GrigorjanAM.Sprint4.Task2.V4.Lib;

namespace Tyuiu.GrigorjanAM.Sprint4.Task2.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random r = new Random();
            Console.Title = "Спринт #4 | Выполнил: Григорян А. М. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Григорян Арсен Мовсесович | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, выводящую сумму нечетных чисел массива, заполненного*");
            Console.WriteLine("* случайными элементами в диапазоне от 2 до 9, состоящим из 13 эл-тов.    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int len = 13;
            //Console.Write("Введите количество элементов массива: ");
            //len = Convert.ToInt32(Console.ReadLine());

            int[] numsA = new int[len];
            for (int i = 0; i < len; i++)
            {
                numsA[i] = r.Next(2,9);
            }
            //Console.WriteLine();

            Console.WriteLine("Массив: ");
            for (int i = 0; i < len; i++)
            {
                Console.Write(numsA[i] + " ");
            }
            //Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(numsA);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
