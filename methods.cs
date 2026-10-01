using System;

namespace Lab1
{
    public class Methods
    {
        // Задача 1
        public double Fraction(double x)
        {
            return x - (int)x;
        }

        // Задача 2
        public int CharToNum(char x)
        {
            return x - '0';
        }

        // Задача 3
        public bool Is2Digits(int x)
        {
            return (x >= 10 && x <= 99) || (x <= -10 && x >= -99);
        }

        // Задача 4
        public bool IsInRange(int a, int b, int num)
        {
            return (num >= a && num <= b) || (num >= b && num <= a);
        }

        // Задача 5
        public bool IsEqual(int a, int b, int c)
        {
            return a == b && b == c;
        }

        // Задача 6
        public int Abc(int x)
        {
            if (x < 0)
            {
                return -x;
            }

            return x;
        }

        // Задача 7
        public bool Is35(int x)
        {
            if (x % 3 == 0 && x % 5 == 0)
            {
                return false;
            }

            return x % 3 == 0 || x % 5 == 0;
        }

        // Задача 8
        public int Max3(int x, int y, int z)
        {
            int max = x;

            if (y > max)
            {
                max = y;
            }

            if (z > max)
            {
                max = z;
            }

            return max;
        }

        // Задача 9
        public int Sum2(int x, int y)
        {
            int sum = x + y;

            if (sum >= 10 && sum <= 19)
            {
                return 20;
            }

            return sum;
        }

        // Задача 10
        public string Day(int x)
        {
            switch (x)
            {
                case 1:
                    return "понедельник";
                case 2:
                    return "вторник";
                case 3:
                    return "среда";
                case 4:
                    return "четверг";
                case 5:
                    return "пятница";
                case 6:
                    return "суббота";
                case 7:
                    return "воскресенье";
                default:
                    return "это не день недели";
            }
        }

        // Задача 11
        public string ListNums(int x)
        {
            string result = "";
            for (int i = 0; i <= x; i++)
            {
                result = result + i + " ";
            }

            return result;
        }

        // Задача 12
        public string Chet(int x)
        {
            string result = "";
            for (int i = 0; i <= x; i = i + 2)
            {
                result = result + i + " ";
            }

            return result;
        }

        // Задача 13
        public int NumLen(long x)
        {
            int length = 0;

            while (x != 0)
            {
                x /= 10;
                length++;
            }

            return length;
        }

        // Задача 14
        public void Square(int x)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        // Задача 15
        public void RightTriangle(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= x - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        // Задача 16
        public int FindFirst(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }

            return -1;
        }

        // Задача 17
        public int MaxAbs(int[] arr)
        {
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) > Math.Abs(max))
                {
                    max = arr[i];
                }
            }

            return max;
        }

        // Задача 18
        public int[] Add(int[] arr, int[] ins, int pos)
        {
            int[] result = new int[arr.Length + ins.Length];

            for (int i = 0; i < pos; i++)
            {
                result[i] = arr[i];
            }

            for (int i = 0; i < ins.Length; i++)
            {
                result[pos + i] = ins[i];
            }

            for (int i = pos; i < arr.Length; i++)
            {
                result[i + ins.Length] = arr[i];
            }

            return result;
        }

        // Задача 19
        public int[] ReverseBack(int[] arr)
        {
            int[] result = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[arr.Length - 1 - i];
            }

            return result;
        }

        // Задача 20
        public int[] FindAll(int[] arr, int x)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    count++;
                }
            }

            int[] result = new int[count];
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    result[index] = i;
                    index++;
                }
            }

            return result;
        }
    }
}
