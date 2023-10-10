using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusk_4_Array
{
    internal class Program
    {
        static int IndexOf(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int Permission = 0;
            int n = 0;
            int m = 0;
            int k = 0;
            while (Permission < 2)
            {
                while (true)
                {
                    if (Permission == 0)
                    {
                        Console.Write("Введите количество рядов: ");
                    }
                    else if (Permission == 1)
                    {
                        Console.Write("Введите количество мест в ряду: ");
                    }
                    
                    string text = Console.ReadLine();
                    if (int.TryParse(text, out int number))
                    {
                        if (Permission == 0)
                        {
                            n = Convert.ToInt32(text);
                        }
                        else if (Permission == 1)
                        {
                            m = Convert.ToInt32(text);
                        }
                        Console.WriteLine();
                        break;
                    }
                    Console.WriteLine("Не удалось распознать число, попробуйте еще раз!\n");
                }
                Permission++;
            }
            int[,] Matrix = new int[n, m];
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write("Введите 0 или 1 в Matrix[{0}][{1}]: ", i, j);
                    Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }
            }
            Console.Write("Введите количество билетов на соседние места в ряду: ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Входные данные \n{0} {1}", n, m);
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(k);
            int[] Array = new int[m];
            if (k > m)
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    Array[i] = 0;
                }
                Console.WriteLine("Выходные данные\n{0}", 0);
            }
            else
            {
                int Count = 0;
                int Count1 = 0;
                for (int i = 0; i < n; i++)
                {
                    for(int j = 0; j < m-1; j++)
                    {
                        if (Matrix[i,j] == 0 && Matrix[i, j+1] == Matrix[i, j])
                        {
                            Array[Count] = -1;
                            Count1++;
                        }
                    }
                    Count++;
                }
                if (Count1 > 0)
                {
                    Console.WriteLine("Выходные данные\n{0}", 1 + IndexOf(Array, Array.Min()));
                }
                else
                {
                    Console.WriteLine("Выходные данные\n{0}", 0);
                }
            }
            Console.ReadKey();
        }
    }
}
