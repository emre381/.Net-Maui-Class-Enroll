using Final2.ViewModels;
using Final2.Models;

namespace Final2.Views
{
    public partial class CoursePage : ContentPage
    {
        public CoursePage(EnrollmentViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        private async void OnSaveAndShowEnrollmentsClicked(object sender, EventArgs e)
        {
            var viewModel = (EnrollmentViewModel)BindingContext;
            viewModel.Enrollments.Add(new Enroll
            {
                ID = viewModel.Student.ID,
                Name = viewModel.Student.Name,
                Department = viewModel.Student.Department,
                CourseCode = viewModel.Course.CourseCode,
                CourseName = viewModel.Course.CourseName
            });
            await Navigation.PushAsync(new EnrollmentsPage(viewModel));
        }
    }
}