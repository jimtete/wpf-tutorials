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
using Microsoft.Win32;

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
        var fileDialog = new OpenFileDialog();
        fileDialog.Filter = "C# Source Files | *.cs";
        fileDialog.Multiselect = true;
        
        var success = fileDialog.ShowDialog();

        if (success.HasValue && success.Value)
        {
            var path = fileDialog.FileNames;
            var fileName = fileDialog.SafeFileNames;
            
            tbInfo.Text = fileName[1];
        }
    }
}