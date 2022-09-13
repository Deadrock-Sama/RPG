using Core.DBInteraction;
using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;

namespace TelegramAPI.TelegramBotNS.Components
{
    public class JourneyComponent : BasicComponent
    {

        public override string TranslationCommand => "/journey";

        public override void HandleCommand(string command)
        {
            throw new NotImplementedException();
        }

        public override async void SendStartMessage()
        {
            await base._sender.SendMessage("Вот ты и покидаешь город и натыкаешься на...");
        }

        public JourneyComponent(SessionMessageSender sender, RepositoryShell repositoryShell) : base(sender, repositoryShell)
        {
       
        }
    }
}
