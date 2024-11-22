
using System.ComponentModel;

namespace MauiApp1.ViewModel;

public class MainViewModel : INotifyPropertyChanged
{
    string text;
    public string Text
    {
        get => text;
        set
        {
            text = value;
            OnPropertyChanged(nameof(Text));//TODO: I am here.
        }
    }
    public event PropertyChangedEventHandler? PropertyChanged;
    void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
