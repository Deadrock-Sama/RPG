using System;
using System.Net;
using System.Reactive.Subjects;

namespace TelegramAPI.TelegramBotNS
{
    public class OpendSessionsService : ISessionCounter
    {
        private readonly BehaviorSubject<int> _countSubject = new BehaviorSubject<int>(0);
            
        public IObservable<int> CountObservable => _countSubject;
        public int Count => _countSubject.Value;

        public OpendSessionsService()
        {
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:80/");
            listener.BeginGetContext(new AsyncCallback(ListenerCallback), listener);
        }

        public void Add()
        {
            _countSubject.OnNext(Count + 1);
        }

        public void Clear()
        {
            _countSubject.OnNext(0);
        }

        public void Remove()
        {
            _countSubject.OnNext(Count - 1);
        }

        private void ListenerCallback(IAsyncResult result)
        {
            HttpListener listener = (HttpListener)result.AsyncState;

            HttpListenerContext context = listener.EndGetContext(result);
            HttpListenerRequest request = context.Request;

            HttpListenerResponse response = context.Response;

            string responseString = "1";
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);

            response.ContentLength64 = buffer.Length;
            System.IO.Stream output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);

            output.Close();
        }
    }
}
