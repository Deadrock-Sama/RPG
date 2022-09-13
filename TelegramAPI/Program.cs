using System;
using TelegramAPI.TelegramBotNS;

namespace TelegramAPI
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var bot = new TelegramBot();
            bot.Start();

            Console.Read();
            
        }
    }
}
