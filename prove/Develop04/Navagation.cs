using System.Globalization;

public class Navagation
{
    private string _userInput;
    private bool _endProgam;
    private List<string> _menuList; 

    public Navagation()
    {
        _userInput = "";
        _endProgam = false;
        _menuList = new List<string>
        {
            "1. Start breathing activity ",
            "2. Start reflecting activity ",
            "3. Start listing activity ",
            "4. Quit "
        };
    }

    public void DisplayMenu()
    {
         do
        {
            Console.WriteLine("Menu Options:");
            foreach (string _option in _menuList)
            {
                Console.WriteLine($"\t{_option}");
            }
            _endProgam = MenuSelection();
        }while (!_endProgam);
    }
    public bool MenuSelection()
    {
            bool _quit = false;

            Console.WriteLine("Select a choice from the menu: ");
            _userInput = Console.ReadLine();

            if (_userInput == "1")
            {
                BreathingActivity _bActivity = new BreathingActivity();
                // _bActivity.
            }
            else if (_userInput == "2")
            {
                ReflectionActivity _rActivity = new ReflectionActivity();
                // _rActivity.
            }
            else if (_userInput == "3")
            {
                ListingActivity _lActivity = new ListingActivity();
                // _lActivity.
            }
            else if (_userInput == "4")
            {
                _quit = true;
            }
            else
            {
                Console.WriteLine($"'{_userInput}' is not a valid input. Please try again.");
            }

        return _quit;
    }
}