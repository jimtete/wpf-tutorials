using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFTutorial;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window, INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public MainWindow()
    {
        DataContext = this;
        InitializeComponent();
    }
    private string _boundText;

    public string BoundText
    {
        get => _boundText;
        set
        {
            _boundText = value;
            OnPropertyChanged();
        }
    }

    private void BtnSet_OnClick(object sender, RoutedEventArgs e)
    {
        BoundText = "set from code!";
    }

    private void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}