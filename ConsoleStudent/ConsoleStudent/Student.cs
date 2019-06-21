using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStudent
{
    class Student
    {
        private readonly int studentId;
        private string studentName;
        private DateTime studentDOB;
        private string studentCity;
        public static int counter = 1000;
        static int age;

        public Student() { }
        public Student(string studentName, DateTime studentDOB, string studentCity)
        {
            this.studentId = ++Student.counter;
            this.studentName = studentName;
            this.studentDOB = studentDOB;
            this.studentCity = studentCity;
        }

        public int StudentId
        {
            get
            {
                return this.studentId;
            }
        }

        public string StudentName
        {
            get
            {
                return this.studentName;
            }

            set
            {
                this.studentName = value;
            }
        }

        public DateTime StudentDOB
        {
            get
            {
                DateTime dtnow = DateTime.Now;
                TimeSpan t = dtnow - this.studentDOB;
                age = ((int)t.TotalHours) / 7;
                age = age / 52;
                Console.WriteLine(age);
                return this.studentDOB;
            }

            set
            {
                this.studentDOB = Convert.ToDateTime(value);
            }
        }

        public string StudentCity
        {
            get
            {
                return this.studentCity;
            }

            set
            {
                this.studentCity = value;
            }
        }

        public string GetDetails()
        {
            return "Id: "+StudentId+"Name: "+StudentName+"Age: "+age+"City: "+StudentCity;
        }
    }

}
