using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Employee
    {
        public int empid { get; set; }
        public string ename { get; set; }
        public string city { get; set; }
    }

    class BaseClass
    {
        public void method1()
        {

        }
    }
    class DerviedClass:BaseClass
    {

    }
    class Program
    {
        private int hour;
        public int hours
        {
            get
            {
                return hour;
            }
            set
            {
                hour = value;
            }


        }
       

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.hours = 12;
        }
    }
}
