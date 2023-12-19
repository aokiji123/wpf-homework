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

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var viewModel = (MainViewModel)DataContext;
            viewModel.AddNumber(button.Content.ToString());
        }

        private void BackspaceButton_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = (MainViewModel)DataContext;
            viewModel.Backspace();
        }

        private void CButton_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = (MainViewModel)DataContext;
            viewModel.Clear();
        }
    }
}
