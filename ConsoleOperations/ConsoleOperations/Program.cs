using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean loop = true;
            Console.WriteLine("\n(For string operations enter size 0)\nEnter the size of the array");
            int s = Convert.ToInt32(Console.ReadLine());
            operations op = new operations();
            int[] array = new int[s];
            Console.WriteLine("Enter Elements:");
            for (int i = 0; i < array.Length; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                array[i] = a;
            }
            string print;
            while (loop)
            {
                Console.WriteLine("\nEnter your choice\n1.Find Maximum and Minimum\n2.Swaping first and last number\n3.Check Prime\n4.Find no of words in a given string\n5.Find count of integer in a given string\n6.Convert the given string into its opposite case\n7.Find count of positive and negative integer\n8.Find highest and lowest and swap positions\n9.Find given string is palindrome\n10.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        print = op.maxMin(array);
                        Console.WriteLine(print);
                        break;
                    case 2:
                        Console.WriteLine("The orignal array is:");
                        op.print(array);
                        Console.WriteLine("The swapped array is:");
                        int[] a = op.swapnum(array);
                        op.print(a);
                        break;
                    case 3:
                        Console.WriteLine("The orignal array is:");
                        op.print(array);
                        Console.WriteLine("The prime no array is:");
                        op.primeno(array);
                        break;
                    case 4:
                        Console.WriteLine("Enter a String");
                        string str = Console.ReadLine();
                        string[] str1 = str.Split(' ');
                        Console.WriteLine("No of words in a given string:");
                        Console.Write(str1.Length);
                        break;
                    case 5:
                        Console.WriteLine("Enter a String");
                        string str2 = Console.ReadLine();
                        Console.WriteLine("No of integer's in the given string:");
                        op.intcount(str2);
                        break;
                    case 6:
                        Console.WriteLine("Enter a String");
                        string str3 = Console.ReadLine();
                        Console.WriteLine("No of integer's in the given string:");
                        StringBuilder sb = op.upplow(str3);
                        Console.WriteLine(sb);
                        break;
                    case 7:
                        Console.WriteLine("The orignal array is:");
                        op.print(array);
                        op.posneg(array);
                        break;
                    case 8:
                        Console.WriteLine("The orignal array is:");
                        op.print(array);
                        int[] res = op.swapmm(array);
                        Console.WriteLine("The swaped array is:");
                        op.print(res);
                        break;
                    case 9:
                        Console.WriteLine("Enter a String");
                        string str4 = Console.ReadLine();
                        op.palin(str4);
                        break;
                    case 10:
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input!!");
                        break;
                }
            }
        }
    }
}
