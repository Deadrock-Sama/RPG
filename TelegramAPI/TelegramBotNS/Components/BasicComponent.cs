using Core.DBInteraction;
using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;

namespace TelegramAPI.TelegramBotNS.Components
{
    // идея неплохая но не закончино как я понял
    // по логике класс должен быть абстрактным
    public class BasicComponent : IGameComponent
    {
        // нейминг, protected, readonly
        protected readonly SessionMessageSender _Sender;
        protected readonly RepositoryShell _Repo;

        // abstract
        public virtual string TranslationCommand => throw new NotImplementedException();

        // abstract
        public virtual void HandleCommand(string command)
        {
            throw new NotImplementedException();
        }

        // abstract
        public virtual bool IsAnotherComponentAvailable(string componentName)
        {
            throw new NotImplementedException();
        }

        // virtual
        public bool IsComponentAvailable()
        {
            return true;
        }

        // virtual
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
