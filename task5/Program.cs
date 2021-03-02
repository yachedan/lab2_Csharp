using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = 0;
            Console.WriteLine("Input weight of one grain(gram): ");
            weight = Convert.ToDouble(Console.ReadLine());
            double sum = 0;
            for(int i = 1; i<65;i++)
            {
                sum +=Math.Pow(2,i);
                Console.WriteLine(i+" cell: "+Math.Pow(2,i));
            }
            Console.WriteLine("Overall: "+sum+"\n"+"Weight = "+sum*weight/1000000+" tons");
        }
    }
}
