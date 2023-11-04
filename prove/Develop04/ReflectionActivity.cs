public class ReflectionActivity : Activity
{
    private string _activityName = "Reflection Activity";
    private string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
};
    private int _userTime;
    private string _userInput;
    List<string> _responsses;
    public ReflectionActivity()
    {
        
    }
    
    public void Start()
    {
        Random _random = new Random();
        _userTime = StartActivity(_activityName, _description);
        Console.WriteLine();
        int prompt = _random.Next(_prompts.Count()-1);
        DisplayThought(prompt);
        DisplayEndPrompt();

    }

    public void DisplayThought(int i)
    {
        Console.WriteLine("Consider the following Pormpt:\n");
        Console.WriteLine($" --- {_prompts[i]} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder each of the following questions as they relate to this experience.");
        Console.Write($"You may begin in: ");
        CountDown(5);
    }


    // public void DisplayQuestion()
    // {
        
    // }
}