using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using OOO_debili.ViewModels;
using OOO_debili.Views;

namespace OOO_debili
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                LoginWindow loginwindow = new LoginWindow();
                loginwindow.DataContext = new LoginWindowViewModel(loginwindow);
                desktop.MainWindow = loginwindow;
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}