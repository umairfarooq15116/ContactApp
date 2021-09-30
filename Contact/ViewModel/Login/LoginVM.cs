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
    public class LoginVM : ViewModelBase
    {
        private Users users = null;
        private UserRepo _repository;
        public string Name
        {
            get
            {
                return users.Name;
            }
            set
            {
                users.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Password
        {
            get
            {
                return users.Password;
            }
            set
            {
                users.Password = value;
                OnPropertyChanged("Password");
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
