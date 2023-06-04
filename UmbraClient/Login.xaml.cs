using System.Windows.Controls;
using System.Windows.Input;

namespace UmbraClient;

public partial class Login : Window
{
    public Login()
    {
        InitializeComponent();
    }

    private protected void Border_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.LeftButton == MouseButtonState.Pressed) DragMove();
    }

    private protected void Window_SizeChanged(object sender, SizeChangedEventArgs e)
    {
        BorderThickness = (Width == MaxWidth | WindowState == WindowState.Maximized) ? new Thickness(10) : new Thickness(0);
    }

    private protected void WindowButton_Click(object sender, RoutedEventArgs e)
    {
        switch (((Button)sender).Content)
        {
            case "＿":
                WindowState = WindowState.Minimized;
                break;

            case "▭":
                WindowState = (WindowState == WindowState.Maximized) ? WindowState.Normal : WindowState.Maximized;
                break;

            case "⨉":
                Close();
                break;
        }
    }
}