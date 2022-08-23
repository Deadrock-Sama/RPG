using Core.DBInteraction;
using System;
using Telegram.Bot;

namespace TelegramAPI.TelegramBotNS
{
    public class StartGameComponent : IGameComponent
    {
        private SessionMessageSender _Sender;
        private RepositoryShell _Repo;

        public string TranslationCommand => throw new NotImplementedException();

        public void HandleCommand(string command)
        {
            throw new NotImplementedException();
        }

        public bool IsAnotherComponentAvailable(string componentName)
        {
            throw new NotImplementedException();
        }

        public void SendStartMessage()
        { 
            
        
        }

        public bool IsComponentAvailable()
        {
            throw new NotImplementedException();
        }

        public StartGameComponent(SessionMessageSender sender, RepositoryShell repo)
        {
            _Sender = sender;
            _Repo = repo;
        }
    }
}
