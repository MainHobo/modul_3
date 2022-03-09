namespace CSpiss;

public class OppgaveKrokodillespillet
{
    // Write "end" to end the game
    public static void Run(string[] args)
    {
        int points = 0;
        while (true)
        {
            int number1 = MakeNumbersArr()[0];
            int number2 = MakeNumbersArr()[1];
            
            Console.WriteLine($"{number1}_{number2}");
            Console.WriteLine($"{points} points");

            int point = CheckIfCorrect(number1, number2);
            points = points + point;
            if (point == 2)
            {
                return;
            }
        }
    }

    private static int CheckIfCorrect(int number1, int number2)
    {
        int point = 0;
        bool i = true;
        while (i)
        {
            string answer = Console.ReadLine();
            if (answer == "<" || answer == ">" || answer == "=")
            {
                if (number1 == number2 && answer == "=")
                {
                    Console.WriteLine("Correct!");
                    point = 1;
                    i = false;
                }
                else if (number1 < number2 && answer == "<")
                {
                    Console.WriteLine("Correct!");
                    point = 1;
                    i = false;
                }
                else if (number1 > number2 && answer == ">")
                {
                    Console.WriteLine("Correct!");
                    point = 1;
                    i = false;
                }
                else
                {
                    Console.WriteLine("Wrong answer");
                    point = -1;
                    i = false;
                }
            }
            else if (answer == "end")
            {
                return 2;
            }
            else
            {
                Console.WriteLine("This is not a viable answer! (<,>,=)");
            }
        }

        return point;
    }

    private static int[] MakeNumbersArr()
    {
        int random = RandomNumber();
        int[] randomNumbers = new int[2];

        for (var i = 0; i < 2; i++)
        {
            randomNumbers[i] = random;
        }

        return randomNumbers;
    }
    private static int RandomNumber()
    {
        Random random = new Random();
        return random.Next(1, 11);
    }
}