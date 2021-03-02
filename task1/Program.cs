using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 0;
            Console.Write("Input a natural number:");
            number = Convert.ToInt64(Console.ReadLine());
            double sum = 1; 
            for (double i = 1; i <= number; i++)
            {
                sum = sum * Math.Pow(i,i-1);
            }
            Console.WriteLine("Result:"+sum);
        }
    }
}
