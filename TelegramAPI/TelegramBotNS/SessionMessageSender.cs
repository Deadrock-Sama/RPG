using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramAPI.TelegramBotNS
{
    public class SessionMessageSender
    {

        private readonly Chat _chat;
        private readonly ITelegramBotClient _bot;

        public SessionMessageSender(ITelegramBotClient bot, Chat chat)
        {
            _chat = chat;
            _bot = bot;
        }

        public async Task<Message> SendMessage(string text) => await _bot.SendTextMessageAsync(_chat, text);

        public async Task<Message> SendMessage(string text, IReplyMarkup markup) => await _bot.SendTextMessageAsync(_chat, text, replyMarkup: markup);

    }
}
