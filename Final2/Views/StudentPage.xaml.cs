using Final2.ViewModels;
using Final2.Models;

namespace Final2.Views
{

    public partial class StudentPage : ContentPage
    {
        public StudentPage(EnrollmentViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        private async void OnNextClicked(object sender, EventArgs e)
        {
            var viewModel = (EnrollmentViewModel)BindingContext;
            await Navigation.PushAsync(new CoursePage(viewModel));
        }
    }
}