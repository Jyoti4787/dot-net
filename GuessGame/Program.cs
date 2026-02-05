using System;

class Program
{
    static void Main()
    {
        Random r = new Random();
        int number = r.Next(1, 11);
        int chances = 3;
        int money = 0;

        Console.WriteLine("Number Guess Game");
        Console.WriteLine("Guess a number between 1 and 10");
        Console.WriteLine("You have 3 chances");

        while (chances > 0)
        {
            Console.Write("Enter number: ");
            int guess = int.Parse(Console.ReadLine());

            if (guess == number)
            {
                money = 1000;
                Console.WriteLine("Correct guess");
                Console.WriteLine("You won $" + money);
                break;
            }
            else
            {
                chances--;
                if (chances > 0)
                {
                    Console.WriteLine("Wrong guess");
                    Console.WriteLine("Chances left: " + chances);
                }
                else
                {
                    Console.WriteLine("Game over");
                    Console.WriteLine("Correct number was: " + number);
                }
            }
        }
    }
}
