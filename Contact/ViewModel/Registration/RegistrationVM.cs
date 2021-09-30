using Contact.Model;
using Contact.Repository.Generic;
using Contact.ViewModel.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Contact.ViewModel.Registration
{
    public class RegistrationVM : ViewModelBase
    {
        private UserRepo _repository;
        private Users users = null;
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

        public string Email
        {
            get
            {
                return users.Email;
            }
            set
            {
                users.Email = value;
                OnPropertyChanged("Email");
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

        private string _confirmPassword;
        public string ConfirmPassword
        {
            get
            {
                return _confirmPassword;
            }
            set
            {
                _confirmPassword = value;
                OnPropertyChanged("ConfirmPassword");
            }
        }

        private ICommand _registerCommand;
        public ICommand RegisterCommand
        {
            get
            {
                if (_registerCommand == null)
                    _registerCommand = new RelayCommand(param => SaveUser(), null);

                return _registerCommand;
            }
        }

        public RegistrationVM()
        {
            users = new Users();
            _repository = new UserRepo();
        }

        public void SaveUser()
        {
            if (users != null)
            {
                try
                {
                    _repository.RegisterUser(users);
                    MessageBox.Show("New record successfully saved.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured while saving. ");
                }
            }
        }
    }
}
