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
    }
}