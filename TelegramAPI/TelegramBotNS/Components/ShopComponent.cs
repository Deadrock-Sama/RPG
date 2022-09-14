using Core.DBInteraction;
using System;

namespace TelegramAPI.TelegramBotNS.Components
{
    public class ShopComponent : BasicComponent
    {
  
        public override string TranslationCommand => "/shop";    

        public override void HandleCommand(string command)
        {
            throw new NotImplementedException();
        }

        public override async void SendStartMessage()
        {
           await _sender.SendMessage("Занесло же меня в эту страшную лавку");
        }

        public ShopComponent(SessionMessageSender sender, RepositoryShell repo) : base(sender, repo)
        {
         
        }
    }
}
