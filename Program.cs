using System;

namespace NetSecureBotChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleUI.ShowHeader();

            AudioPlayer.PlayGreeting();

            var bot = new Chatbot();
            bot.Run();
        }
    }
}