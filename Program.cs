using System;

namespace Lab1
{
    internal class Program
    {
        private void Main(string[] args)
        {
            Methods lab = new Methods();

            // Задача 1
            {
                Console.Write("введите число x: ");
                double x;
                while (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Ошибка! Введите корректное число: ");
                }

                double result = lab.Fraction(x);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 2
            {
                Console.Write("введите цифру: ");
                char x;
                while (!char.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Ошибка! Введите ровно один символ: ");
                }

                int result = lab.CharToNum(x);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 3
            {
                Console.Write("введите число: ");
                int x;
                while (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Ошибка! Введите целое число: ");
                }

                bool result = lab.Is2Digits(x);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 4
            {
                Console.Write("введите границу а: ");
                int a;
                while (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.Write("Ошибка! Введите целое число a: ");
                }

                Console.Write("введите границу b: ");
                int b;
                while (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.Write("Ошибка! Введите целое число b: ");
                }

                Console.Write("введите число num: ");
                int num;
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.Write("Ошибка! Введите целое число num: ");
                }

                bool result = lab.IsInRange(a, b, num);
                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 5
            {
                Console.WriteLine("введите числа a, b, c:");

                Console.Write("a: ");
                int a;
                while (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.Write("Ошибка! Введите целое число a: ");
                }

                Console.Write("b: ");
                int b;
                while (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.Write("Ошибка! Введите целое число b: ");
                }

                Console.Write("c: ");
                int c;
                while (!int.TryParse(Console.ReadLine(), out c))
                {
                    Console.Write("Ошибка! Введите целое число c: ");
                }

                bool result = lab.IsEqual(a, b, c);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 6
            {
                Console.Write("введите число: ");
                int x;
                while (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Ошибка! Введите целое число: ");
                }

                int result = lab.Abc(x);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 7
            {
                Console.Write("введите число: ");
                int x;
                while (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Ошибка! Введите целое число: ");
                }

                bool result = lab.Is35(x);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 8
            {
                Console.WriteLine("введите числа x, y, z:");

                Console.Write("x: ");
                int x;
                while (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Ошибка! Введите целое число x: ");
                }

                Console.Write("y: ");
                int y;
                while (!int.TryParse(Console.ReadLine(), out y))
                {
                    Console.Write("Ошибка! Введите целое число y: ");
                }

                Console.Write("z: ");
                int z;
                while (!int.TryParse(Console.ReadLine(), out z))
                {
                    Console.Write("Ошибка! Введите целое число z: ");
                }

                int result = lab.Max3(x, y, z);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 9
            {
                Console.WriteLine("введите числа x, y:");

                Console.Write("x: ");
                int x;
                while (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Ошибка! Введите целое число x: ");
                }

                Console.Write("y: ");
                int y;
                while (!int.TryParse(Console.ReadLine(), out y))
                {
                    Console.Write("Ошибка! Введите целое число y: ");
                }

                int result = lab.Sum2(x, y);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 10
            {
                Console.Write("введите номер дня недели (1-7): ");
                int x;
                while (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Ошибка! Введите целое число: ");
                }

                string result = lab.Day(x);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 11
            {
                Console.Write("введите число: ");
                int x;
                while (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Ошибка! Введите целое число: ");
                }

                string result = lab.ListNums(x);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 12
            {
                Console.Write("введите число: ");
                int x;
                while (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Ошибка! Введите целое число: ");
                }

                string result = lab.Chet(x);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 13
            {
                Console.Write("введите число: ");
                int x;
                while (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Ошибка! Введите целое число: ");
                }

                int result = lab.NumLen(x);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 14
            {
                Console.Write("введите размер квадрата: ");
                int x;
                while (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Ошибка! Введите целое число: ");
                }

                Console.WriteLine("результат:");
                lab.Square(x);
            }

            // Задача 15
            {
                Console.Write("введите высоту треугольника: ");
                int x;
                while (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Ошибка! Введите целое число: ");
                }

                Console.WriteLine("результат:");
                lab.RightTriangle(x);
            }

            // Задача 16
            {
                Console.Write("введите размер массива: ");
                int n;
                while (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.Write("Ошибка! Введите целое число: ");
                }

                int[] arr = new int[n];

                Console.WriteLine("введите эл-ты массива:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"[{i}]: ");
                    while (!int.TryParse(Console.ReadLine(), out arr[i]))
                    {
                        Console.Write($"Ошибка! Введите целое число для [{i}]: ");
                    }
                }

                Console.Write("введите число х: ");
                int x;
                while (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Ошибка! Введите целое число х: ");
                }

                int result = lab.FindFirst(arr, x);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 17
            {
                Console.Write("введите размер массива: ");
                int n;
                while (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.Write("Ошибка! Введите целое число: ");
                }

                int[] arr = new int[n];

                Console.WriteLine("введите элементы массива:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"[{i}]: ");
                    while (!int.TryParse(Console.ReadLine(), out arr[i]))
                    {
                        Console.Write($"Ошибка! Введите целое число для [{i}]: ");
                    }
                }

                int result = lab.MaxAbs(arr);

                Console.WriteLine("результат:");
                Console.WriteLine(result);
            }

            // Задача 18
            {
                Console.Write("введите размер массива arr: ");
                int n;
                while (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.Write("Ошибка! Введите целое число: ");
                }

                int[] arr = new int[n];

                Console.WriteLine("введите элементы массива arr:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"[{i}]: ");
                    while (!int.TryParse(Console.ReadLine(), out arr[i]))
                    {
                        Console.Write($"Ошибка! Введите целое число для [{i}]: ");
                    }
                }

                Console.Write("введите размер массива ins: ");
                int m;
                while (!int.TryParse(Console.ReadLine(), out m))
                {
                    Console.Write("Ошибка! Введите целое число: ");
                }

                int[] ins = new int[m];

                Console.WriteLine("введите элементы массива ins:");
                for (int i = 0; i < m; i++)
                {
                    Console.Write($"[{i}]: ");
                    while (!int.TryParse(Console.ReadLine(), out ins[i]))
                    {
                        Console.Write($"Ошибка! Введите целое число для [{i}]: ");
                    }
                }

                Console.Write("введите позицию pos: ");
                int pos;
                while (!int.TryParse(Console.ReadLine(), out pos))
                {
                    Console.Write("Ошибка! Введите целое число: ");
                }

                int[] result = lab.Add(arr, ins, pos);

                Console.WriteLine("результат:");
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }

            // Задача 19
            {
                Console.Write("введите размер массива: ");
                int n;
                while (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.Write("Ошибка! Введите целое число: ");
                }

                int[] arr = new int[n];

                Console.WriteLine("введите элементы массива:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"[{i}]: ");
                    while (!int.TryParse(Console.ReadLine(), out arr[i]))
                    {
                        Console.Write($"Ошибка! Введите целое число для [{i}]: ");
                    }
                }

                int[] result = lab.ReverseBack(arr);

                Console.WriteLine("результат:");
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }

            // Задача 20
            {
                Console.Write("введите размер массива: ");
                int n;
                while (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.Write("Ошибка! Введите целое число: ");
                }

                int[] arr = new int[n];

                Console.WriteLine("введите элементы массива:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"[{i}]: ");
                    while (!int.TryParse(Console.ReadLine(), out arr[i]))
                    {
                        Console.Write($"Ошибка! Введите целое число для [{i}]: ");
                    }
                }

                Console.Write("введите число x: ");
                int x;
                while (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Ошибка! Введите целое число x: ");
                }

                int[] result = lab.FindAll(arr, x);

                Console.WriteLine("результат:");
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
        }
    }
}
