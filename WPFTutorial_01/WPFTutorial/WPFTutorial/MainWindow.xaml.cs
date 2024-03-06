using System.Collections;
using System.Windows;
using WPFTutorial.View;

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

    private void BtnNormal_OnClick(object sender, RoutedEventArgs e)
    {
        var normalWindow = new NormalWindow();
        normalWindow.Show();
    }

    private void BtnModal_OnClick(object sender, RoutedEventArgs e)
    {
        var modalWindow = new ModalWindow(this, txtInput.Text);
        Opacity = 0.4;
        modalWindow.ShowDialog();
        Opacity = 1;
        if (modalWindow.Success)
        {
            txtInput.Text = modalWindow.Input;
        }
        
    }
}