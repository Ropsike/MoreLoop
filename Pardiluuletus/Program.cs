using System;

namespace Quack
{
    class Program
    {
        static void Main(string[] args)
        {
            string ducks;
            for(int i = 5; i > 0; i--)
            {
                if(i == 1)
                {
                    ducks = "duck";
                }
                else
                {
                    ducks = "ducks";
                }
                Console.WriteLine($"{i} little {ducks} went out one day");
                Console.WriteLine("Over the hill and far away");
                Console.WriteLine("Mother duck said, \"Quack, quack, quack \" ");
                
                if(i > 1)
                {
                 
                    Console.WriteLine($"But only {i - 1} little {ducks} came back");
                }
                
                Console.WriteLine();
            }

            
        }
    }
}