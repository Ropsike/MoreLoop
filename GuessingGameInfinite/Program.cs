using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int correctNumber = rnd.Next(1, 1001);
            int guess = 0;
            Console.WriteLine("Arva ära number 1 kuni 1000:");
            while (guess != correctNumber)
            {
                string input Console.ReadLine();
                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Palun kasuta reaalset numbrit");
                    continue;
                }
                guess = Int32.Parse(input);
                if (guess != correctNumber)
                {
                    Console.WriteLine("Vale number, palun proovige uuesti!");
                }

            }
            Console.WriteLine("Oled võitnud!");
           
        }

            
            
    }
    
}
