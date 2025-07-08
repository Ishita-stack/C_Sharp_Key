using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Demo
{
    public class Student
    {
        public Student()
        {
            Console.WriteLine("Parent constructor Called");
        }
        public void test1()
        {
            Console.WriteLine("Test1");
        }
        public void test2()
        {
            Console.WriteLine("Test2");
        }
        public void test3()
        {
            Console.WriteLine("Parent Test3");
        }
    }
}
