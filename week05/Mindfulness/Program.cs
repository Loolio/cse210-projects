using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Loolio! This is the Mindfulness App.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Application's Menu Options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu options below: ");
            string choice = Console.ReadLine();

            if (choice == "1")
                new Breathing().Run();
            else if (choice == "2")
                new Reflecting().Run();
            else if (choice == "3")
                new Listing().Run();
            else if (choice == "4")
                break;
        }

    }
}