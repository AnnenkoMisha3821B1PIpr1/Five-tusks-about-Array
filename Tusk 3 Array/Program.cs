using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusk_3_Array
{
    internal class Program
    {
        static int[] Iinitializing_An_Array(int Count_Numbers)
        {

            int[] array = new int[Count_Numbers];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 500);
            }
            return array;
        }

        static void Print(int[] array)
        {
            Console.WriteLine("Вывод значений массива: ");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n");
        }

        static void Summ_Result(int[] array1, int[] array2)
        {
            if (array1.Length == array2.Length)
            {
                int[] array3 = new int[array1.Length];
                Console.WriteLine("Полученный результат в результате поэлементного сложения: ");
                for (int i = 0; i < array1.Length; i++)
                {
                    array3[i] = array1[i] + array2[i];
                }
                Print(array3);
            }
            else
            {
                Console.WriteLine("Длины массивов не совпадают, чтобы сложить их поэлементно!\n");
            }

        }

        static void Print_Before_Multiplication(int[] array)
        {
            Console.WriteLine("Массив перед умножением:");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n");
        }

        static void Print_After_Multiplication(int[] array)
        {
            Console.WriteLine("Массив после умножения:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n");
        }

        static void Multiplication_Array(int[] array, int N)
        {
            Print_Before_Multiplication(array);
            int[] vs = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                vs[i] = array[i] * N;
            }
            Print_After_Multiplication(vs);
        }

        static void Print_Common(int[] vs, bool Flag)
        {
            if(Flag == true)
            {
                Console.Write("Общие элементы: ");
                for (int i = 0; i < vs.Length; i++)
                {
                    Console.Write(vs[i] + " ");
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Общих элементов нет\n");
            }

        }

        static void Finding_Common_Elements(int[] array1, int[] array2)
        {
            bool flag = false;
            int CountCommon = 0;
            int[] vs = new int[CountCommon];
            for(int i = 0; i < array1.Length; i++)
            {
                for(int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        bool flag1 = false;
                        for (int k = 0; k < vs.Length; k++)
                        {
                            if (vs[k] == array1[i])
                            {
                                flag = true;
                            }
                        }
                        if (flag1 == false)
                        {
                            CountCommon++;
                            Array.Resize(ref vs, CountCommon);
                            vs[CountCommon - 1] = array1[i];
                        }
                        
                    }
                }
            }
            if(CountCommon != 0)
            {
                flag = true;
            }
            Print_Common(vs, flag);
        }

        static void Sort_Decreasing_Array(int[] array)
        {
            int Number = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j + 1] > array[j])
                    {
                        Number = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = Number;
                    }
                }
            }
            Console.WriteLine("После сортировки: ");
            Print(array);
        }

        static void PrintF(int[] array)
        {
            Console.WriteLine("Исходный массив:");
            for(int i = 0; i < array.Length; ++i)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n");
        }

        static void Max_Min_AverageValue(int[] array)
        {
            PrintF(array);
            int Max = 0;
            int Min = Int32.MaxValue;
            float Count = 0;
            for(int i = 0; i < array.Length;i++)
            {
                if (array[i] > Max)
                {
                    Max = array[i];
                }
                if (array[i] < Min)
                {
                    Min = array[i];
                }
                Count = Count + array[i];
            }
            float Average = Count / array.Length;
            Console.WriteLine("Максимальное значение в массиве: {0}\n\nМинимальное значение в массиве: {1}\n\nСреднее значение в массиве: {2}\n", Max, Min, Average);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1.\nВвод массивов\n");

            Console.Write("Введите длину первого массива: ");
            int N1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] Array1;
            Array1 = Iinitializing_An_Array(N1);
            Print(Array1);

            Console.Write("Введите длину второго массива: ");
            int N2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] Array2;
            Array2 = Iinitializing_An_Array(N2);
            Print(Array2);

            Console.WriteLine("2.\nПоэлементное сложение массивов\n");
            
            Summ_Result(Array1,Array2);

            Console.WriteLine("3.\nУмножение элементов двух массивов на число\n");
            
            Console.Write("Введите число на которое хотите умножить элементы первого и второго массива: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Multiplication_Array(Array1, Number);
            Multiplication_Array(Array2, Number);

            Console.WriteLine("4.\nРассмотрим два массива на наличие общих элементов\n");
            
            Finding_Common_Elements(Array1 ,Array2);

            Console.WriteLine("5.\nВывод массивов\n");
            Console.WriteLine("Первый массив:");
            Print(Array1);
            Console.WriteLine("Второй массив:");
            Print(Array2);

            Console.WriteLine("6.\nСортровка по убыванию в массивах\n");
            Console.WriteLine("Первый массив:");
            Print(Array1);
            Sort_Decreasing_Array(Array1);
            Console.WriteLine("Второй массив:");
            Print(Array2);
            Sort_Decreasing_Array(Array2);

            Console.WriteLine("7.\nПоиск максимума, минимума и среднего значения в массивах");
            Console.WriteLine("Первый массив:");
            Max_Min_AverageValue(Array1);
            Console.WriteLine("Второй массив:");
            Max_Min_AverageValue(Array2);
            
            Console.ReadKey();
        }
    }
}
