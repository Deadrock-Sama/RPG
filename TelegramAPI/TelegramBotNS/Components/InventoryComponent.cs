using Core.DBInteraction;
using System;

namespace TelegramAPI.TelegramBotNS.Components
{
    public class InventoryComponent : BasicComponent
    {

        public override string TranslationCommand => "/inventory";


        public override void HandleCommand(string command)
        {
            throw new NotImplementedException();
        }

        public override async void SendStartMessage()
        {
           await base._sender.SendMessage("Инвентарь:");
        }

        public InventoryComponent(SessionMessageSender sender, RepositoryShell repo) : base(sender, repo)
        {
         
        }
    }
}
