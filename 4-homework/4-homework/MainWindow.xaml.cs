using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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
    }
}
