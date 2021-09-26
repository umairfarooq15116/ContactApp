using Contact.Model;
using Contact.Repository.Generic;
using Contact.ViewModel.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Contact.ViewModel.Registration
{
    public class RegistrationVM:ViewModelBase
    {
        private UserRepo _repository;
        private Users users=null;
        private int _userid;
        public int UserId
        {
            get
            {
                return _userid;
            }
            set
            {
                _userid = value;
                OnPropertyChanged("UserId");
            }
        }
        private string _name;
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

        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged("Email");
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
                OnPropertyChanged("Password");
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
            if(users != null)
            {
                users.Name = Name;
                users.Email = Email;
                users.Password = Password;
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
