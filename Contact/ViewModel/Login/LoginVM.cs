using Contact.DAL.User;
using Contact.ViewModel.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Contact.Model;
using System.Windows.Controls;
using Contact.Repository.Generic;
using System.Windows;

namespace Contact.ViewModel.Login
{
    public class LoginVM:ViewModelBase
    {
        private string _name;
        private Users users = null;
        private UserRepo _repository;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged("Name");
            }
        }
        private ICommand _loginCommand;
        public ICommand LoginCommand
        {
            get
            {
                if (_loginCommand == null)
                    _loginCommand = new RelayCommand(param => VerifyUsernamePassword(), null);
                return _loginCommand;
            }
        }
        public LoginVM()
        {
            users = new Users();
            _repository = new UserRepo();
        }

        public void VerifyUsernamePassword()
        {
            if(users != null)
            {
                users.Name = Name;
                users.Password = Password;
                try
                {
                    if (_repository.VerifyUserNamePassword(users))
                    {
                        MessageBox.Show("Valid Username and Password.");
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username and Password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured while saving. ");
                }
            }
        }
    }
}
