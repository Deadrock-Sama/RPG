using System.Net.Http;

namespace GameSiteMvc.Models
{
    public class GameSessionsInfoService
    {
        public int Count => RecieveCount();
        private readonly HttpClient client = new HttpClient();
        private int RecieveCount()
        {

            HttpRequestMessage httpRequestMessage = new HttpRequestMessage();
            httpRequestMessage.Method = HttpMethod.Get;
            httpRequestMessage.RequestUri = new System.Uri("http://localhost:80/");
            var responseMessage = client.Send(httpRequestMessage);
            var result = responseMessage.Content.ReadAsStringAsync().Result;

            return int.Parse(result);
        }


    }


    public class GameSessionsInfoViewModel
    {
        private readonly GameSessionsInfoService _service;

        public int Count => _service.Count;

        //transient
        public GameSessionsInfoViewModel(GameSessionsInfoService service)
        {
            _service = service;
        }
    }

    public class MyFirstPageViewModel
    {
        public string TText => "Тут что-то есть";
    }
}
