using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Nested_Try_Catch
{
    class Student
    {
        public string StudentName;
    }
    class Program
    {
        private static void PrintStudentName(Student std)
        {
            if (std == null)
                throw new NullReferenceException("Student object is null.");

            Console.WriteLine(std.StudentName);
        }
        static void Main(string[] args)
        {
            Student std = null;

            try
            {
                try
                {
                    // following throws NullReferenceException
                    std.StudentName = "";
                }
                catch (InvalidOperationException innerEx)
                {
                    Console.WriteLine("Inner catch");
                }
            }
            catch
            {
                Console.WriteLine("Outer catch");
            }


            //throw exception exercise
            Student std2 = null;

            try
            {
                PrintStudentName(std2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
