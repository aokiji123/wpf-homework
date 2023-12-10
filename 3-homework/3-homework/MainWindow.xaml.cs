using System;
using System.Windows;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;

namespace _3_homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Uri imageUri = new Uri("https://www.wfla.com/wp-content/uploads/sites/71/2023/05/GettyImages-1389862392.jpg?w=2560&h=1440&crop=1", UriKind.RelativeOrAbsolute);
            BitmapImage bitmapImage = new BitmapImage(imageUri);
            imageView.Source = bitmapImage;

            blurSlider.ValueChanged += BlurSlider_ValueChanged;
        }

        private void BlurSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double blurRadius = blurSlider.Value;
            ApplyBlurEffect(blurRadius);
        }

        private void ApplyBlurEffect(double blurRadius)
        {
            BlurEffect blurEffect = new BlurEffect();
            blurEffect.Radius = blurRadius;
            imageView.Effect = blurEffect;
        }
    }
}
