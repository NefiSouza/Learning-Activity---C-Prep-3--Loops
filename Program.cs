using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random(); 
        int Number_magic; 

        string number_input;
        int inputInt;
        int guess_Count = 0;
        string answer = "yes";

        do {
            Number_magic = randomGenerator.Next(1,100);
            guess_Count = 0; 
            do {
                guess_Count ++;
                Console.Write("What is your guess? ");
                number_input = Console.ReadLine();
                inputInt = int.Parse(number_input);

                if (inputInt < Number_magic)
                {
                    Console.WriteLine("Higher");
                }
                else if (inputInt > Number_magic)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It only took you {guess_Count} tries.");
                }
            } while (inputInt != Number_magic);
            Console.Write("Do you want to play again? ");
            answer = Console.ReadLine();
        } while (answer == "yes");

    }
}