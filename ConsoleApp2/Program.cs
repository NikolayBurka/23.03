using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //сортировка n по возрастанием
            //int[] array = { -5, 20, -10, 2, 8 };
            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] > array[j])
            //        {
            //            int p = array[j]; array[i] = array[j]; array[j] = p;
            //        }
            //    }
            //}
            //foreach (int elem in array)
            //{
            //    Console.WriteLine($"{elem}");
            //}

            int[] array = { 1, -2, 3, 4, -5, 6, -7, 8, 9, 10, -11, };
            foreach (int elem in array)
                {
                Console.WriteLine();
                   Console.WriteLine($"{elem}");
                }
            Array.Sort( array );
            
            Array.Reverse( array );
            Console.ReadLine();
        }
    }
}