using System.Collections;
using System.Collections.Generic;

namespace GameSiteMvc.Models
{
    public class NewsViewModel
    {
        //Получение из БД
        private readonly Dictionary<string, string> _news = new Dictionary<string, string>()
        {

            { "Интервью с бетатестерами", "Бетатестеры жаловались, что нет возможости познакомиться с игрой и посмотреть статистику. Также они считают необходимым наличие новостей и форума" },
            { "Планы о сайте", "Мы решили открыть сайт-визитку игры, где можно посмотреть статистику и важнейшие новости по игре"},
            { "Запустили сайт", "Наши разработчики непокладая рук занимались сайтом, чтобы вы могли увидеть эту надпись" },
            { "Дальнейшее развитие", "Принимаем преложения по развитию по форме: Здесь могла быть гугл форма" }
        };


        public Dictionary<string, string> GetNews()
        {
             return _news;
            
        }

    }
}
