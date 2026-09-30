using System;

namespace Lab1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Methods lab = new Methods();

            // Задача 1
            {
                Console.WriteLine("введите число x: ");
                double x = double.Parse(Console.ReadLine());

                double result = lab.Fraction(x);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 2
            {
                Console.WriteLine("введите цифру: ");
                char x = char.Parse(Console.ReadLine());

                int result = lab.CharToNum(x);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 3
            {
                Console.WriteLine("введите число: ");
                int x = int.Parse(Console.ReadLine());

                bool result = lab.Is2Digits(x);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 4
            {
                Console.WriteLine("введите границу а:");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("введите границу b:");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("введите число num:");
                int num = int.Parse(Console.ReadLine());

                bool result = lab.IsInRange(a, b, num);
                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 5
            {
                Console.WriteLine("введите числа a,b,c:");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());

                bool result = lab.IsEqual(a, b, c);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 6
            {
                Console.WriteLine("введите число:");
                int x = int.Parse(Console.ReadLine());

                int result = lab.Abc(x);

                Console.WriteLine("результат");
                Console.WriteLine(result);
            }

            // Задача 7
            {
                Console.WriteLine("введите число:");
                int x = int.Parse(Console.ReadLine());

                bool result = lab.Is35(x);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 8
            {
                Console.WriteLine("введите числа:");
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                int z = int.Parse(Console.ReadLine());

                int result = lab.Max3(x, y, z);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 9
            {
                Console.WriteLine("введите числа x,y:");
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                int result = lab.Sum2(x, y);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 10
            {
                Console.WriteLine("введите номер дня недели (1-7)");
                int x = int.Parse(Console.ReadLine());

                string result = lab.Day(x);

                Console.WriteLine("результат");
                Console.WriteLine(result);
            }

            // Задача 11
            {
                Console.WriteLine("введите число:");
                int x = int.Parse(Console.ReadLine());

                string result = lab.ListNums(x);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 12
            {
                Console.WriteLine("введите число:");
                int x = int.Parse(Console.ReadLine());

                string result = lab.Chet(x);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 13
            {
                Console.WriteLine("введите число:");
                int x = int.Parse(Console.ReadLine());

                int result = lab.NumLen(x);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 14
            {
                Console.WriteLine("введите размер квадрата:");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("результат:");
                lab.Square(x);
            }

            // Задача 15
            {
                Console.WriteLine("введите высоту треугольника:");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("результат:");
                lab.RightTriangle(x);
            }

            // Задача 16
            {
                Console.WriteLine("введите размер массива:");
                int n = int.Parse(Console.ReadLine());

                int[] arr = new int[n];

                Console.WriteLine("введите эл-ты массива:");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("введите число х:");
                int x = int.Parse(Console.ReadLine());

                int result = lab.FindFirst(arr, x);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 17
            {
                Console.WriteLine("введите размер массива:");
                int n = int.Parse(Console.ReadLine());

                int[] arr = new int[n];

                Console.WriteLine("введите элементы массива:");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                int result = lab.MaxAbs(arr);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 18
            {
                Console.WriteLine("введите размер массива arr: ");
                int n = int.Parse(Console.ReadLine());

                int[] arr = new int[n];

                Console.WriteLine("введите элементы массива arr: ");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("введите размер массива ins: ");
                int m = int.Parse(Console.ReadLine());

                int[] ins = new int[m];

                Console.WriteLine("введите элементы массива ins: ");
                for (int i = 0; i < m; i++)
                {
                    ins[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("введите позицию pos: ");
                int pos = int.Parse(Console.ReadLine());

                int[] result = lab.Add(arr, ins, pos);

                Console.WriteLine("результат:");
                for (int i = 0; i < result.Length; i++)
                {
                    Console.Write(result[i] + " ");
                }

                Console.WriteLine();
            }

            // Задача 19
            {
                Console.WriteLine("введите размер массива: ");
                int n = int.Parse(Console.ReadLine());

                int[] arr = new int[n];

                Console.WriteLine("введите элементы массива: ");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                int[] result = lab.ReverseBack(arr);

                Console.WriteLine("результат:");
                for (int i = 0; i < result.Length; i++)
                {
                    Console.Write(result[i] + " ");
                }

                Console.WriteLine();
            }

            // Задача 20
            {
                Console.WriteLine("введите размер массива: ");
                int n = int.Parse(Console.ReadLine());

                int[] arr = new int[n];

                Console.WriteLine("введите элементы массива: ");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("введите число x: ");
                int x = int.Parse(Console.ReadLine());

                int[] result = lab.FindAll(arr, x);

                Console.WriteLine("результат:");
                for (int i = 0; i < result.Length; i++)
                {
                    Console.Write(result[i] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}