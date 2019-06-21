using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArraysElementMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter the size of the array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[size];
            Console.WriteLine("\nEnter the element of the 1st array:");
            for (int i = 0; i < array1.Length; i++)
            {
                int ele = Convert.ToInt32(Console.ReadLine());
                array1[i] = ele;
            }
            int[] array2 = new int[size];
            Console.WriteLine("\nEnter the element of the 2nd array:");
            for (int i = 0; i < array2.Length; i++)
            {
                int ele = Convert.ToInt32(Console.ReadLine());
                array2[i] = ele;
            }
            Console.WriteLine("\nThe array Elements are:");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + "\t");
            }
            Console.WriteLine("\nThe array Elements are:");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + "\t");
            }
            Console.WriteLine("\nSame elements in the array's are:");
            for(int i=0;i<array1.Length;i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if(array1[i]==array2[j])
                    {
                        Console.WriteLine(array1[i]);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
