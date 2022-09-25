using Core.DBInteraction;
using Core.PlayerNS;
using Core.PlayerNS.Classes;
using Core.PlayerNS.InventoryNS;
using Core.Users;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TelegramAPI.TelegramBotNS.Components
{
    // занаследовать от базового, public
    public class CreatingPlayerComponent : BasicComponent
    {

        
        private CreatingPlayerStage _currentStage = CreatingPlayerStage.Start;
        
        public override string TranslationCommand => "/createplayer";

        private string[] _availableComponents = new string[1] { "/start" };

        private string[] _creatingPlayerMessages = new string[5] { "Введи имя:",
                                                                   "Введи описание:",
                                                                   "Выбери класс \n /warrior \n /archer \n /wizard",
                                                                   "Поздравляю. Теперь вы полноценный игрок! Начать игру /StartGame",
                                                                   "Ну хватит дурить, начинай уже игру /StartGame"};
        public CreatingPlayerComponent(SessionMessageSender sender, RepositoryShell repositoryShell, User user) : base(sender, repositoryShell, new Player() { Info = new(), User = user })
        {
            

        }
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
        public override bool IsAnotherComponentAvailable(string componentName) => _availableComponents.Contains(componentName);

        public override bool IsComponentAvailable() => _currentStage != CreatingPlayerStage.Completed;

        public override async void SendStartMessage()
        {
            await _sender.SendMessage("Создаем игрока!");
        }

        private async void HandleStart()
        {
            await _sender.SendMessage(_creatingPlayerMessages[0]);
            _currentStage = CreatingPlayerStage.SettingName;
        }

        private async void HandleSettingName(string name)
        {
            _player.Info.Name = name;
            _repositoryShell.AddOrUpdate(_player.Info);
            await _sender.SendMessage($"Установлено имя: {name}!");
            await _sender.SendMessage(_creatingPlayerMessages[1]);
            _currentStage = CreatingPlayerStage.SettingDescription;
        }

        private async void HandleSettingDescription(string description)
        {
            _player.Info.Description = description;
            _repositoryShell.AddOrUpdate(_player.Info);
            await _sender.SendMessage($"Установлено описание: {description}!");
            await _sender.SendMessage(_creatingPlayerMessages[2]);
            _currentStage = CreatingPlayerStage.SettingClass;

        }

        private async void HandleSettingClass(string gameClass)
        {

            Dictionary<string, PlayerClasses> classes = new();


            classes.Add("/warrior", PlayerClasses.Warrior);
            classes.Add("/archer", PlayerClasses.Archer);
            classes.Add("/wizard", PlayerClasses.Wizard);

            var ChosenClass = classes[gameClass];

            _player.PlayerClass = ChosenClass;
            SetInventory();
            
            _repositoryShell.AddOrUpdate(_player);
            await _sender.SendMessage($"Установлен класс: {ChosenClass.ToString()}!");
            await _sender.SendMessage(_creatingPlayerMessages[3]);

            _currentStage = CreatingPlayerStage.Completed;
        }

        private async void HandleCommandAfterCompletion()
        {
            await _sender.SendMessage(_creatingPlayerMessages[4]);
        }

        private void SetInventory()
        {

            var invConfigurator = new InventoryConfigurator(_player, _repositoryShell);
            invConfigurator.SetStartInventory();
        
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
