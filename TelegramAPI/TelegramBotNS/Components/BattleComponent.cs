using Core.DBInteraction;

namespace TelegramAPI.TelegramBotNS.Components
{
    public class BattleComponent : BasicComponent
    {

        public override string TranslationCommand => "/battle";



        public override void HandleCommand(string command)
        {
            //
        }

        public override bool IsAnotherComponentAvailable(string componentName)
        {
            return true;
        }

        public override async void SendStartMessage()
        {
            await base._sender.SendMessage("Бой!");
        }

        public BattleComponent(SessionMessageSender sender, RepositoryShell repositoryShell) : base(sender, repositoryShell)
        {
           
        }
    }
}
