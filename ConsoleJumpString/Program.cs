using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleJumpString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter the String:");
            string str = Console.ReadLine();
            char[] c = str.ToCharArray();
            char[] c1=new char[c.Length];
            int l = 0;
            for (int i=2;i<c.Length;i++)
            {
                c1[l++] = c[i];
            }
            string str2 = new string(c1);
            Console.WriteLine("The string is "+str+"\nString after alter is: "+str2);
            Console.ReadKey();
        }
    }
}
