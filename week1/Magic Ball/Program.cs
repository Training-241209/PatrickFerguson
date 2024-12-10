namespace Magic_Ball;

//Magic Ball
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Magic Ball!");
        Console.WriteLine("Think about your question, and type something:");

        string? userInput = Console.ReadLine(); //? means it can be null

        if (!string.IsNullOrEmpty(userInput))
        {
            Console.WriteLine("\nThe magic ball says:");
            string prediction = GetPrediction();
            Console.WriteLine(prediction);
        }
        else
        {
            Console.WriteLine("Type something!\n");
            Main(args);
        }
    }

    public static string GetPrediction()
    {
        //This is how we mark our variable of a stirng array data type
        string[] predicitons = {
            "It is certain",
            "It is decidedly so",
            "Without a doubt",
            "Yes definitely",
            "You may rely on it",
            "As I see it, yes",
            "Most likely",
            "Outlook good",
            "Yes",
            "Signs point to yes",
            "Reply hazy, try again",
            "Ask again later",
            "Better not tell you now",
            "Cannot predict now",
            "Concentrate and ask again",
            "Don't count on it",
            "My reply is no",
            "My sources say no",
            "Outlook not so good",
            "Very doubtful"
        };

        //Generate a random number using Random built-in class
        Random myRandomNumber = new Random();
        int randomIndex = myRandomNumber.Next(0, predicitons.Length);

        return predicitons[randomIndex];

    }
}
