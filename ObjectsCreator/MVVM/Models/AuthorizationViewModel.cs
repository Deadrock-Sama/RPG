using Core.DBInteraction;
using Core.Users;
using ObjectsCreator.MVVM.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace ObjectsCreator.MVVM.Models
{


    public class AuthorizationViewModel : ViewModel
    {
        public bool AuthorizeVisibility { get; }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                Notify();
            }
        }
        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                Notify();
            }
        }

        public ICommand Authorize { get; }
        public ICommand Register { get; }

        private string _login;
        private string _password;

        private List<int> _adminsID;

        private readonly RepositoryShell _repositoryShell;
        private readonly AppNavigator _navigator;

        private readonly ObjectTablesViewModel _objectTablesViewModel;
        private readonly RegistrationViewModel _registrationViewModel;

        public AuthorizationViewModel(AppNavigator navigator, RepositoryShell repositoryShell, ObjectTablesViewModel objectTablesViewModel, RegistrationViewModel registrationViewModel)
        {
               
            Register = new RelayCommand(RegisterAction);
            Authorize = new RelayCommand(AuthorizeAction);
            _navigator = navigator;
            _repositoryShell = repositoryShell;
            _objectTablesViewModel = objectTablesViewModel;
            _registrationViewModel = registrationViewModel;

            _adminsID = _repositoryShell
                        .GetAll<User>()
                        .Where(p => p.IsAdmin)
                        .Select(p => p.Id)
                        .ToList();           
            
        }

        private void RegisterAction(object parameter)
        {
            _navigator.Show(_registrationViewModel);
        }

        private void AuthorizeAction(object parameter)
        {
            
            var admin = _repositoryShell.GetAll<User>().FirstOrDefault(e => _adminsID.Contains(e.Id));

            if (admin == null)
            {
                MessageBox.Show("Произошла ошибка при обращении к базе данных");
                Environment.Exit(0);
            }

            var password = PasswordBoxAssistant.GetBoundPassword(parameter as DependencyObject);
            

            if (admin.Login == Login && admin.Password == new Cryptograph().CreateMD5(password))
            {
                _navigator.Show(_objectTablesViewModel);
            }
            else
            {
                MessageBox.Show("Неправильные данные");

            }
        }

       
    }
}
