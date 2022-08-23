using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramAPI.TelegramBotNS
{
    public class SessionMessageSender
    {

        private readonly Chat _Chat;
        private readonly ITelegramBotClient _Bot;

        public SessionMessageSender(ITelegramBotClient bot, Chat chat)
        {
            _Chat = chat;
            _Bot = bot;
        }

        public async Task<Message> SendMessage(string text) => await _Bot.SendTextMessageAsync(_Chat, text);
            

    }
}
