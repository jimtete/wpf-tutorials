using System.Windows;
using System.Windows.Controls;

namespace WPFTutorial.View;

public partial class ModalWindow : Window
{
    public bool Success { get; set; }
    public string Input { get; set; }

    public ModalWindow(Window parentWindow, string parentText)
    {
        Owner = parentWindow;
        InitializeComponent();
        txtInput.Text = parentText;
    }

    private void BtnOK_OnClick(object sender, RoutedEventArgs e)
    {
        Success = true;
        Input = txtInput.Text;
        Close();
    }

    private void BtnCancel_OnClick(object sender, RoutedEventArgs e)
    {
        Success = false;
        Close();
    }

    private void TxtInput_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        btnOK.IsEnabled = !string.IsNullOrWhiteSpace(txtInput.Text);
    }
}