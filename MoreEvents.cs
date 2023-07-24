namespace MoreEvents
{
    internal class MoreEvents
    {
        static void Main(string[] args)
        {
            Football info = new Football();
            info.DisplayClub("Manchester", "England");
            info.DisplayPlayerInfo("Penaldo", "Real Msajrid");
        }
    }

    class Football
    {
        private DisplayInfo displayInfoInstance;
        public Football()
        {
            displayInfoInstance = new DisplayInfo();
            displayInfoInstance.DisplayDateAfterEvent += DisplayInfoInstance_DisplayDateAfterEvent;
            displayInfoInstance.DisplayMessageBeforeEvent += DisplayInfoInstance_DisplayMessageBeforeEvent;
            // += mere tabs davachire da tavisit dawera danarcheni
        }

        private void DisplayInfoInstance_DisplayMessageBeforeEvent() // esec tavisit dawera :D
        {
            Console.WriteLine("Program is about to display information");
        }

        private void DisplayInfoInstance_DisplayDateAfterEvent()
        {
            Console.WriteLine("Information has been displayed on " + DateTime.Now.ToShortTimeString());
        }

        public void DisplayClub(string club, string country)
        {
            displayInfoInstance.DisplayClub(club, country);
        }

        public void DisplayPlayerInfo(string name, string club)
        {
            displayInfoInstance.DisplayPlayer(name, club);
        }
    }

    class DisplayInfo
    {
        public delegate void DisplayDateAfterDelegate();
        public delegate void DisplayMessageBeforeDelegate();
        public event DisplayMessageBeforeDelegate DisplayMessageBeforeEvent;
        public event DisplayDateAfterDelegate DisplayDateAfterEvent;

        public void DisplayClub(string clubName, string country)
        {
            DisplayMessageBeforeEvent();
            Console.WriteLine($"{clubName} from {country}");
            DisplayDateAfterEvent(); Console.WriteLine();
        }

        public void DisplayPlayer(string playerName, string clubName)
        {
            DisplayMessageBeforeEvent();
            Console.WriteLine($"{playerName} plays for {clubName}");
            DisplayDateAfterEvent();
        }
    }
}