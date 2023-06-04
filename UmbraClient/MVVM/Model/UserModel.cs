using UmbraClient.Core;

namespace UmbraClient.MVVM.Model
{
    internal sealed class UserModel : ObservableObject
    {
        public string Username { get; set; } = string.Empty;
        public string UID { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

    }
}
