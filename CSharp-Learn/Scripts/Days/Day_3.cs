using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Learn.Scripts.Days
{
    class Day_3
    {
        public Day_3()
        {
            // Day 3
            // Теперь вместо повторения пактик я пишу код под 1 тему несколько разных задач меняя текст или кол-во строк для одной программы.
            // Это касается последующих дней, для лучшего запоминания кода и разработки своей логики.

            Console.Write("Ваше число: ");
            int a = int.Parse(Console.ReadLine());

            if (a > 0) Console.WriteLine("Ваше число положительное.");
            else if (a == 0) Console.WriteLine("Это ноль.");
            else Console.WriteLine("Ваше число отрицательное.");

            Console.Write("Ваша оценка: ");
            int b = int.Parse(Console.ReadLine());

            if (b > 80) Console.WriteLine("Ваша оценка отличная.");
            else if (b > 50) Console.WriteLine("Ваша оценка хорошая.");
            else if (b > 30) Console.WriteLine("Ваша оценка средняя.");
            else Console.WriteLine("Ваша оценка плохая.");


            int c = 5;
            int d = 15;
            int stepen = 0;

            if (c < 0) Console.WriteLine("Программа не умеет считать отрицательные числа.");
            else if (d < 0) Console.WriteLine("Программа не умеет считать отрицательные степени чисел.");
            else stepen = c * d; Console.WriteLine("Ответ: " + stepen);
        }
    }
}
