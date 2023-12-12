using System.Windows;
using System.Windows.Controls;

namespace _4_homework
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

        private void BackspaceButton_Click(object sender, RoutedEventArgs e)
        {
            if (DisplayText.Text.Length > 0)
            {
                DisplayText.Text = DisplayText.Text.Remove(DisplayText.Text.Length - 1);
            }
        }

        private void CButton_Click(object sender, RoutedEventArgs e )
        {
            if (DisplayText.Text.Length > 0)
            {
                DisplayText.Text = "";
            }
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            DisplayText.Text += button.Content.ToString();
        }
    }
}
