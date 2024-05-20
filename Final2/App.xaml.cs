using Final2.Models;
using Final2.ViewModels;
using System.IO;
using Final2.Views;

namespace Final2
{
    public partial class App : Application
    {
        private static Database database;

        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FinalProject.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            var enrollmentViewModel = new EnrollmentViewModel();
            MainPage = new NavigationPage(new StudentPage(enrollmentViewModel));
        }
    }
}
