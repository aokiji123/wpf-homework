using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace _6_homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Key CTRL_R = Key.R;
        private Key CTRL_G = Key.G;
        private Key CTRL_B = Key.B;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == CTRL_R && Keyboard.Modifiers == ModifierKeys.Control)
            {
                ColorButton.Background = Brushes.Red;
            }
            else if (e.Key == CTRL_G && Keyboard.Modifiers == ModifierKeys.Control)
            {
                ColorButton.Background = Brushes.Green;
            }
            else if (e.Key == CTRL_B && Keyboard.Modifiers == ModifierKeys.Control)
            {
                ColorButton.Background = Brushes.Blue;
            }
        }
    }
}
