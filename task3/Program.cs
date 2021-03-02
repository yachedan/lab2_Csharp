using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] x = new double [10];
            double[] y = new double [10];
            string[] results = new string [10];
            double R = 5;
            Console.WriteLine("Input 10 coordinates(x,y):");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + "x: ");
                x[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write(i + "y: ");
                y[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                if (x[i] >= 0)
                {
                    double distance;
                    distance = Math.Sqrt(x[i] * x[i] + y[i] * y[i]);
                    if (distance <= R)
                        results[i] = "HIT";
                    else
                        results[i] = "NO HIT";
                }
                if (x[i] < 0)
                {
                   if(y[i]<x[i] || -y[i]<x[i] && Math.Abs(y[i])<=R && x[i]>=-5)
                        results[i] = "HIT";
                    else
                        results[i] = "NO HIT";
                }
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("| x | y |   Results    |");
            Console.WriteLine("------------------------");
            for(int i = 0; i < 10; i++)
            {
                Console.Write("| "+x[i]+" | "+y[i]+" |   "+results[i]);
                if(results[i]=="NO HIT")
                    Console.WriteLine("   |");
                else
                    Console.WriteLine("      |");
            }
            Console.WriteLine("------------------------");
        }
    }
}
