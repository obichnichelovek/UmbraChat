using System.Security;
using System.Windows.Controls;

namespace UmbraClient.CustomControls;

public partial class BindablePasswordBox : UserControl
{
    public static readonly DependencyProperty PasswordProperty =
        DependencyProperty.Register("Password", typeof(SecureString), typeof(BindablePasswordBox));
    public SecureString Password
    {
        get => (SecureString)GetValue(PasswordProperty);
        set => SetValue(PasswordProperty, value);
    }

    public BindablePasswordBox()
    {
        InitializeComponent();
        PasswordTextBox.PasswordChanged += OnPasswordChanged;

    }

    private void OnPasswordChanged(object sender, RoutedEventArgs e)
    {
        Password = PasswordTextBox.SecurePassword;
    }
}