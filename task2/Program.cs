using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double precision = 0;
            Console.WriteLine("Input sum precision: ");
            precision = Convert.ToDouble(Console.ReadLine());
            double sum = 0;
            long x = 1;
            long k = 0;
            int index = 0;
            bool flag = false;
            while(k<int.MaxValue)
            {
                for(x = 1; x<=5; x++)
                {
                    index++;
                    double numerator = Math.Pow(-1, k) * Math.Pow(x + 1, k - 1);
                    double denominator = 1;
                    for (int i = 1; i <= x; i++)
                        denominator = denominator * (k + i);
                    if((sum + numerator / denominator) < double.MaxValue 
                    && (sum + numerator / denominator) > double.MinValue)
                        sum = sum + numerator / denominator;
                    else
                    {
                        flag = true;
                        break;
                    }
                        
                    Console.WriteLine("Iteration "+index+": "+sum);
                    if(Math.Abs(sum)<=precision)
                        break;
                }
            k++;
            if(Math.Abs(sum)<=precision||flag)
                break;
            }
            Console.WriteLine("Result: "+sum);
        }
    }
}
