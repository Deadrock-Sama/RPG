using RPG.Components.Users;
using RPG.DBInteraction;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ObjectsCreator
{

    public partial class Authorization : Window
    {
        public bool IsAuthorized { get; set; }
        
        private string _AdminLogin;
        private string _AdminPassword;
        private RepositoryShell _repo;
        public Authorization(RepositoryShell Repo)
        {
            _repo = Repo;
            InitializeComponent();
            setAdminData();
            
        }

        private void setAdminData()
        {
            //Может быть только 1 админ
            var admin = _repo.GetAll<User>().FirstOrDefault(p => p.IsAdmin);

            if (admin == null)
            {
                Register.Visibility = Visibility.Visible;
                LoginButton.Visibility = Visibility.Hidden;
            }
            else {

                _AdminLogin = admin.Login;
                _AdminPassword = admin.Password;

            }
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (_AdminLogin == Login.Text && _AdminPassword == Password.Password)
            {
                IsAuthorized = true;
                Close();

            }
            else
            {
                MessageBox.Show("Неправильные данные");

            }
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {

            if (Login.Text != "" && Password.Password != "")
            {

                var newAdmin = new User();
                newAdmin.IsAdmin = true;
                newAdmin.Login = Login.Text;
                newAdmin.Password = Password.Password;

                _repo.AddOrUpdate(newAdmin);

                IsAuthorized = true;
                Close();
            }
            else
            {
                MessageBox.Show("Необходимо указать логин и пароль");

            }
            

                    

        }


    }
}
