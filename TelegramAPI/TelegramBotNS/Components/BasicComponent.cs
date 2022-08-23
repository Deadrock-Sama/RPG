using Core.DBInteraction;
using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;

namespace TelegramAPI.TelegramBotNS.Components
{
    public class BasicComponent : IGameComponent
    {
        private SessionMessageSender _Sender;
        private RepositoryShell _Repo;

        public virtual string TranslationCommand => throw new NotImplementedException();

        public virtual void HandleCommand(string command)
        {
            throw new NotImplementedException();
        }

        public virtual bool IsAnotherComponentAvailable(string componentName)
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

        public BasicComponent(SessionMessageSender sender, RepositoryShell repo)
        {
            _Sender = sender;
            _Repo = repo;
        }
    }
}
