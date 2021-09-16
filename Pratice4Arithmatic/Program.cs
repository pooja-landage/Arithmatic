using System;

namespace Pratice4Arithmatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a, b, c;

            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of a" + a);
            
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b" + b);


            a = 34;
            b = 43;

            // Addition
             c = a + b;
             a += b;
             Console.WriteLine("The sum of a and b is " + c);
            float div = 24;
            float result = div / 12;
            Console.WriteLine("The division is " + result);




        }
    }
}
