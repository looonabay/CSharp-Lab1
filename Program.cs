using System;

namespace Lab1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Methods lab = new Methods();

            // Задача 1
            Console.Write("введите число x: ");
            double x1;
            while (!double.TryParse(Console.ReadLine(), out x1))
            {
                Console.Write("Ошибка! Введите корректное число: ");
            }

            double result1 = lab.Fraction(x1);

            Console.WriteLine("результат:");
            Console.WriteLine(result1);

            // Задача 2
            Console.Write("введите цифру: ");
            char x2;
            while (!char.TryParse(Console.ReadLine(), out x2))
            {
                Console.Write("Ошибка! Введите ровно один символ: ");
            }

            int result2 = lab.CharToNum(x2);

            Console.WriteLine("результат:");
            Console.WriteLine(result2);

            // Задача 3
            Console.Write("введите число: ");
            int x3;
            while (!int.TryParse(Console.ReadLine(), out x3))
            {
                Console.Write("Ошибка! Введите целое число: ");
            }

            bool result3 = lab.Is2Digits(x3);

            Console.WriteLine("результат:");
            Console.WriteLine(result3);

            // Задача 4
            Console.Write("введите границу а: ");
            int a4;
            while (!int.TryParse(Console.ReadLine(), out a4))
            {
                Console.Write("Ошибка! Введите целое число a: ");
            }

            Console.Write("введите границу b: ");
            int b4;
            while (!int.TryParse(Console.ReadLine(), out b4))
            {
                Console.Write("Ошибка! Введите целое число b: ");
            }

            Console.Write("введите число num: ");
            int num4;
            while (!int.TryParse(Console.ReadLine(), out num4))
            {
                Console.Write("Ошибка! Введите целое число num: ");
            }

            bool result4 = lab.IsInRange(a4, b4, num4);
            Console.WriteLine("результат:");
            Console.WriteLine(result4);

            // Задача 5
            Console.WriteLine("введите числа a, b, c:");

            Console.Write("a: ");
            int a5;
            while (!int.TryParse(Console.ReadLine(), out a5))
            {
                Console.Write("Ошибка! Введите целое число a: ");
            }

            Console.Write("b: ");
            int b5;
            while (!int.TryParse(Console.ReadLine(), out b5))
            {
                Console.Write("Ошибка! Введите целое число b: ");
            }

            Console.Write("c: ");
            int c5;
            while (!int.TryParse(Console.ReadLine(), out c5))
            {
                Console.Write("Ошибка! Введите целое число c: ");
            }

            bool result5 = lab.IsEqual(a5, b5, c5);

            Console.WriteLine("результат:");
            Console.WriteLine(result5);

            // Задача 6
            Console.Write("введите число: ");
            int x6;
            while (!int.TryParse(Console.ReadLine(), out x6))
            {
                Console.Write("Ошибка! Введите целое число: ");
            }

            int result6 = lab.Abc(x6);

            Console.WriteLine("результат:");
            Console.WriteLine(result6);

            // Задача 7
            Console.Write("введите число: ");
            int x7;
            while (!int.TryParse(Console.ReadLine(), out x7))
            {
                Console.Write("Ошибка! Введите целое число: ");
            }

            bool result7 = lab.Is35(x7);

            Console.WriteLine("результат:");
            Console.WriteLine(result7);

            // Задача 8
            Console.WriteLine("введите числа x, y, z:");

            Console.Write("x: ");
            int x8;
            while (!int.TryParse(Console.ReadLine(), out x8))
            {
                Console.Write("Ошибка! Введите целое число x: ");
            }

            Console.Write("y: ");
            int y8;
            while (!int.TryParse(Console.ReadLine(), out y8))
            {
                Console.Write("Ошибка! Введите целое число y: ");
            }

            Console.Write("z: ");
            int z8;
            while (!int.TryParse(Console.ReadLine(), out z8))
            {
                Console.Write("Ошибка! Введите целое число z: ");
            }

            int result8 = lab.Max3(x8, y8, z8);

            Console.WriteLine("результат:");
            Console.WriteLine(result8);

            // Задача 9
            Console.WriteLine("введите числа x, y:");

            Console.Write("x: ");
            int x9;
            while (!int.TryParse(Console.ReadLine(), out x9))
            {
                Console.Write("Ошибка! Введите целое число x: ");
            }

            Console.Write("y: ");
            int y9;
            while (!int.TryParse(Console.ReadLine(), out y9))
            {
                Console.Write("Ошибка! Введите целое число y: ");
            }

            int result9 = lab.Sum2(x9, y9);

            Console.WriteLine("результат:");
            Console.WriteLine(result9);

            // Задача 10
            Console.Write("введите номер дня недели (1-7): ");
            int x10;
            while (!int.TryParse(Console.ReadLine(), out x10))
            {
                Console.Write("Ошибка! Введите целое число: ");
            }

            string result10 = lab.Day(x10);

            Console.WriteLine("результат:");
            Console.WriteLine(result10);

            // Задача 11
            Console.Write("введите число: ");
            int x11;
            while (!int.TryParse(Console.ReadLine(), out x11))
            {
                Console.Write("Ошибка! Введите целое число: ");
            }

            string result11 = lab.ListNums(x11);

            Console.WriteLine("результат:");
            Console.WriteLine(result11);

            // Задача 12
            Console.Write("введите число: ");
            int x12;
            while (!int.TryParse(Console.ReadLine(), out x12))
            {
                Console.Write("Ошибка! Введите целое число: ");
            }

            string result12 = lab.Chet(x12);

            Console.WriteLine("результат:");
            Console.WriteLine(result12);

            // Задача 13
            Console.Write("введите число: ");
            int x13;
            while (!int.TryParse(Console.ReadLine(), out x13))
            {
                Console.Write("Ошибка! Введите целое число: ");
            }

            int result13 = lab.NumLen(x13);

            Console.WriteLine("результат:");
            Console.WriteLine(result13);

            // Задача 14
            Console.Write("введите размер квадрата: ");
            int x14;
            while (!int.TryParse(Console.ReadLine(), out x14))
            {
                Console.Write("Ошибка! Введите целое число: ");
            }

            Console.WriteLine("результат:");
            lab.Square(x14);

            // Задача 15
            Console.Write("введите высоту треугольника: ");
            int x15;
            while (!int.TryParse(Console.ReadLine(), out x15))
            {
                Console.Write("Ошибка! Введите целое число: ");
            }

            Console.WriteLine("результат:");
            lab.RightTriangle(x15);

            // Задача 16
            Console.Write("введите размер массива: ");
            int n16;
            while (!int.TryParse(Console.ReadLine(), out n16))
            {
                Console.Write("Ошибка! Введите целое число: ");
            }

            int[] arr16 = new int[n16];

            Console.WriteLine("введите эл-ты массива:");
            for (int i = 0; i < n16; i++)
            {
                Console.Write($"[{i}]: ");
                while (!int.TryParse(Console.ReadLine(), out arr16[i]))
                {
                    Console.Write($"Ошибка! Введите целое число для [{i}]: ");
                }
            }

            Console.Write("введите число х: ");
            int x16;
            while (!int.TryParse(Console.ReadLine(), out x16))
            {
                Console.Write("Ошибка! Введите целое число х: ");
            }

            int result16 = lab.FindFirst(arr16, x16);

            Console.WriteLine("результат:");
            Console.WriteLine(result16);

            // Задача 17
            Console.Write("введите размер массива: ");
            int n17;
            while (!int.TryParse(Console.ReadLine(), out n17))
            {
                Console.Write("Ошибка! Введите целое число: ");
            }

            int[] arr17 = new int[n17];

            Console.WriteLine("введите элементы массива:");
            for (int i = 0; i < n17; i++)
            {
                Console.Write($"[{i}]: ");
                while (!int.TryParse(Console.ReadLine(), out arr17[i]))
                {
                    Console.Write($"Ошибка! Введите целое число для [{i}]: ");
                }
            }

            int result17 = lab.MaxAbs(arr17);

            Console.WriteLine("результат:");
            Console.WriteLine(result17);

            // Задача 18
            Console.Write("введите размер массива arr: ");
            int n18;
            while (!int.TryParse(Console.ReadLine(), out n18))
            {
                Console.Write("Ошибка! Введите целое число: ");
            }

            int[] arr18 = new int[n18];

            Console.WriteLine("введите элементы массива arr:");
            for (int i = 0; i < n18; i++)
            {
                Console.Write($"[{i}]: ");
                while (!int.TryParse(Console.ReadLine(), out arr18[i]))
                {
                    Console.Write($"Ошибка! Введите целое число для [{i}]: ");
                }
            }

            Console.Write("введите размер массива ins: ");
            int m18;
            while (!int.TryParse(Console.ReadLine(), out m18))
            {
                Console.Write("Ошибка! Введите целое число: ");
            }

            int[] ins18 = new int[m18];

            Console.WriteLine("введите элементы массива ins:");
            for (int i = 0; i < m18; i++)
            {
                Console.Write($"[{i}]: ");
                while (!int.TryParse(Console.ReadLine(), out ins18[i]))
                {
                    Console.Write($"Ошибка! Введите целое число для [{i}]: ");
                }
            }

            Console.Write("введите позицию pos: ");
            int pos18;
            while (!int.TryParse(Console.ReadLine(), out pos18))
            {
                Console.Write("Ошибка! Введите целое число: ");
            }

            int[] result18 = lab.Add(arr18, ins18, pos18);

            Console.WriteLine("результат:");
            Console.WriteLine($"[{string.Join(", ", result18)}]");

            // Задача 19
            Console.Write("введите размер массива: ");
            int n19;
            while (!int.TryParse(Console.ReadLine(), out n19))
            {
                Console.Write("Ошибка! Введите целое число: ");
            }

            int[] arr19 = new int[n19];

            Console.WriteLine("введите элементы массива:");
            for (int i = 0; i < n19; i++)
            {
                Console.Write($"[{i}]: ");
                while (!int.TryParse(Console.ReadLine(), out arr19[i]))
                {
                    Console.Write($"Ошибка! Введите целое число для [{i}]: ");
                }
            }

            int[] result19 = lab.ReverseBack(arr19);

            Console.WriteLine("результат:");
            Console.WriteLine($"[{string.Join(", ", result19)}]");

            // Задача 20
            Console.Write("введите размер массива: ");
            int n20;
            while (!int.TryParse(Console.ReadLine(), out n20))
            {
                Console.Write("Ошибка! Введите целое число: ");
            }

            int[] arr20 = new int[n20];

            Console.WriteLine("введите элементы массива:");
            for (int i = 0; i < n20; i++)
            {
                Console.Write($"[{i}]: ");
                while (!int.TryParse(Console.ReadLine(), out arr20[i]))
                {
                    Console.Write($"Ошибка! Введите целое число для [{i}]: ");
                }
            }

            Console.Write("введите число x: ");
            int x20;
            while (!int.TryParse(Console.ReadLine(), out x20))
            {
                Console.Write("Ошибка! Введите целое число x: ");
            }

            int[] result20 = lab.FindAll(arr20, x20);

            Console.WriteLine("результат:");
            Console.WriteLine($"[{string.Join(", ", result20)}]");
        }
    }
}
