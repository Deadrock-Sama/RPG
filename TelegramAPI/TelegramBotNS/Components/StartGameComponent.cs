using Core.DBInteraction;

namespace TelegramAPI.TelegramBotNS.Components
{
    public class StartGameComponent : BasicComponent
    {
        public StartGameComponent(SessionMessageSender sender, RepositoryShell repositoryShell) : base(sender, repositoryShell)
        {

            _availableComponents.Add("/createplayer");
        }

        public override string TranslationCommand => "/start";

        public override void HandleCommand(string command)
        {
            //пока хз чо сюда закинуть
        }

        public override async void SendStartMessage()
        {
            await _sender.SendMessage("Игра началась. Отправь /createPlayer, чтобы создать персонажа");
        }
    }
}
