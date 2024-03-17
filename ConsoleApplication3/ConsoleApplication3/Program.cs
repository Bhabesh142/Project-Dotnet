using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
        //    int year;
        //    Console.Write("Ent the year :");
        //    year = Convert.ToInt32(Console.ReadLine());
        //    if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
        //        Console.WriteLine(year + " is a Leap year");
        //    else
        //        Console.WriteLine(year + " is not a Leap year");
        //    Console.Read();


            //int month;
            //Console.Write("Ent month num in betn(1 - 12): ");
            //month = Convert.ToInt32(Console.ReadLine());

            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("January");
            //        break;
            //    case 2:
            //        Console.WriteLine("February");
            //        break;
            //    case 3:
            //        Console.WriteLine("March");
            //        break;
            //    case 4:
            //        Console.WriteLine("April");
            //        break;
            //    case 5:
            //        Console.WriteLine("May");
            //        break;
            //    case 6:
            //        Console.WriteLine("June");
            //        break;
            //    case 7:
            //        Console.WriteLine("July");
            //        break;
            //    case 8:
            //        Console.WriteLine("August");
            //        break;
            //    case 9:
            //        Console.WriteLine("September");
            //        break;
            //    case 10:
            //        Console.WriteLine("October");
            //        break;
            //    case 11:
            //        Console.WriteLine("November");
            //        break;
            //    case 12:
            //        Console.WriteLine("December");
            //        break;
            //    default:
            //        Console.WriteLine("It is not a month number.");
            //        break;
            //}
            //Console.Read();

            int num, exponent, power = 1, i = 1;
            Console.Write("Ent base num: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ent expont num: ");
            exponent = Convert.ToInt32(Console.ReadLine());

            while (i <= exponent)
            {
                power = power * num;
                i++;
            }
            Console.Write("Power of num: " + power);
            Console.ReadLine();

            //int num, index;
            //Console.Write("Ent mul num: ");
            //num = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ent index num: ");
            //index = Convert.ToInt32(Console.ReadLine());

            //while(num==index)
            //{
            //    num = num * index;
            //}
            //Console.Write("Multiplication of number is: " + power);
            //Console.ReadLine();
        }
    }
}
