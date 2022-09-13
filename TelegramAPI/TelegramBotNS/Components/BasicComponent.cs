using Core.DBInteraction;
using System.Collections.Generic;

namespace TelegramAPI.TelegramBotNS.Components
{
    public abstract class BasicComponent : IGameComponent
    {
   
        public abstract string TranslationCommand { get; }

        public abstract void HandleCommand(string command);

        public virtual bool IsAnotherComponentAvailable(string componentName) 
        { 
            return _availableComponents.Contains(componentName);
        }

        public abstract void SendStartMessage();

        public virtual bool IsComponentAvailable() => true;     

        protected readonly SessionMessageSender _sender;
        protected readonly RepositoryShell _repositoryShell;
        protected List<string> _availableComponents = new List<string>();//хз куда это нести 

        public BasicComponent(SessionMessageSender sender, RepositoryShell repositoryShell)
        {
            _sender = sender;
            _repositoryShell = repositoryShell;
        }
    }
}
