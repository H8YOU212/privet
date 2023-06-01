using Avalonia;
using OOO_debili.Models;
using OOO_debili.Views;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace OOO_debili.ViewModels
{
    internal class LoginWindowViewModel : ViewModelBase
    {
        public string Login { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        private string _message = string.Empty;
        public string Message
        {
            get => _message;
            set => this.RaiseAndSetIfChanged(ref _message, value);
        }
        public LoginWindow Owner { get; set; }
        public ReactiveCommand<Unit, Unit> AuthCommand { get; }
        public LoginWindowViewModel(LoginWindow _owner)
        {
            Owner = _owner;
            AuthCommand = ReactiveCommand.Create(Auth);
        }
        public void Auth()
        {
            OOOpiratoContext dbContext = new OOOpiratoContext();
            User? user = dbContext.Users.Where(u => u.Login == Login && u.Password == Password).FirstOrDefault();
            if (user == null)
            {
                Message = "Неправильный логин или пароль";
                return;
            }
            switch (user.Role)
            {
                case "1":
                    Message = string.Empty;
                    MainWindow mainWindow = new MainWindow()
                    {
                        DataContext = new MainWindowViewModel(user)
                    };
                    mainWindow.Show();
                    Owner.Close();
                    break;
                case "2":
                    Message = string.Empty;
                    StaffsWindow staffWindow = new StaffsWindow()
                    {
                        DataContext = new StaffsWindowViewModel(user)
                    };
                    staffWindow.Show();
                    Owner.Close();
                    break;
            }
            
                
            
        }
    }
}
