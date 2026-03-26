using System.Security.Cryptography.X509Certificates;

namespace Topic_5._5___More_Classes_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1, die2;

            die1 = new Die();
            die1.Color = ConsoleColor.Blue;
            die2 = new Die();
            die2.Color = ConsoleColor.Red;

            die1.RollDie();
            die1.DrawRoll();
            Console.WriteLine();
            die2.RollDie();
            die2.DrawRoll();


            if (die1.Roll == die2.Roll)
            {
                Console.WriteLine("You got doubles!");
            }
            else
            {
                Console.WriteLine("Not doubles, Try again!");
            }


            if (die1.Roll + die2.Roll == 7)
            {
                Console.WriteLine("You got a sum of 7!");
            }
            else
            {
                Console.WriteLine("Your sum doesn't equal 7, try again!");
            }


            if (die1.Roll + die2.Roll == 2)
            {
                Console.WriteLine("You got snake eyes!");
            }
            else
            {
                Console.WriteLine("You didn't get snake eyes, try again!");
            }


            int sum = die1.Roll + die2.Roll;
            if (sum % 2 == 0)
            {
                Console.WriteLine("You got an even number!");
            }
            else
            {
                Console.WriteLine("You got an odd number, try again!");
            }


            if (die1.Roll == die2.Roll + 1 || die1.Roll == die2.Roll - 1)
            {
                Console.WriteLine("The dice are sequential!");
            }
            else
            {
                Console.WriteLine("The dice are not sequential, try again");
            }


            if (die1.Roll > die2.Roll)
            {
                Console.WriteLine("Die 1 is the bigger number!");
            }
            else if (die2.Roll > die1.Roll)
            {
                Console.WriteLine("Die 2 is the bigger number!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }

        }
    }
}
