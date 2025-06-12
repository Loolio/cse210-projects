public class Breathing : Activity
{
    public Breathing()
    {
        _name = "Breathing exercise";
        _description = "This activity will help you relax by walking you through breathing in and out slowly.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.Write("Breathe in...");
            ShowCountDown(3);
            Console.Write("Now breathe out...");
            ShowCountDown(3);
            elapsed += 6;
        }
        DisplayEndingMessage();
    }
}
