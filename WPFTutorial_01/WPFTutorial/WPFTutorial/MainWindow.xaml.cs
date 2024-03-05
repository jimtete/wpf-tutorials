using System.Windows;
using WinForms = System.Windows.Forms;


namespace WPFTutorial;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnFire_OnClick(object sender, RoutedEventArgs e)
    {
        var dialog = new FolderBrowserDialog();
        dialog.InitialDirectory =
            "C:\\Users\\jim-t\\GitHub\\wpf-tutorials\\WPFTutorial_01\\WPFTutorial\\WPFTutorial\\";
        var dialogResult = dialog.ShowDialog();

        if (dialogResult == WinForms.DialogResult.OK)
        {
            //Do something
        }
    }
}