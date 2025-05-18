using System.Globalization;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace PW_Lab1;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
    }
    
    private void OnAddClicked(object? sender, RoutedEventArgs e) {
        ResultTextBox.Text = TryGetNumbers(out var a, out var b) ? (a + b).ToString(CultureInfo.CurrentCulture) : "Błąd danych!";
    }

    private void OnSubtractClicked(object? sender, RoutedEventArgs e) {
        ResultTextBox.Text = TryGetNumbers(out var a, out var b) ? (a - b).ToString(CultureInfo.CurrentCulture) : "Błąd danych!";
    }

    private bool TryGetNumbers(out double a, out double b)
    {
        var parsedA = double.TryParse(FirstNumberTextBox.Text, out a);
        var parsedB = double.TryParse(SecondNumberTextBox.Text, out b);
        return parsedA && parsedB;
    }
}