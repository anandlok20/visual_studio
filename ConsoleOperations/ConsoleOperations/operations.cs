using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOperations
{
    class operations
    {
        int max, min;
        public operations() { Console.WriteLine("In Constructor.."); }

        public void print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i]+"\t");
            Console.WriteLine("\n");
        }
        public string maxMin(int[] arr)
        {
            max = arr[0];
            min = arr[0];
            for(int i=1;i<arr.Length;i++)
            {
                if (arr[i]>=max)
                {
                    max = arr[i];
                }
                if(arr[i]<min)
                {
                    min = arr[i];
                }
            }
            return "Maximum :" + max + "\nMinimum :" + min;
        }

        public int[] swapnum(int[] arr)
        {
            arr[0] = arr[0] + arr[arr.Length-1];
            arr[arr.Length - 1] = arr[0] - arr[arr.Length - 1];
            arr[0] = arr[0] - arr[arr.Length - 1];
            return arr;
        }

        public void primeno(int[] arr)
        {
            int j, p;
            for (int i = 0; i < arr.Length; i++)
            {
                j = 2;
                p = 1;
                while (j < arr[i])
                {
                    if (arr[i] % j == 0)
                    {
                        p = 0;
                        break;
                    }
                    j++;
                }
                if (p == 1)
                {
                    Console.Write(arr[i] + "\t");
                }
            }
        }

        public void intcount(string str)
        {
            char[] c = str.ToCharArray();
            int count=0;
            for (int i = 0; i < c.Length; i++)
            {
                if(c[i]>'0' && c[i]<'9')
                {
                    count++;
                }
            }
            Console.WriteLine("No of integer: "+count);
        }

        public StringBuilder upplow(string str)
        {
            StringBuilder sb = new StringBuilder(str);
            for (int i = 0; i < sb.Length; i++)
            {
                if(sb[i]>='a' && sb[i]<='z')
                {
                    sb[i] = (char)(sb[i] - 32);
                }
                else if (sb[i] >= 'A' && sb[i] <= 'Z')
                {
                    sb[i] = (char)(sb[i] + 32);
                }
            }
            return sb;
        }

        public void posneg(int[] a)
        {
            int pos=0, neg=0;
            for (int i = 0; i < a.Length; i++)
            {
                if((a[i])>0)
                {
                    pos++;
                }
                if ((a[i]) < 0)
                {
                    neg++;
                }
            }
            Console.WriteLine("\nno of +ve integer: "+pos+"\nno of -ve integer: "+neg);
        }

        public int[] swapmm(int[] a)
        {
            maxMin(a);
            int p1=0, p2=0, temp=0;
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] == max)
                    p1 = i;
                if (a[i] == min)
                    p2 = i;
            }
            temp = a[p1];
            a[p1] = a[p2];
            a[p2] = temp;
            return a;
        } 

        public void palin(string s)
        {
            string r=null;
            for (int i = s.Length - 1; i >= 0; i--) 
            {
                r += s[i].ToString();
            }
            if (r == s)  
            {
                Console.WriteLine("String is Palindrome \norignal string :" + s + "\nreverse string is :" + r);
            }
            else
            {
                Console.WriteLine("String is not Palindrome \norignal string :"+s+"\nreverse string is :"+r);
            }
        }
    }
}