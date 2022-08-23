namespace TelegramAPI.TelegramBotNS
{
    public interface IGameComponent : ICommandReader { 
    
        string TranslationCommand { get; }
        bool IsAnotherComponentAvailable(string componentName);
        bool IsComponentAvailable();
        void SendStartMessage();
    }
}
