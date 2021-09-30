using System;

namespace Pela
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 11);
            int i = 0;
              while(i < 3)
              {
                Console.WriteLine("Vali number 1-10");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                
                if(userNumber == cpuRandom)
                {
                    Console.WriteLine("Sa võitsid!");
                    //break
                        i = 3;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Proovi uuesti. {3 - i} katset on jäänud");   
                }
                
                
              }
        }
    }
}
