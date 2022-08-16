using RPG.Components.PlayerNS;
using RPG.Components.PlayerNS.Classes;
using RPG.Components.PlayerNS.PlayerPage.PlayerInfo;
using RPG.DBInteraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramAPI.Views;
using GameUser = RPG.Components.Users.User;

namespace TelegramAPI.TelegramBotNS
{
    public class TelegramCommandsReader
    {

        private ITelegramBotClient _Bot;
        private Message _Message;
        private IRepositoryShell _Repo;
        private string _LastCommand;
        private GameUser _User;
        private Player _Player;
        private CancellationTokenSource _MainCancellationTokenSource;
        private CancellationTokenSource _SubCancellationTokenSource = new CancellationTokenSource();

        private string[] _creatingPlayerMessages = new string[4] { "Введи имя:",
                                                                   "Введи описание:",
                                                                   "Выбери класс \n /warrior \n /archer \n /wizard",
                                                                   "Поздравляю. Теперь вы полноценный игрок!"};

        private int _messagesCounter = 1;
        public TelegramCommandsReader(ITelegramBotClient Bot, IRepositoryShell repo, CancellationTokenSource MainCancellationTokenSource)
        {
            _Bot = Bot;
            _Repo = repo;
            _MainCancellationTokenSource = MainCancellationTokenSource;
        }

        public async Task ReadMainCommand(Message message)
        {
            _Message = message;

            if (_Message.Type != Telegram.Bot.Types.Enums.MessageType.Text)
            {
                await SendAboutText();
                return;
            }
            _SetCurrentUser();
            switch (message.Text.ToLower())
            {
                case "/start":
                    await ExecuteStartCommand();
                    await WriteAboutPlayer();
                    break;
                case "/createplayer":
                    await StartCreatingPlayer();
                    break;
                case "/startjourney":
                    await StartJourney();
                    break;
            }


            _LastCommand = message.Text.ToLower();

        }

        private async Task<Message> ExecuteStartCommand()
        {
            string name = _Message.From.Username;
            string password = _Message.From.Id.ToString();
            string login = _Message.From.Id.ToString();

            string _MessageToSend = "";

            if (_User != null)
            {
                _MessageToSend = $"Вижу ты уже бывалый, {name}! Готов продолжить приключение?";

            }
            else
            {

                _User = new GameUser();

                _User.Login = login;
                _User.Password = password;

                _Repo.AddOrUpdate(_User);


                _MessageToSend = $"Добро пожаловать в наше приключениe, {name}";

            }

            return await _Bot.SendTextMessageAsync(_Message.Chat, _MessageToSend);

        }

        private async Task<Message> WriteAboutPlayer()
        {
            _Player = _Repo.GetAll<Player>().FirstOrDefault(c => c.User == _User);
            string _MessageToSend = "";
            if (_Player == null) {
                _MessageToSend = "Нажми, чтобы создать персонажа /createPlayer";
            }
            else
            {
                _MessageToSend = new PlayerView(_Player).View;
            }
            return await _Bot.SendTextMessageAsync(_Message.Chat, _MessageToSend);
        }

        private async Task<Message> SendAboutText()
        {
            var MessageAboutText = "Хорошо, хорошо, мы все поняли, у тебя есть лишняя хромосома. Теперь пиши нормально, пожалуйста";
            return await _Bot.SendTextMessageAsync(_Message.Chat, MessageAboutText);
        }

        private async Task StartCreatingPlayer()
        {
            _SetCurrentUser();

            if (_Player != null && _Player.Id != 0)
            {
                await _Bot.SendTextMessageAsync(_Message.Chat, "У вас создан персонаж. Для смены имени используйте /name");
                return;
            }
            _MainCancellationTokenSource.Cancel();
            _Player = new Player();
            _Player.Info = new PlayerBasicInfo();
            _Player.User = _User;


            await StartDialogAboutPlayer();
            _MainCancellationTokenSource = new CancellationTokenSource();
            _Bot.StartReceiving(HandleUpdateAsync, HandleErrorAsync, null, _MainCancellationTokenSource.Token);

        }

        private async Task StartJourney()
        { 
            
        }

        private async Task StartDialogAboutPlayer()
        {
            await _Bot.SendTextMessageAsync(_Message.Chat, _creatingPlayerMessages[0]);
            //_SubCancellationTokenSource = new CancellationTokenSource();
            //_Bot.StartReceiving(CreatingPlayer_HandleUpdateAsync, CreatingPlayer_HandleErrorAsync, null, _SubCancellationTokenSource.Token);
        }

        private async Task CreatingPlayer_HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {

            // Некоторые действия
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {

                await ReadPlayerCreatingCommand(update.Message);
                
            }
            cancellationToken.ThrowIfCancellationRequested();
        }
        private async Task CreatingPlayer_HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }

        private async Task ReadPlayerCreatingCommand(Message message)
        {


            if (_Message.Type != Telegram.Bot.Types.Enums.MessageType.Text)
            {
                await SendAboutText();
                return;
            }
            _SetCurrentUser();
            
          
            
            switch (_messagesCounter)
            {
                
                case 2:
                    await SetPlayerName(message);
                    await _Bot.SendTextMessageAsync(_Message.Chat, _creatingPlayerMessages[1]);
                    break;
                case 3:    
                    await SetPlayerDescription(message);
                    await _Bot.SendTextMessageAsync(_Message.Chat, _creatingPlayerMessages[2]);
                    break;
                case 4:
                    await SetPlayerClass(message); 
                    await _Bot.SendTextMessageAsync(_Message.Chat, _creatingPlayerMessages[3]);
                    break;
            }
            
            _messagesCounter++;
            if (_messagesCounter == 5)
            {
                _SubCancellationTokenSource.Cancel();
                
            }


        }

        private async Task<Message> SetPlayerName(Message message)
        {

            _Player.Info.Name = message.Text;
            _Repo.AddOrUpdate(_Player.Info);
            return await _Bot.SendTextMessageAsync(_Message.Chat, $"Устновлено имя {message.Text}!");

        }

        private async Task<Message> SetPlayerDescription(Message message)
        {

            _Player.Info.Description = message.Text;
            _Repo.Update(_Player.Info);
            return await _Bot.SendTextMessageAsync(_Message.Chat, $"Устновлено описание {message.Text}!");

        }

        private async Task<Message> SetPlayerClass(Message message)
        {

            Dictionary<string, PlayerClass> classes = new Dictionary<string, PlayerClass>();


            classes.Add("/warrior", new Warrior());
            classes.Add("/archer", new Archer());
            classes.Add("/wizard", new Wizard());

            var ChosenClass = classes[message.Text];

            _Repo.Add(ChosenClass);
            _Player.PlayerClass = ChosenClass;
            _Repo.AddOrUpdate(_Player);
            return await _Bot.SendTextMessageAsync(_Message.Chat, $"Выбран класс {(ChosenClass).ToString()}!");

        }

        public async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {

            cancellationToken.ThrowIfCancellationRequested();


            // Некоторые действия
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
               await ReadMainCommand(update.Message);

            }
        }
        public async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            // Некоторые действия
             Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }


        private void _SetCurrentUser()
        {
            if (_Message == null || _User != null ) { return; }

            string Login = _Message.From.Id.ToString();
            _User = _Repo.GetAll<GameUser>().FirstOrDefault(u => u.Login == Login);

            

        }

    }
}
