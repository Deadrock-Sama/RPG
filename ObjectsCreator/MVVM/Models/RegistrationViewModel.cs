using Core.DBInteraction;
using Core.Users;
using ObjectsCreator.MVVM.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace ObjectsCreator.MVVM.Models
{
    public class RegistrationViewModel : ValidatableViewModel
    {
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
        public ICommand Register { get; }
        private string _login;
        private string _password;

        private readonly RepositoryShell _repositoryShell;
        private readonly AppNavigator _navigator;

        private readonly ObjectTablesViewModel _objectTablesViewModel;
        public RegistrationViewModel(AppNavigator navigator, RepositoryShell repositoryShell, ObjectTablesViewModel objectTablesViewModel)
        {
            Register = new RelayCommand(RegisterAction);
            _navigator = navigator;
            _repositoryShell = repositoryShell;
            _objectTablesViewModel = objectTablesViewModel;

        }


        private void RegisterAction(object parameter)
        {
            ClearError(nameof(Login));
            ClearError(nameof(Password));

            var dataEntered = !string.IsNullOrEmpty(_login) && !string.IsNullOrEmpty(_password);
            if (string.IsNullOrEmpty(_login))
            {
                SetError("Поле должно быть заполнено", nameof(Login));
            }
            if (string.IsNullOrEmpty(_password))
            {
                SetError("Поле должно быть заполнено", nameof(Password));
            }

            if (dataEntered)
            {
                var loginExist = _repositoryShell.GetAll<User>().FirstOrDefault(e => e.Login == _login) != null;
                if (loginExist)
                {
                    SetError("Такой логин уже есть", nameof(Login));
                    return;
                }
            }
            else
            {
                return;
            }



            var newAdmin = new User();
            newAdmin.IsAdmin = true;
            newAdmin.Login = _login;
            newAdmin.Password = new Cryptograph().CreateMD5(_password);

            _repositoryShell.AddOrUpdate(newAdmin);

            _navigator.Show(_objectTablesViewModel);
        }
    }
}
