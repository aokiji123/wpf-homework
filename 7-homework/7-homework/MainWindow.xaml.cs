using System.Collections.ObjectModel;
using System.Windows;

namespace _7_homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Student
        {
            public int Number { get; set; }
            public string Name { get; set; }
            public bool IsPresent { get; set; }
            public bool IsLate { get; set; }
            public bool IsAbsent { get; set; }
            public string ExamGrade { get; set; }
            public string LessonGrade { get; set; }
        }

        public ObservableCollection<Student> Students { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Students = new ObservableCollection<Student>()
            {
                new Student { Number = 1, Name = "John Doe Doedovich", IsPresent = true, ExamGrade = "-", LessonGrade = "12" },
                new Student { Number = 2, Name = "Anna Smith Smithovna", IsPresent = true, ExamGrade = "-", LessonGrade = "11" },
                new Student { Number = 3, Name = "Mark Cukerberg Cukerbergovich", IsLate = true, ExamGrade = "12", LessonGrade = "11" },
                new Student { Number = 4, Name = "Bohdan Tolmachov Evgenievich", IsPresent = true, ExamGrade = "-", LessonGrade = "12" },
            };

            DataContext = this;
        }
    }
}
