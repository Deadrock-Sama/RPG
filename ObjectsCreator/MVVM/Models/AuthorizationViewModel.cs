using Core.DBInteraction;
using Core.Users;
using ObjectsCreator.MVVM.Components;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace ObjectsCreator.MVVM.Models
{


    public class AuthorizationViewModel : ViewModel
    {
        public Visibility AuthorizeVisibility { get; }
        public Visibility RegisterVisibility { get; }
        public bool IsAuthorized { get; set; }

        private string _login;
        private string _password;

        private string _bdLogin;
        private string _bdPassword;

        private RepositoryShell _repo;
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


        public AuthorizationViewModel()
        {
            Register = new RelayCommand(RegisterAction);
            Authorize = new RelayCommand(AuthorizeAction);

            var admin = _repo.GetAll<User>().FirstOrDefault(p => p.IsAdmin);

            if (admin == null)
            {
                RegisterVisibility = Visibility.Visible;
                AuthorizeVisibility = Visibility.Hidden;
            }
            else
            {

                _bdLogin = admin.Login;
                _bdPassword = admin.Password;


            }
        }


        private void RegisterAction(object parameter)
        {
            if (_login != "" && _password != "")
            {

                var newAdmin = new User();
                newAdmin.IsAdmin = true;
                newAdmin.Login = _login;
                newAdmin.Password = _password;

                _repo.AddOrUpdate(newAdmin);

                IsAuthorized = true;
                //   Close();
            }
            else
            {
                MessageBox.Show("Необходимо указать логин и пароль");

            }
        }

        private void AuthorizeAction(object parameter)
        {
            if (_login == _bdLogin && _password == _bdPassword)
            {
                IsAuthorized = true;
                //Close();

            }
            else
            {
                MessageBox.Show("Неправильные данные");

            }
        }
    }
}
