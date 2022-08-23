using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramAPI.TelegramBotNS
{
    public class TelegramCommandsReader
    {

        private readonly GameManager _gameManager;

        public TelegramCommandsReader(GameManager gameManager)
        {
            _gameManager = gameManager;
        }
        public async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {

            cancellationToken.ThrowIfCancellationRequested();

            bool UpdateIsMessage = update.Type == Telegram.Bot.Types.Enums.UpdateType.Message;

            if (!UpdateIsMessage)
            {
                return;
            }
            var message = update.Message;
            bool MessageIsText = message.Type == Telegram.Bot.Types.Enums.MessageType.Text;

            if (!MessageIsText)
            {
                await SendAboutText(botClient, message);
                return;
            }

            string command = message.Text.ToLower();
            string userID = message.From.Id.ToString();
            Chat chat = message.Chat;
            _gameManager.HandleCommand(command, userID, chat);

        }
        public async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }

        private async Task<Message> SendAboutText(ITelegramBotClient botClient, Message message)
        {
            var MessageAboutText = "Хорошо, хорошо, мы все поняли, у тебя есть лишняя хромосома. Теперь пиши нормально, пожалуйста";
            return await botClient.SendTextMessageAsync(message.Chat, MessageAboutText);
        }
    }
}
