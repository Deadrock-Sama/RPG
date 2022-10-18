using System;

namespace TelegramAPI.TelegramBotNS
{
    public interface ISessionCounter
    {
        IObservable<int> CountObservable { get; }
        int Count { get; }
        void Add();
        void Remove();
        void Clear();
    }
}
