using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student sd = new Student();
            sd.StudentName = "Anand";
            sd.StudentDOB = Convert.ToDateTime("03/03/1994");
            sd.StudentCity = "Pune";

            string details = sd.GetDetails();
            Console.WriteLine(details);
            Console.ReadKey();
        }
    }
}
