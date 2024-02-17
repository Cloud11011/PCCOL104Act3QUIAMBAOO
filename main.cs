using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the My Input Code!");
        Console.WriteLine("Enter text or type 'exit' to end the program:");

        string input;
        while ((input = Console.ReadLine()) != "exit")
        {
            Console.WriteLine("You entered this text: " + input);
        }

        Console.WriteLine("PROGRAM CLOSED. Press any key to exit this please.");
        Console.ReadKey();
    }
}
