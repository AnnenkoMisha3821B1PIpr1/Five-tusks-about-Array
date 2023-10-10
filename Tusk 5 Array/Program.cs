using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusk_5_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Permission = 0;
            int Size_String_Array = 0;
            while (Permission < 1)
            {
                while (true)
                {
                    Console.Write("Введите размерность матриц: ");
                    string text = Console.ReadLine();
                    if (int.TryParse(text, out int number))
                    {
                        Size_String_Array = Convert.ToInt32(text);
                        Console.WriteLine();
                        break;
                    }
                    Console.WriteLine("Не удалось распознать число, попробуйте еще раз!\n");
                }
                Permission++;
            }
            int Size = Size_String_Array * Size_String_Array;
            int[] Matrix1 = new int[Size];
            int[] Matrix2 = new int[Size];
            int[] Matrix3 = new int[Size];

            // Заполнение первой матрицы
            Random random = new Random();
            for (int i = 0; i < Matrix1.Length; i++)
            {
                Matrix1[i] = random.Next(0, 101);
            }

            // Заполнение второй матрицы
            for (int i = 0; i < Matrix2.Length; i++)
            {
                Matrix2[i] = random.Next(0, 101);
            }

            Console.WriteLine("Первая матрица: ");
            for (int i = 0; i < Matrix1.Length; i++)
            {
                if ((i + 1) % Size_String_Array == 0)
                {
                    Console.WriteLine(Matrix1[i]);
                }
                else
                {
                    Console.Write(Matrix1[i] + "\t");
                }
            }

            Console.WriteLine("\nВторая матрица: ");
            for (int i = 0; i < Matrix2.Length; i++)
            {
                if ((i + 1) % Size_String_Array == 0)
                {
                    Console.WriteLine(Matrix2[i]);
                }
                else
                {
                    Console.Write(Matrix2[i] + "\t");
                }
            }

            // Умножение матриц и заполнение 3 матрицы
            for (int i = 0; i < Size_String_Array; i++)
            {
                for (int j = 0; j < Size_String_Array; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < Size_String_Array; k++)
                        sum = sum + Matrix1[i * Size_String_Array + k] * Matrix2[k * Size_String_Array + j];
                    Matrix3[i * Size_String_Array + j] = sum;
                }
            }

            // Вывод результата
            Console.WriteLine("\nРезультат перемножения матриц: ");
            for (int i = 0; i < Matrix3.Length; i++)
            {
                if ((i + 1) % Size_String_Array == 0)
                {
                    Console.WriteLine(Matrix3[i]);
                }
                else
                {
                    Console.Write(Matrix3[i] + "\t");
                }
            }

            Console.ReadKey();
        }
    }
}
