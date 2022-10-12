using System.Windows.Input;

namespace Xaminals;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        BindingContext = this;      // nødvendig for at Command binding fungerer
    }

    public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
}
