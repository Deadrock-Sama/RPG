namespace TelegramAPI.TelegramBotNS
{
    public interface IGameComponent : ICommandReader { 
    
        bool IsAnotherComponentAvailable(string componentName);
        bool IsComponentAvailable();
        void SendStartMessage();
    }
}
