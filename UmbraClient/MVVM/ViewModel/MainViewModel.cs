using System.Collections.ObjectModel;
using UmbraClient.MVVM.Model;
using UmbraClient.Core;
using UmbraClient.Net;
using System.Windows.Input;
using System.Security;
using UmbraClient.Repos;
using System.Net;
using System.Security.Principal;

namespace MVVM.ViewModel;

internal sealed class MainViewModel : ObservableObject
{
    private string message = string.Empty;
    private string username = "admin";
    private SecureString password = null!;
    private string usernameColor = "Light" + colors[new Random().Next(0, colors.Length)];
    private ContactModel? selectedContact;
    private readonly Server server;
    private string errorMessage = null!;
    private bool isViewVisible = true;
    private readonly UserRepository userRepository;

    public ObservableCollection<UserModel> Users { get; set; }
    public ObservableCollection<MessageModel> Messages { get; set; }
    public ObservableCollection<ContactModel> Contacts { get; set; }

    public RelayCommand SendCommand { get; set; }
    public RelayCommand ConnectToServerCommand { get; set; }
    public ICommand LoginCommand { get; }
    public RelayCommand ShowPasswordCommand { get; } = null!;
    public RelayCommand RememberPasswordCommand { get; } = null!;

    private bool CanExecuteLoginCommand(object obj)
    {
        if (string.IsNullOrWhiteSpace(Username) || Username.Length < 3 || Password == null || Password!.Length < 3)
            return false;

        return true;
    }

    private void ExecuteLoginCommand(object obj)
    {
        var isValidUser = userRepository.AuthenticateUser(new NetworkCredential(Username, Password));
        if (isValidUser)
        {
            Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(Username), null);
            isViewVisible = false;
            ErrorMessage = "Access granted!";
        }
        else ErrorMessage = "* Invalid username or password";
    }


    private static readonly string[] colors = new string[5]
    {
        "Red",
        "Green",
        "Blue",
        "Gray",
        "Yellow"
    };

    public string Username
    {
        get { return username; }
        set { username = value; OnPropChanged(); }
    }

    public SecureString Password { get => password; set { password = value; OnPropChanged(); } }

    public ContactModel? SelectedContact
    {
        get { return selectedContact; }
        set { selectedContact = value!; OnPropChanged(); }
    }

    public string Message
    {
        get { return message; }
        set { message = value; OnPropChanged(); }
    }

    public string UsernameColor
    {
        get { return usernameColor; }
        set { usernameColor = value; OnPropChanged(); }
    }
    public string ErrorMessage { get => errorMessage; set { errorMessage = value; OnPropChanged(); } }

    public bool IsViewVisible { get => isViewVisible; set { isViewVisible = value; OnPropChanged(); } }

    public MainViewModel()
    {
        Users = new();
        Messages = new();
        Contacts = new();

        userRepository = new UserRepository();
        LoginCommand = new RelayCommand(ExecuteLoginCommand, CanExecuteLoginCommand);

        server = new();
        server.ConnectedEvent += UserConnected;
        server.MessageReceivedEvent += MessageReceived;
        server.UserDisconnectEvent += RemoveUser;
        ConnectToServerCommand = new(x => server.ConnectToServer(Username), x => !string.IsNullOrEmpty(Username));

        SendCommand = new(x =>
        {
            if (!string.IsNullOrEmpty(Message))
            {
                server.SendMessageToServer(Message);
                UsernameColor = "Light" + colors[new Random().Next(0, colors.Length)];
                Message = string.Empty;
            }
        });

        Contacts.Add(new ContactModel
        {
            Username = "Public Chat",
            Messages = Messages
        });
    }

    private void RemoveUser()
    {
        var uid = server.PacketReader.ReadMessage();
        var user = Users.Where(x => x.UID == uid).FirstOrDefault();
        Application.Current.Dispatcher.Invoke(() => Users.Remove(user!));
    }

    private void MessageReceived()
    {
        var message = server.PacketReader.ReadMessage();
        Application.Current.Dispatcher.Invoke(() => Messages.Add(new MessageModel
        {
            Message = message,
            Username = Username,
            UsernameColor = UsernameColor
        }));
    }

    private void UserConnected()
    {
        UserModel user = new()
        {
            Username = server.PacketReader.ReadMessage(),
            UID = server.PacketReader.ReadMessage()
        };

        if (!Users.Any(x => x.UID == user.UID))
            Application.Current.Dispatcher.Invoke(() => Users.Add(user));
    }
}