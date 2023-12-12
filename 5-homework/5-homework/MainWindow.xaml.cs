using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace _5_homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BitmapImage[] images;
        private int currentIndex = 0;
        private double scale = 1.0;
        private string[] imagePaths = new string[]
        {
            "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/a704f043-a0fb-4652-b8ee-6bc362dae5a9/d5j1z44-0c21f546-39eb-48f9-8230-0b4500c7b88f.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcL2E3MDRmMDQzLWEwZmItNDY1Mi1iOGVlLTZiYzM2MmRhZTVhOVwvZDVqMXo0NC0wYzIxZjU0Ni0zOWViLTQ4ZjktODIzMC0wYjQ1MDBjN2I4OGYuanBnIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.O_Xy26vERxse28DI8z2gwy-z0M9aBlGMXJSOwbi8_nM",
            "https://upload.wikimedia.org/wikipedia/ru/f/ff/Yamakasi_%28%D0%B0%D0%BB%D1%8C%D0%B1%D0%BE%D0%BC%29.jpeg",
            "https://d128mjo55rz53e.cloudfront.net/media/images/blog-breed-munchkin_2.max-400x400.format-jpeg.jpg",
            "https://climate.esa.int/media/images/High-Resolution-L.2e16d0ba.fill-400x400-c100.format-jpeg.jpg",
            "https://d128mjo55rz53e.cloudfront.net/media/images/blog-breed-beagle_2.max-400x400.format-jpeg.jpg"
        };

        public MainWindow()
        {
            InitializeComponent();
            LoadImages();
            ShowImage();
        }

        private async void LoadImages()
        {
            images = new BitmapImage[imagePaths.Length];
            for (int i = 0; i < imagePaths.Length; i++)
            {
                var image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(imagePaths[i], UriKind.Absolute);
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.EndInit();
                images[i] = image;
            }

            await Task.Delay(100);
            ShowImage();
        }

        private void ShowImage()
        {
            if (images.Length == 0) return;
            imageView.Source = images[currentIndex];
            UpdateButtonsState();
        }

        private void UpdateButtonsState()
        {
            prevButton.IsEnabled = currentIndex > 0;
            nextButton.IsEnabled = currentIndex < images.Length - 1;
        }

        private void Prev_Click(object sender, RoutedEventArgs e)
        {
            if (currentIndex > 0) currentIndex--;
            ShowImage();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (currentIndex < images.Length - 1) currentIndex++;
            ShowImage();
        }

        private void IncreaseSize_Click(object sender, RoutedEventArgs e)
        {
            scale = Math.Min(scale * 1.1, 5.0);
            UpdateImageSize();
        }

        private void DecreaseSize_Click(object sender, RoutedEventArgs e)
        {
            scale = Math.Max(scale / 1.1, 0.1); 
            UpdateImageSize();
        }

        private void UpdateImageSize()
        {
            if (images.Length == 0) return;

            imageView.Width = images[currentIndex].PixelWidth * scale;
            imageView.Height = images[currentIndex].PixelHeight * scale;
        }

        private void OpacitySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (blurEffect != null)
            {
                blurEffect.Radius = e.NewValue * 20; 
            }
        }
    }
}
