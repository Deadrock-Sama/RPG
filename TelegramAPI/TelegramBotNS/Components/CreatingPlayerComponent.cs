using Core.DBInteraction;
using Core.PlayerNS;
using Core.PlayerNS.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telegram.Bot;

namespace TelegramAPI.TelegramBotNS
{
    // занаследовать от базового, public
    internal class CreatingPlayerComponent : IGameComponent
    {
        // naming, readonly
        private SessionMessageSender _Sender;
        // naming, readonly
        private RepositoryShell _Repo;
        // naming
        private CreatingPlayerStage _CurrentStage = CreatingPlayerStage.Start;
        // naming, readonly
        private Player _Player;
        public string TranslationCommand => "/createplayer";


        private string[] _availableComponents = new string[1] { "/start" };

        private string[] _creatingPlayerMessages = new string[5] { "Введи имя:",
                                                                   "Введи описание:",
                                                                   "Выбери класс \n /warrior \n /archer \n /wizard",
                                                                   "Поздравляю. Теперь вы полноценный игрок!",
                                                                   "Персонаж уже создан"};

        public async void HandleCommand(string command)
        {
            switch (_CurrentStage)
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
            _CurrentStage = CreatingPlayerStage.SettingName;
        }

        private async void HandleSettingName(string name)
        {
            _Player.Info.Name = name;
            _Repo.AddOrUpdate(_Player.Info);
            await _Sender.SendMessage($"Установлено имя: {name}!");
            await _Sender.SendMessage(_creatingPlayerMessages[1]);
            _CurrentStage = CreatingPlayerStage.SettingDescription;
        }

        private async void HandleSettingDescription(string description)
        {
            _Player.Info.Description = description;
            _Repo.AddOrUpdate(_Player.Info);
            await _Sender.SendMessage($"Установлено описание: {description}!");
            await _Sender.SendMessage(_creatingPlayerMessages[2]);
            _CurrentStage = CreatingPlayerStage.SettingClass;

        }

        private async void HandleSettingClass(string gameClass)
        { 
           
            Dictionary<string, PlayerClass> classes = new Dictionary<string, PlayerClass>();


            classes.Add("/warrior", new Warrior());
            classes.Add("/archer", new Archer());
            classes.Add("/wizard", new Wizard());

            var ChosenClass = classes[gameClass];
            
            _Player.PlayerClass = ChosenClass;
            _Repo.AddOrUpdate(_Player.Info);
            await _Sender.SendMessage($"Установлен класс: {ChosenClass.ToString()}!");
            await _Sender.SendMessage(_creatingPlayerMessages[3]);
            _CurrentStage = CreatingPlayerStage.Completed;
        }

        private async void HandleCommandAfterCompletion()
        {
            await _Sender.SendMessage(_creatingPlayerMessages[4]);
        }

        public bool IsAnotherComponentAvailable(string componentName) => _availableComponents.Contains(componentName);

        public bool IsComponentAvailable() => _CurrentStage != CreatingPlayerStage.Completed;

        public void SendStartMessage()
        {
            throw new NotImplementedException();
        }

        public CreatingPlayerComponent(SessionMessageSender sender, RepositoryShell repo)
        {
            _Sender = sender;
            _Repo = repo;
        }
    }
    // можно поместить внутрь класса
    enum CreatingPlayerStage
    {
        Start,
        SettingName,
        SettingDescription,
        SettingClass,
        Completed
    }
}
