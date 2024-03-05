using System.Windows;

namespace WPFTutorial;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        lvEntries.Items.Add("a");
        lvEntries.Items.Add("b");
        lvEntries.Items.Add("c");
    }

    private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
    {
        lvEntries.Items.Add(txtEntry.Text);
        txtEntry.Clear();
    }

    private void BtnDelete_OnClick(object sender, RoutedEventArgs e)
    {
        var index = lvEntries.SelectedIndex;
        lvEntries.Items.RemoveAt(index);
    }

    private void BtnClear_OnClick(object sender, RoutedEventArgs e)
    {
        lvEntries.Items.Clear();
    }
}