namespace P1.Primitives;

using System.ComponentModel;
using System.Windows.Controls;

public partial class Component : UserControl, INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
}