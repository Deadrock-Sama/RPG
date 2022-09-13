using Core.DBInteraction;
using System.Collections.Generic;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramAPI.TelegramBotNS.Components
{
    public class CityComponent : BasicComponent
    {
        public override string TranslationCommand => "/city";
        private readonly IReplyMarkup _markup;

        public override async void HandleCommand(string command)
        {
            //Вероятно будет какая-то общая обработка для команд типа покушать
            await base._sender.SendMessage("В самой Спирали заняться нечем, нужно куда-то отправляться", _markup);
        }

        public override async void SendStartMessage()
        {
           await base._sender.SendMessage("Добро пожаловать в Спираль", _markup);
        }

        public override bool IsAnotherComponentAvailable(string componentName)
        {
            return base.IsAnotherComponentAvailable(componentName);
        }

        public CityComponent(SessionMessageSender sender, RepositoryShell repositoryShell) : base(sender, repositoryShell)
        {
            base._availableComponents.Add("/shop");
            base._availableComponents.Add("/journey");
            base._availableComponents.Add("/inventory");
            base._availableComponents.Add("/player");

            var markUpButtons = new List<KeyboardButton>();

            //Пока что так. В дальнейшем можно будет перебить на текст для большей красоты. В нашем случае это не особо принципиально
            foreach (var buttonCommand in _availableComponents)
            { 
                markUpButtons.Add(new KeyboardButton(buttonCommand));
            }

            _markup = new ReplyKeyboardMarkup(markUpButtons) { ResizeKeyboard = true };
            

        }
    }
}
