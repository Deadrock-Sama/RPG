using ObjectsCreator.MVVM.Components;
using System;
using System.Windows;
using System.Windows.Input;

namespace ObjectsCreator.MVVM.Models
{
    public class MainContentViewModel : ViewModel
    {
        public AppNavigator Navigator { get; }
        public ICommand Back { get; }
        public ICommand Forward { get; }
        public ICommand Close { get; }
        
        public bool ForwardAbility
        {
            get => _forwardAbility;
            set
            {
                _forwardAbility = value;
                Notify();
            }
        }
        public bool BackAbility
        {
            get => _backAbility;
            set
            {
                _backAbility = value;
                Notify();
            }
        }

        private bool _backAbility;
        private bool _forwardAbility;

        public MainContentViewModel(AppNavigator navigator)
        {
            Navigator = navigator;
            Back = new RelayCommand(BackAction);
            Forward = new RelayCommand(ForwardAction);
            Close = new RelayCommand(CloseAction);

        }

        private void BackAction(object parameter)
        { 
            Navigator.Back();
            SetNavigationAbilities();
        }
        private void ForwardAction(object parameter)
        {
            Navigator.Forward();
            SetNavigationAbilities();
            
        }
        private void CloseAction(object parameter)
        {
            
            Navigator.Close();
            SetNavigationAbilities();

        }
        private void SetNavigationAbilities()
        {
            BackAbility = Navigator.isBackAble();
            ForwardAbility = Navigator.isForwardAble();
        }


    }
}
