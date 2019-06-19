using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean x = true;
            while(x)
            {
                Console.WriteLine("1.ADD\n2.SUB\n3.MUL\n4.DIV\n5.Exit");
                int c = Convert.ToInt32(Console.ReadLine());
                int a, b;
                int res;
                Console.WriteLine("Result is: ");
                switch (c)
                {
                    case 1:
                        Console.WriteLine("Enter num1 value:");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter num2 value:");
                        b = Convert.ToInt32(Console.ReadLine());
                        res = a + b;
                        Console.WriteLine("sum :" + res);
                        break;
                    case 2:
                        Console.WriteLine("Enter num1 value:");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter num2 value:");
                        b = Convert.ToInt32(Console.ReadLine());
                        res = a - b;
                        Console.WriteLine("sum :" + res);
                        break;
                    case 3:
                        Console.WriteLine("Enter num1 value:");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter num2 value:");
                        b = Convert.ToInt32(Console.ReadLine());
                        res = a * b;
                        Console.WriteLine("sum :" + res);
                        break;
                    case 4:
                        Console.WriteLine("Enter num1 value:");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter num2 value:");
                        b = Convert.ToInt32(Console.ReadLine());
                        if(b==0)
                        {
                            Console.WriteLine("Divide by zero error!!");
                        }
                        else
                        {
                            res = a / b;
                            Console.WriteLine("sum :" + res);
                        }
                        break;
                    case 5:
                        x = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option!!");
                        break;
                }
            }           
        }
    }
}
