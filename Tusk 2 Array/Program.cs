using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusk_2_Array
{
    internal class Program
    {
        static void Change_Array(ref int[] array)
        {
            int Middle = array.Length / 2;
            for(int i = 0; i < Middle; i++)
            {
                int Number = array[i];
                array[i] = array[array.Length - Middle + i];
                array[array.Length - Middle + i] = Number;
            }
            
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Введите длину массива: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] vs = new int[N];
            for (int i = 0; i < N; i++)
            {
                vs[i] = random.Next(0,500);
            }
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(vs[i] + " ");
            }
            Console.WriteLine("\n");

            Change_Array(ref vs);

            Console.WriteLine("Маассив после перестановки половинок: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(vs[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
