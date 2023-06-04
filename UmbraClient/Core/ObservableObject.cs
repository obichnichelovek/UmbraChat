using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace UmbraClient.Core;

internal abstract class ObservableObject : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropChanged([CallerMemberName] string propName = null!)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}