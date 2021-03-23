using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp6;
using ClassLibrary1;
namespace ConsoleApp5
{
  
    class Program
    {
        public static void method1()
        {
            Console.WriteLine("this is static method");
        }
        public void method2()
        {
            Console.WriteLine("this is non static method");
        }
        public int cal(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            // Module1.Main();

            Class1 objclass = new Class1();
            objclass.method();
            Program obj = new Program();//creating object
            obj.cal(12, 12);
            obj.method2();
            Program.method1();//using class name
            Console.WriteLine("Hi .net ");
            Console.WriteLine("value {0}", obj.cal(12, 12).ToString());
            Console.ReadLine();
        }
    }
}
