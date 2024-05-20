using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final2.Models;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Final2.ViewModels
{
    public class EnrollmentViewModel : INotifyPropertyChanged
    {
        private StudentData student = new StudentData();
        private CourseData course = new CourseData();

        public StudentData Student
        {
            get => student;
            set
            {
                student = value;
                OnPropertyChanged();
            }
        }

        public CourseData Course
        {
            get => course;
            set
            {
                course = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Enroll> Enrollments { get; set; } = new ObservableCollection<Enroll>();

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
