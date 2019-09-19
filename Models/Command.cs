namespace cmdapi.Models
{
    public class Command
    {
        public Command(int id, string howTo, string platform, string commandLine)
        {
            Id = id;
            HowTo = howTo;
            Platform = platform;
            CommandLine = commandLine;
        }

        public int Id {get; set;}
        public string HowTo {get; set;}
        public string Platform {get; set;}
        public string CommandLine {get; set;}
    }
}
