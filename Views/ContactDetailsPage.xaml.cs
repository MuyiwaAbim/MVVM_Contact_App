using ContactManagerApp.ViewModels;

namespace ContactManagerApp.Views
{
    public partial class ContactDetailsPage : ContentPage
    {
        private ContactViewModel _viewModel;

        public ContactDetailsPage(ContactViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            BindingContext = _viewModel;
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            if (_viewModel.SelectedContact != null)
                _viewModel.UpdateContact(_viewModel.SelectedContact);

            await Navigation.PopAsync();
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}