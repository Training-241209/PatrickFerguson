namespace ExpenseTracker;

class Program
{
    static void Main(string[] args)
    {
        Greeting();
        DisplayOptions();
        int selectUserOption = getUserOption();


        //Exectue methods according to user's selection
        switch (selectUserOption)
        {
            case 1:
                Console.WriteLine("User slected to add an expense.");
                break;
            case 2:
                Console.WriteLine("User slected to view all expenses.");
                break;
            case 3:
                Console.WriteLine("User slected to edit an expense.");
                break;
            case 4:
                Console.WriteLine("User slected to delete an expense.");
                break;
            case 5:
                Console.WriteLine("User slected to save to a file.");
                break;
            case 6:
                Console.WriteLine("User slected to exit.");
                break;
            default:
                Console.WriteLine("Invalid selection. Please try again.");
                break;
        }
    }

    public static void Greeting()
    {
        Console.WriteLine("Welcome to the Expense Tracker!");
        Thread.Sleep(1500);
        Console.WriteLine("Select one of the following options: \n");
        Thread.Sleep(1500);

    }

    public static void DisplayOptions()
    {
        Console.WriteLine("1. Add an expense");
        Console.WriteLine("2. View expenses");
        Console.WriteLine("3. Edit Expense");
        Console.WriteLine("4. Delete Expense");
        Console.WriteLine("5. Save to a file");
        Console.WriteLine("6. Exit");

    }

    public static int getUserOption()
    {
        Console.WriteLine("Select the option: \n");
        string? userInput = Console.ReadLine(); // ? marks that our userInput might be null

        try
        {
            return Int32.Parse(userInput);

        }
        catch (Exception e)
        {
            Console.WriteLine("Invalid input! Make sure you typed a number");
            return getUserOption();
        }

    }
}
