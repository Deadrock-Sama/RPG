using Core.DBInteraction;
using System;

namespace TelegramAPI.TelegramBotNS.Components
{
    public class PlayerComponent : BasicComponent
    {
     
        public override string TranslationCommand => "/player";

        public override void HandleCommand(string command)
        {
            throw new NotImplementedException();
        }

        public override async void SendStartMessage()
        {
            await _sender.SendMessage("Игрок");
        }

        public PlayerComponent(SessionMessageSender sender, RepositoryShell repo) : base(sender, repo)
        {
         
        }
    }


}
