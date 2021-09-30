using System;

namespace NumberGeneratorGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 1001);
            bool LoopActive = true;
            while (LoopActive)
            {
                Console.WriteLine("Vali number 1-1000");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (cpuRandom == userNumber)
                {
                    Console.WriteLine("Palju õnne, oled võitnud!");
                    break;
                    LoopActive = false;
                }
                else
                {
                    Console.WriteLine("Prooi uuesti!");
                }
                Console.WriteLine("Kena päeva!");
            }
            
        }
    }
}
