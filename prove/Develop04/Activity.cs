using System.Globalization;
using System.Reflection;

public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;
    private List<string> _animation = new List<string>
    {"|","/","-","\\","|","/","-","\\"};

    public Activity()
    {
        _activityName = "Template";
        _description = "This is the parent Activity";
    }

    public int StartActivity(string activity, string description)
    {
        SetActivityName(activity);
        SetDescription(description);
        DisplayIntroText();
        _duration = GetUserInt();
        Console.WriteLine();
        DisplayReadyPrompt();
        LoadingAnimation(5);
        return _duration;
    }
    public void SetActivityName(string activity)
    {
        _activityName = activity;
    }     
    public void SetDescription(string description)
    {
        _description = description;
    }
    public void DisplayIntroText()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}.\n");
        Console.WriteLine($"{_description}\n");
        Console.WriteLine("How long in seconds, would you like your session? ");
    }
    public int GetUserInt()
    {
        int number;
        Console.Write("> ");
        try{number = int.Parse(Console.ReadLine());}
        catch
        {
            Console.WriteLine("Please enter valid number.");
            number = GetUserInt();
        }
        return number;
    }
    public DateTime CurrentTime()
    {
        DateTime startTime = DateTime.Now;
        return startTime;
    }
    public DateTime SetDelay(DateTime startTime, int delay)
    {
        DateTime endTime = startTime.AddSeconds(delay);
        return endTime;
    }
    public string GetUserString()
    {
        return Console.ReadLine();
    }
    public void DisplayReadyPrompt()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");

    }
    public void LoadingAnimation(int delay)
    {
        int i = 0;
        DateTime _start = CurrentTime();
        DateTime _delay = SetDelay(_start, delay);
        while(_start < _delay)
        {
            string s = _animation[i];
            Console.Write(s);
            Thread.Sleep(100);
            Console.Write("\b \b");
            _start = CurrentTime();

            i++;
            if(i >= _animation.Count)
            {
                i = 0;
            }
        }
    }

    public void CountDown(int length)
    {
        for (int i = length; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
    }

    public void DisplayEndPrompt()
    {
        Console.WriteLine("Well Done!!!");
        LoadingAnimation(2);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_activityName}.");
        LoadingAnimation(3);
    }

    public int RandomCheck(Random random,int i, List<bool> bools)
    {
        if(bools[i])
        {
            while(bools[i])
                {
                    i = random.Next(1, bools.Count() - 1);
                }
        }
        bools[i] = true;
        return i;
    }

    public bool AllAsked(List<bool> bools)
    {
        bool _allAsked = false;
        for (int i = 0; i < bools.Count(); i++)
        {
            if(bools[i])
            {
                return _allAsked;
            }
        }
        return _allAsked;
    }

}