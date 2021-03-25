using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{   
    class Program
    {
        public void method1()
        {

        }
        public int method1(int a,int b)
        {
            return a + b;
        }
        public string method1(string name)
        {
            return name;
        }

        static void Main(string[] args)
        {
            Program Obj1 = new Program();
            Obj1.method1();
           
           
            Console.WriteLine(Obj1.method1("Raj"));
            Console.WriteLine("value addition {0}", Obj1.method1(12, 11));


            Console.ReadLine();
        }
    }
}
