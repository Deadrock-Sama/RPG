namespace TelegramAPI.TelegramBotNS.Components
{
    public interface IGameComponent : ICommandReader
    {

        bool IsAnotherComponentAvailable(string componentName);
        bool IsComponentAvailable();
        void SendStartMessage();

        string TranslationCommand { get; }
    }
}
