using System.Collections.ObjectModel;
using System.Windows;

namespace WPFTutorial;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        DataContext = this;
        _entries = new ObservableCollection<string>();

        InitializeComponent();
    }

    private ObservableCollection<string> _entries;

    public ObservableCollection<string> Entries
    {
        get { return _entries; }
        set { _entries = value; }
    }

    private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
    {
        _entries.Add(txtEntry.Text);
    }

    private void BtnDelete_OnClick(object sender, RoutedEventArgs e)
    {
        var selectedItem = (string)lvEntries.SelectedItem;
        _entries.Remove(selectedItem);
    }

    private void BtnClear_OnClick(object sender, RoutedEventArgs e)
    {
        _entries.Clear();
    }
}