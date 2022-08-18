using System.Windows.Input;

namespace ObjectsCreator
{


    public class AuthorizationViewModel : ViewModel
    {
        private string _password;
        private string _login;

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
        }


        private void RegisterAction(object parameter)
        {

        }
    }
}
