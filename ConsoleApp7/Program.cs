using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    /// <summary>
    /// Polymorphism with new keyword hide and show method
    /// </summary>
    public class BaseClass
    {
        public virtual void CallUp()
        {
            Console.WriteLine("Base Class Call");
        }
        public virtual void DoWork() { }
        public virtual int WorkProperty
        {
            get { return 0; }
        }
    }
    public class DerivedClass : BaseClass
    {
        public new   void CallUp()
        {
            Console.WriteLine("Derived Class Call");
        }
        public new   void DoWork() { }
        public new  int WorkProperty
        {
            get { return 0; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass B = new DerivedClass();
            B.DoWork();  // Calls the new method.
            B.CallUp();
           
            BaseClass A = (BaseClass)B;//typcast object or refrance
            A.DoWork();  // Calls the old method.
            A.CallUp();
           
           

            Console.ReadLine();
        }
    }
}
