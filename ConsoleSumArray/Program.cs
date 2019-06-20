using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter the size of the array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("\nEnter the element of the array:");
            for(int i=0;i<array.Length;i++)
            {
                int ele = Convert.ToInt32(Console.ReadLine());
                array[i] = ele;
            }
            Console.WriteLine("\nThe array Elements are:");
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+"\t");
                sum = sum + array[i];
            }
            Console.WriteLine("\nThe sum of the array:"+sum);
            Console.ReadKey();
        }
    }
}
