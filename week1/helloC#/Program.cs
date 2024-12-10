using System;  // using is like import. We import our namespaces/libraries with USING statements

namespace helloC_; // File cabinet, we store our stuff in it (our code)

// blueprint of a future object, our main class, this is our program main entry point
class Program
{
    // This method is the entry point of execution
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //Built-in data types in C#

        // Integer/numeric
        int age = 26;
        long veryLargeNumber = 132948713209481723; // larger that int, but less than double
        short myTinyNumber = 255; // smaller than int
        byte myByte = 255; // smallest integer, 8 bits

        //Floating point number
        double amountofMoney = 50.25; // general use, and more accurate
        float anotherFloating = 50.50f; // less precision, less memory usage

        //characters and booleans
        char myChar = 'P';
        bool isTrue = true;


        //Strings
        string username = "Patrick";

        Console.WriteLine("Hello: " + username);
        Console.WriteLine($"I am {age} years old"); //String interpolation, can use ${} or +

        //Arithmetic operators
        int a = 5 + 9;
        int b = 5 - 10;
        int c = 10 * 5;
        int d = 10 / 5;
        int e = 10 % 5;

        //Comparison operators
        //a == b //EQUALS operator
        //a != b //NOT EQUALS operator
        //a > b //GREATER THAN operator
        //a < b //LESS THAN operator
        //a >= b //GREATER THAN OR EQUAL TO operator
        //a <= b //LESS THAN OR EQUAL TO operator

        //Logical operators
        //a < b || a == b //OR operator
        //a > b && a == b //AND operator
        //a < b ^ b == a //XOR operator

        //Assignment operators
        a += 5;
        a -= 5;
        a *= 5;
        a /= 5;
        a %= 5;

        Console.WriteLine("Enter your name: \n");
        string user = Console.ReadLine(); //Read user input
        Console.WriteLine("You entered: " + user);


        //Conditional Statements
        bool isPassword = true;
        if (isPassword)
        {
            Console.WriteLine("Password is correct");
        }
        else
        {
            Console.WriteLine("Password is incorrect");
        }


        //Switch statements
        int day = 5;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day");
                break;
        }

        //Loops

        //for loop
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        //while loop
        int j = 0;
        while (j < 10)
        {
            Console.WriteLine(j);
            j++;
        }

        //do while loop
        int k = 0;
        do
        {
            Console.WriteLine(k);
            k++;
        } while (k < 10);

        //Type Conversion

        //Implicit conversion
        int myInt = 10;
        double myDouble = myInt;
        Console.WriteLine(myDouble); // was converted to double, no data loss

        //Explicit conversion
        double doubleVal = 10.5;
        int intVal = (int)doubleVal; //was converted to int data loss may occur
        Console.WriteLine(intVal);


    }
}
