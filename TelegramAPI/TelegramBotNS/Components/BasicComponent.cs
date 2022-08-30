using Core.DBInteraction;
using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;

namespace TelegramAPI.TelegramBotNS.Components
{
    // идея неплохая но не закончино как я понял
    // по логике класс должен быть абстрактным
    public abstract class BasicComponent : IGameComponent
    {
        // нейминг, protected, readonly
        protected readonly SessionMessageSender _Sender;
        protected readonly RepositoryShell _Repo;

        
        public abstract string TranslationCommand;

        
        public abstract void HandleCommand(string command)
        {
            throw new NotImplementedException();
        }

        // abstract
        public abstract bool IsAnotherComponentAvailable(string componentName)
        {
            throw new NotImplementedException();
        }

       
        public virtual bool IsComponentAvailable()
        {
            return true;
        }


        public virtual void SendStartMessage()
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
