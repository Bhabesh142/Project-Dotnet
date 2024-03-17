using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 object1 = new Class1();
            Class1 object2 = new Class1();
            Console.WriteLine(object1.color);
            Console.Write(object2.maxspeed);
            //Console.Write(object2.ShowMessage());
            Console.Read();
        }
    }
}
