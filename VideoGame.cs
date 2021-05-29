using System;
namespace Treehouse.MediaLibrary
{
    public class VideoGame : MediaType
    {
        public string GamingConsole { get; private set; }

        public string DisplayText =>
            "Video Game: " + Title + " for " + GamingConsole + OnLoanDisplayText;

        public VideoGame(string title, string gamingConsole)
            : base(title)
        {
            GamingConsole = gamingConsole;
        }        
    }
}
