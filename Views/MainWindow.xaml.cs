using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Lista.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((sender as TextBox)!.Text == string.Empty)
                placeHolderLabel.Visibility = Visibility.Visible;
            else
                placeHolderLabel.Visibility = Visibility.Hidden;
        }

        private void placeHolderLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            textBox.Focus();
        }
    }
}