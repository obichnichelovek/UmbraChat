namespace UmbraClient;

public partial class App : Application
{
    private protected void Application_Startup(object sender, StartupEventArgs e)
    {
        Login login = new();
        login.Show();
        login.IsVisibleChanged += (sender, e) =>
        {
            if (login.AccessLabel.Content == "Access granted!")
            {
                MainWindow mainWindow = new();
                mainWindow.Show();
            }
        };
    }
}