using System;
using System.Windows;
using Contact.DAL.User;
using Contact.Models;

namespace Contact
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Users users = new Users();
            users.Name = "Admin";
            users.Email = "admin12@yahoo.com";
            users.Password = "1234";
            UserDAL.RegisterUser(users);
            Console.Read();
        }
    }
}
