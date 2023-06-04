using System.Windows.Media;
using UmbraClient.Core;

namespace UmbraClient.MVVM.Model;

internal sealed class MessageModel : ObservableObject
{
    public string Username { get; set; } = "Anon";
    public string UsernameColor { get; set; } = "LightGray";
    public string ImageSource { get; set; } = "https://icon-library.com/images/anonymous-avatar-icon/anonymous-avatar-icon-25.jpg";
    public string Message { get; set; } = string.Empty;
    public TimeOnly Date { get; set; } = TimeOnly.FromDateTime(DateTime.Now);
    public bool IsNativeOrigin { get; set; }
    public bool? IsFirstMessage { get; set; }

}