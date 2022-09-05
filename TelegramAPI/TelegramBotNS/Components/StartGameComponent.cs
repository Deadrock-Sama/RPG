using Core.DBInteraction;
using System;
using Telegram.Bot;

namespace TelegramAPI.TelegramBotNS.Components
{
    public class StartGameComponent : BasicComponent
    {
        public StartGameComponent(SessionMessageSender sender, RepositoryShell repositoryShell) : base(sender, repositoryShell)
        {
        }

        public override string TranslationCommand => throw new NotImplementedException();

        public override void HandleCommand(string command)
        {
            throw new NotImplementedException();
        }

        public override bool IsAnotherComponentAvailable(string componentName)
        {
            throw new NotImplementedException();
        }

        public override void SendStartMessage()
        {
            throw new NotImplementedException();
        }
    }
}
