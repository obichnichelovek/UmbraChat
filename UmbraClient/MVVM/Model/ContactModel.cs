using System.Collections.ObjectModel;
using UmbraClient.Core;

namespace UmbraClient.MVVM.Model;

internal sealed class ContactModel
{
    public string Username { get; set; } = "Chat";
    public string ImageSource { get; set; } = "https://static.vecteezy.com/system/resources/previews/005/337/802/original/icon-symbol-chat-outline-illustration-free-vector.jpg";
    public ObservableCollection<MessageModel> Messages { get; set; } = null!;
    public string? LastMessage => GetLastMessage();

    private string GetLastMessage()
    {
        string? lastMessage = Messages.Last()?.Message;
        if (lastMessage != null | lastMessage!.Length >= 20)
        {
            return lastMessage[..17] + "...";
        }

        return lastMessage;
    }

}