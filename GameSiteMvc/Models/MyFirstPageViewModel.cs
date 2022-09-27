namespace GameSiteMvc.Models
{
    public class GameSessionsInfoService
    {
        public int Count => 8;

        //получает с бота информацию
        //singleton
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
