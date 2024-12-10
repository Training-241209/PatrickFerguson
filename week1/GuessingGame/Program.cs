namespace GuessingGame;

class Program
{
    static void Main(string[] args)
    {
        Greeting();

        Random rand = new Random();
        int randomNumber = rand.Next(1, 50);
        //int randomNumber = 35; // Testing purposes

        Console.WriteLine("\nEnter your guess: ");
        int userGuess = getUserInput();
        int attempts = 1;

        while(attempts < 5){
            if(userGuess < randomNumber) {
                Console.WriteLine("Too low, guess again: ");
                userGuess = getUserInput();
            }
            else if(userGuess > randomNumber) {
                Console.WriteLine("Too high, guess again: ");
                userGuess = getUserInput();
            }
            attempts++;
        }

        if(userGuess == randomNumber){
            Console.WriteLine("\nCongratulations!! \nYou guessed the number in " + attempts + " tries.");
            Console.WriteLine("Thank you for playing!");
        }
        else if(userGuess != randomNumber) {
            Console.WriteLine("\nI'm sorry you ran out of attempts!");
            Console.WriteLine("The number was " + randomNumber + ".");
            Console.WriteLine("Better luck next time!");
        }
    }

    public static void Greeting() {
        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("I'm thinking of a number between 1 and 50.");
        Console.WriteLine("Can you guess what it is in 5 tries or less?");
    }

    public static int getUserInput() {
        string? userInput = Console.ReadLine();
        try {
            return Int32.Parse(userInput);
        }
        catch(Exception e) {
            Console.WriteLine("Invalid input. \nPlease enter a number: ");
            return getUserInput();
        }
    }
}
