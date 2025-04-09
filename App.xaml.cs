namespace MVVM_Contact_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.AddContactPage(new ViewModels.ContactViewModel()));
        }
    }
}
