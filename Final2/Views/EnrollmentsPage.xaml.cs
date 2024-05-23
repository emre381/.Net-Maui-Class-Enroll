using Final2.ViewModels;
using Final2.Models;
namespace Final2.Views
{

    public partial class EnrollmentsPage : ContentPage
    {
        public EnrollmentsPage(EnrollmentViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        private void goBack_Clicked(object sender, EventArgs e)
        {
           Navigation.PopToRootAsync();

        }

        private void deleteButton_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                var enrollment = button.BindingContext as Enroll;
                if (enrollment != null)
                {
                    var viewModel = BindingContext as EnrollmentViewModel;
                    if(viewModel != null)
                    {
                        viewModel.Enrollments.Remove(enrollment);
                    }
                }
            }

        }
    }
}