using ContactManagerApp.ViewModels;

namespace ContactManagerApp.Views
{
    public partial class AddContactPage : ContentPage
    {
        private ContactViewModel _viewModel;

        public AddContactPage(ContactViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            BindingContext = _viewModel;
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            _viewModel.AddContact();
            await Navigation.PushAsync(new ContactsPage(_viewModel));
        }

        private async void OnViewContactsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactsPage(_viewModel));
        }
    }
}
