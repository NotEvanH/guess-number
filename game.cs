using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between one and a thousand!");

            Random random = new Random();
            int randomNumber = random.Next(1, 1000);
            while (true)
            {
                Console.Write("Guess: ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == randomNumber)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("WRONG!");
                }
            }

            Console.WriteLine("Well Done! You got the number. It was " + Convert.ToString(randomNumber));
        }
    }
}
