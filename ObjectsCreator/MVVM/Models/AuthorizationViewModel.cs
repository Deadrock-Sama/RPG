using Core.DBInteraction;
using Core.Users;
using ObjectsCreator.MVVM.Components;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace ObjectsCreator.MVVM.Models
{


    public class AuthorizationViewModel : ViewModel
    {
        public Visibility AuthorizeVisibility { get; }
        public Visibility RegisterVisibility { get; } = Visibility.Hidden;


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
        public ICommand Authorize { get; }

        private string _login;
        private string _password;

        private int _adminID;

        private readonly RepositoryShell _repositoryShell;
        private readonly AppNavigator _navigator;

        private readonly ObjectTablesViewModel _objectTablesViewModel;

        public AuthorizationViewModel(AppNavigator navigator, RepositoryShell repositoryShell, ObjectTablesViewModel objectTablesViewModel)
        {

            var dependencyObject = new DependencyObject();
               
            Register = new RelayCommand(RegisterAction);
            Authorize = new RelayCommand(AuthorizeAction);
            _navigator = navigator;
            _repositoryShell = repositoryShell;
            _objectTablesViewModel = objectTablesViewModel;

            var admin = _repositoryShell.GetAll<User>().FirstOrDefault(p => p.IsAdmin);

            if (admin == null)
            {
                //Считается ли это, что модель знает, как реализован вид?
                RegisterVisibility = Visibility.Visible;
                AuthorizeVisibility = Visibility.Hidden;
            }
            else
            {
                //По идее, для большей безопасности можно было бы хранить пароли в отдельной таблице?
                _adminID = admin.Id;
                
            }
        }

        private void RegisterAction(object parameter)
        {

            if (!string.IsNullOrEmpty(_login) && !string.IsNullOrEmpty(_password))
            {

                var newAdmin = new User();
                newAdmin.IsAdmin = true;
                newAdmin.Login = _login;
                newAdmin.Password = CreateMD5(_password);

                _repositoryShell.AddOrUpdate(newAdmin);

                _navigator.Show(_objectTablesViewModel);
            }
            else
            {
                MessageBox.Show("Необходимо указать логин и пароль");

            }
        }

        private void AuthorizeAction(object parameter)
        {
            
            var admin = _repositoryShell.GetAll<User>().FirstOrDefault(e => e.Id == _adminID);

            if (admin == null)
            {
                MessageBox.Show("Произошла ошибка при обращении к базе данных");
                Environment.Exit(0);
            }

            var password = PasswordBoxAssistant.GetBoundPassword(parameter as DependencyObject);
            

            if (admin.Login == Login && admin.Password == CreateMD5(password))
            {
                _navigator.Show(_objectTablesViewModel);
            }
            else
            {
                MessageBox.Show("Неправильные данные");

            }
        }

        private string CreateMD5(string input)
        {

            var md5 = System.Security.Cryptography.MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);
            
            return BitConverter.ToString(hashBytes)
                .ToLower()
                .Replace("-", "");

        }
    }
}
