using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _4_homework
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _displayText;

        public string DisplayText
        {
            get => _displayText;
            set
            {
                _displayText = value;
                OnPropertyChanged();
            }
        }

        public void Backspace()
        {
            if (DisplayText.Length > 0)
            {
                DisplayText = DisplayText.Remove(DisplayText.Length - 1);
            }
        }

        public void Clear()
        {
            DisplayText = "";
        }

        public void AddNumber(string number)
        {
            DisplayText += number;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
