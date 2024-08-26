using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Learn.Scripts.Days
{
    class Day_2
    {
        public Day_2()
        {
            // Day 2

            int age = 19;
            /* В структуре int есть следующие методы:
             * 
             * 1. int.Equals() — используется для проверки, равны ли два объекта int. Возвращает логическое значение.
             * 2. int.Parse() — используется для преобразования или анализа строки в int.
             * 3. int.MaxValue — возвращает максимальное возможное значение переменной int.
             * 4. int.MinValue — возвращает миниимальное возможное значение переменной int.
             * 
            */

            double height = 5.7; // Это около 1.8м. double может уточнить до 15 цыфр после запятой, но не является самым точным.

            string name = "Alice";
            /* В структуре string есть следующие методы:
             * 
             * Compare: сравнивает две строки с учетом текущей культуры (локали) пользователя
             * CompareOrdinal: сравнивает две строки без учета локали
             * Contains: определяет, содержится ли подстрока в строке
             * Concat: соединяет строки
             * CopyTo: копирует часть строки, начиная с определенного индекса в массив
             * EndsWith: определяет, совпадает ли конец строки с подстрокой
             * Format: форматирует строку
             * IndexOf: находит индекс первого вхождения символа или подстроки в строке
             * Insert: вставляет в строку подстроку
             * Join: соединяет элементы массива строк
             * LastIndexOf: находит индекс последнего вхождения символа или подстроки в строке
             * Replace: замещает в строке символ или подстроку другим символом или подстрокой
             * Split: разделяет одну строку на массив строк
             * Substring: извлекает из строки подстроку, начиная с указанной позиции
             * ToLower: переводит все символы строки в нижний регистр
             * ToUpper: переводит все символы строки в верхний регистр
             * Trim: удаляет начальные и конечные пробелы из строки
             * 
            */

            bool isStudent = true;

            int a = 1;
            int b = 2;
            int c = a + b;
            bool isEqual = a == b;

            /* В структуре bool есть следующие методы:
             * 
             * Доступны четыре оператора сравнения:
             * Больше, чем (>).
             * Меньше (<).
             * Больше или равно (>=).
             * Меньше или равно (<=).
             * Строго равно (==).
             * Строго не равно (!=).
             * Истина (true).
             * Не истина (false).
             * 
            */
            bool isGreeterThan = a > b && b < 15;

            Console.WriteLine("Введите своё имя: ");
            string namee = Console.ReadLine();
            Console.WriteLine("Привет, " + namee + "!");

            Console.WriteLine("Введите число с точностью до 3 после точки: ");
            double num = double.Parse(Console.ReadLine()); // Не только int.Parse(), но ещё есть double.Parse()
            Console.WriteLine("Ваше число: " + num);





            // Тренеровка перед практикой: 
            Console.WriteLine("Ваше имя: ");
            string names = Console.ReadLine();

            Console.WriteLine("Ваш возраст: ");
            int ages = int.Parse(Console.ReadLine());

            Console.WriteLine("Ваше десятичное число: ");
            double any_num = double.Parse(Console.ReadLine());

            Console.WriteLine("Вас зовут: " + names + ". Ваш возраст: " + ages + ". Ваше число: " + any_num);

            Console.WriteLine("1-е число для суммы: ");
            double aa = double.Parse(Console.ReadLine());

            Console.WriteLine("2-е число для суммы: ");
            double bb = double.Parse(Console.ReadLine());

            double sum = aa + bb;

            Console.WriteLine(a + " + " + b + " = " + c); // Плюс нужен для того чтобы можно было соединить переменные с строкой. В Python так не работает.



            Console.WriteLine("Напишите оператор сравнения: ");

            switch (Console.ReadLine())
            {
                case ">":
                        Console.WriteLine("1-е число");
                        int aaa = int.Parse(Console.ReadLine());

                        Console.WriteLine("2-е число");
                        int bbb = int.Parse(Console.ReadLine());

                        if (bbb > a)
                        {
                            if (a > bbb)
                            {
                                Console.WriteLine(a + " больше чем " + bbb + " и " + bbb + " меньше чем " + a);
                            }
                            else if (a < bbb)
                            {
                                Console.WriteLine(a + " меньше чем " + bbb);
                            }
                            else
                            {
                                Console.WriteLine("Ваши числа равны.");
                            }
                        }

                        break;
                        
                case "<":
                        Console.WriteLine("1-е число");
                        int ccc = int.Parse(Console.ReadLine());

                        Console.WriteLine("2-е число");
                        int ddd = int.Parse(Console.ReadLine());

                        if (ddd > ccc)
                        {
                            Console.WriteLine(ddd + " больше чем " + ccc);
                        }
                        else if (ddd < ccc)
                        {
                            Console.WriteLine(ddd + " меньше чем " + ccc);
                        }
                        else
                        {
                            Console.WriteLine("Ваши числа равны.");
                        }
                        break;

            }

            Console.WriteLine("Ваше целое число: ");
            int sa = int.Parse(Console.ReadLine());

            if (sa % 2 == 0)
            {
                Console.WriteLine("Число четное.");
            }
            else
            {
                Console.WriteLine("Число не четное.");
            }

            Console.WriteLine("1-е число: ");
            int sb = int.Parse(Console.ReadLine());

            Console.WriteLine("2-е число: ");
            int sc = int.Parse(Console.ReadLine());

            int sd = sb + sc;
            Console.WriteLine("Сумма чисел равна: " + sd);

            // Практику для закрепления 2 дня не смог найти, т.к. все примеры выше похожи на 1-й день.
        }
    }
}
