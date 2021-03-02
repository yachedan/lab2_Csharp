using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            while(i>0)
            {
                System.Threading.Thread.Sleep(800);
                if(i!=1)
                    Console.WriteLine(i+" green bottles hanging on the wall,\n"+
                                    i+" green bottles hanging on the wall,\n"+
                                    "And if one green bottle should accidentaly fall,\n"+
                                    "There'll be "+(i-1)+" green bottles hanging on the wall.");
                else
                    Console.WriteLine(i+" green bottle hanging on the wall,\n"+
                                    i+" green bottle hanging on the wall,\n"+
                                    "And if one green bottle should accidentaly fall,\n"+
                                    "There'll be "+(i-1)+" green bottle hanging on the wall.");
                Console.WriteLine();
                i--;
            }
        }
    }
}
