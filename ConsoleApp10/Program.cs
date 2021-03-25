using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class BaseClass
    {
        public virtual void method()
        {
            Console.WriteLine("this is baseclass method");
        }
        public virtual string name(string name)
        {
            return name;
        }
    }
    public class DervieClass:BaseClass
    {
        public override void method()
        {
            Console.WriteLine("this is Dervide class method");
        }
        public new string name(string name)
        {
            return name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();
            baseClass.method();//base class method
            DervieClass dervieClass = new DervieClass();

            BaseClass baseClass1 = (DervieClass)dervieClass;//typecasting 
            baseClass1.method();
            Console.WriteLine(  baseClass.name("Raj"));//intended hiding 
            Console.ReadLine();

        }
    }
}
