    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num, num1 = 0, num2 = 1, num3 = 0, i = 1;
            //    Console.Write("Ent num limit: ");
            //    num = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Fibonacci series is: ");
            //    Console.Write(num1);
            //    while (i < num)
            //    {
            //        num1 = num2;
            //        num2 = num3;
            //        num3 = num1 + num2;
            //        i = i + 1;
            //        Console.Write(" " + num3);
            //}
            //Console.Read();

            //int num;
            //Console.Write("Ent num: ");
            //num = Convert.ToInt32(Console.ReadLine());

            //if (num % 2 == 0)
            //{
            //    Console.Write(num + " is even number.");
            //}
            //else
            //{
            //    Console.Write(num + " is odd number.");
            //}
            //Console.Read();

            //int first, last, num, i, count;
            //Console.Write("Ent first intrvl: ");
            //first = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ent last intrvl: ");
            //last = Convert.ToInt32(Console.ReadLine());

            //for (num = first; num <= last; num++)
            //{
            //    count = 0;
            //    for (i = 1; i <= num; i++)
            //    {
            //        if (num % i == 0)
            //        {
            //            count++;
            //        }
            //    }
            //    if (count == 2)
            //    {
            //        Console.Write("Prime numbers are: " + num);
            //    }
            //}
            //Console.Read(); 

            //int a1,a2,a3,big;
            //Console.WriteLine("Ent 3 numbrs: ");
            //a1 = Convert.ToInt32(Console.ReadLine());
            //a2 = Convert.ToInt32(Console.ReadLine());
            //a3 = Convert.ToInt32(Console.ReadLine());

            //big=a1;
            //if(big<a2)
            //big=a2;
            //if(big<a3)
            //big=a3;
            //Console.Write("Biggest number is: " + big);
            //Console.Read();

            //int num, sum = 0, i = 0;
            //Console.Write("Ent num: ");
            //num = Convert.ToInt32(Console.ReadLine());

            //while (i <= num)
            //{
            //    sum = sum + i;
            //    i = i + 1;
            //}
            //Console.Write("Sum of N numbers is: " + sum);
            //Console.Read();

            int sum = 0, avg = 0, below = 0, above = 0;
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Numbers are: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + numbers[i];
            }
            avg = sum / 5;
            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] < avg)
                {
                    below++;
                }
                else
                {
                    above++;
                }
            }
            Console.WriteLine("Average of numbers is: " + avg);
            Console.WriteLine("Numbers above average are: " + above);
            Console.WriteLine("Numbers below average are: " + below);
            Console.ReadLine();
        }
    }
}
