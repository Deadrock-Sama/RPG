using Core.DBInteraction;
using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;

namespace TelegramAPI.TelegramBotNS.Components
{
    public abstract class BasicComponent : IGameComponent
    {
   
        public abstract string TranslationCommand { get; }

        public abstract void HandleCommand(string command);
        
        public abstract bool IsAnotherComponentAvailable(string componentName);

        public abstract void SendStartMessage();

        public virtual bool IsComponentAvailable() => true;     

        protected readonly SessionMessageSender _sender;
        protected readonly RepositoryShell _repositoryShell;

        public BasicComponent(SessionMessageSender sender, RepositoryShell repositoryShell)
        {
            _sender = sender;
            _repositoryShell = repositoryShell;
        }
    }
}
