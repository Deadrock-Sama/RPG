using Core.DBInteraction;
using Core.PlayerNS;
using Core.PlayerNS.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telegram.Bot;

namespace TelegramAPI.TelegramBotNS.Components
{
    // занаследовать от базового, public
    public class CreatingPlayerComponent : BasicComponent
    {

        // naming
        private CreatingPlayerStage _currentStage = CreatingPlayerStage.Start;
        // naming, readonly
        private readonly Player _player;
        public override string TranslationCommand => "/createplayer";

        private string[] _availableComponents = new string[1] { "/start" };

        private string[] _creatingPlayerMessages = new string[5] { "Введи имя:",
                                                                   "Введи описание:",
                                                                   "Выбери класс \n /warrior \n /archer \n /wizard",
                                                                   "Поздравляю. Теперь вы полноценный игрок! Начать игру /StartGame",
                                                                   "Ну хватит дурить, начинай уже игру /StartGame"};

        public override async void HandleCommand(string command)
        {
            switch (_currentStage)
            {
                case CreatingPlayerStage.Start:
                    HandleStart();
                    break;
                case CreatingPlayerStage.SettingName:
                    HandleSettingName(command);
                    break;
                case CreatingPlayerStage.SettingDescription:
                    HandleSettingDescription(command);
                    break;
                case CreatingPlayerStage.SettingClass:
                    HandleSettingClass(command);
                    break;
                case CreatingPlayerStage.Completed:
                    HandleCommandAfterCompletion();
                    break;
            }
        }

        private async void HandleStart()
        {
            await _Sender.SendMessage(_creatingPlayerMessages[0]);
            _currentStage = CreatingPlayerStage.SettingName;
        }

        private async void HandleSettingName(string name)
        {
            _player.Info.Name = name;
            _Repo.AddOrUpdate(_player.Info);
            await _Sender.SendMessage($"Установлено имя: {name}!");
            await _Sender.SendMessage(_creatingPlayerMessages[1]);
            _currentStage = CreatingPlayerStage.SettingDescription;
        }

        private async void HandleSettingDescription(string description)
        {
            _player.Info.Description = description;
            _Repo.AddOrUpdate(_player.Info);
            await _Sender.SendMessage($"Установлено описание: {description}!");
            await _Sender.SendMessage(_creatingPlayerMessages[2]);
            _currentStage = CreatingPlayerStage.SettingClass;

        }

        private async void HandleSettingClass(string gameClass)
        {

            Dictionary<string, PlayerClass> classes = new Dictionary<string, PlayerClass>();


            classes.Add("/warrior", new Warrior());
            classes.Add("/archer", new Archer());
            classes.Add("/wizard", new Wizard());

            var ChosenClass = classes[gameClass];

            _player.PlayerClass = ChosenClass;
            _Repo.AddOrUpdate(_player.Info);
            await _Sender.SendMessage($"Установлен класс: {ChosenClass.ToString()}!");
            await _Sender.SendMessage(_creatingPlayerMessages[3]);
            _currentStage = CreatingPlayerStage.Completed;
        }

        private async void HandleCommandAfterCompletion()
        {
            await _Sender.SendMessage(_creatingPlayerMessages[4]);
        }

        public override bool IsAnotherComponentAvailable(string componentName) => _availableComponents.Contains(componentName);

        public override bool IsComponentAvailable() => _currentStage != CreatingPlayerStage.Completed;

        public override async void SendStartMessage()
        {
           await _Sender.SendMessage("Создаем игрока!");
        }

        public CreatingPlayerComponent(SessionMessageSender sender, RepositoryShell repositoryShell) : base(sender, repositoryShell)
        {
       
        }
        enum CreatingPlayerStage
        {
            Start,
            SettingName,
            SettingDescription,
            SettingClass,
            Completed
        }
    }
 
}
