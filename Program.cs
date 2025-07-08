using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Demo
{
    public abstract class Demo1
    {
        public abstract void fun1();
        public void fun2()
        {
            Console.WriteLine("This is concrete method of the abstract class");
        }
    }
    public class Demo2 : Demo1
    {
        public override void fun1()
        {
            Console.WriteLine("Abstract method implemented");
        }
    }
    internal class Program : Student
    {
        public Program()
        {
            Console.WriteLine("child constructor called");
        }
        public void test3()
        {
            base.test3();
            Console.WriteLine("Child Test3");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Demo2 d = new Demo2();
            p.test1();
            p.test2();
            p.test3();

            d.fun1();
            d.fun2();
            Console.ReadLine();
        }
    }
}
