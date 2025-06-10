using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        var reference = new Reference("Proverbs", 11, 5, 6);
        var scripture = new Scripture(reference, "The righteousness of the blameless makes their paths straight,but the wicked are brought down by their own wickedness.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide a word, or type 'quit' to exit.");
            var input = Console.ReadLine();

            if (input?.ToLower() == "quit")
                break;

            if (!scripture.IsCompletelyHidden())
            {
                scripture.HideRandomWords(3);
            }
            else
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Press Enter to exit.");
                Console.ReadLine();
                break;
            }

        }
    }


}