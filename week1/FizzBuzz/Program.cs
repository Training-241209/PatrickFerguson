/*
    FizzBuzz, we have an integer, for every integer that is less than n, we have a few rules:
    Print "FizzBuzz" if i / 3 and i / 5
    Print "Fizz" if i / 3
    Print "Buzz" if i / 5
    Print i if none of the above are true
*/

/*Access Modifiers

public - it's the most open access modifier, all classes in the project can access it
private - most closed, only available to the class itself
internal - it's limited to a class and it's member, but not static member
protected - only the class it's children/subclasses


static keyword - means we don't have to have an object/instance to 
call method or access static member, and static member value are shared

*/

    int number = 20;
    int counter = 1;

    while(counter <= number) {
        if((counter % 3 == 0) && (counter % 5 == 0)) {
            Console.WriteLine("FizzBuzz");
        }
        else if(counter % 3 == 0) {
            Console.WriteLine("Fizz");
        }
        else if(counter % 5 == 0) {
            Console.WriteLine("Buzz");
        }
        else{
            Console.WriteLine(counter);
        }

        counter++;
    }
