using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusk_1_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количесво элементов в первом массиве: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количесво элементов во втором массиве: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int k = n + 1;
            while (k>n-1)
            {
                Console.Write("Введите позицию, с которой будет вставка в первый массив: ");
                k = Convert.ToInt32(Console.ReadLine()) - 1;

            }
            Random r = new Random();
            int[] Array1 = new int[n];
            int[] Array2 = new int[m];
            for (int i = 0; i < n; i++)
            {
                Array1[i] = r.Next(0, 500);
                Console.Write(Array1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                Array2[i] = r.Next(0, 500);
                Console.Write(Array2[i] + " ");
            }
            Console.WriteLine();

            Array.Resize(ref Array1, n+m);

            for (int i = 0; i < n-k; i++)
            {
                Array1[i+m+k] = Array1[k+i];
            }
            Array.Copy(Array2, 0, Array1, k, m);
            for(int i = 0; i < Array1.Length; i++)
            {
                Console.Write(Array1[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
