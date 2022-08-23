using Core.DBInteraction;
using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;

namespace TelegramAPI.TelegramBotNS
{
    public class JourneyComponent : IGameComponent
    {


        private SessionMessageSender _Sender;
        private RepositoryShell _Repo;

        public string TranslationCommand => throw new NotImplementedException();

        public void HandleCommand(string command)
        {
            var p = 0;
        }

        public bool IsAnotherComponentAvailable(string componentName)
        {
            throw new NotImplementedException();
        }

        public bool IsComponentAvailable()
        {
            throw new NotImplementedException();
        }

        public void SendStartMessage()
        {
            throw new NotImplementedException();
        }

        public JourneyComponent(SessionMessageSender sender, RepositoryShell repo)
        {
            _Sender = sender;
            _Repo = repo;
        }
    }
}
