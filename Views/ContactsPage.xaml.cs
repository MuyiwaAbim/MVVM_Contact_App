using MVVM_Contact_App.ViewModels;
using MVVM_Contact_App.Models;
using Contact = MVVM_Contact_App.Models.Contact;

namespace MVVM_Contact_App.Views
{
    public partial class ContactsPage : ContentPage
    {
        private ContactViewModel _viewModel;

        public ContactsPage(ContactViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            BindingContext = _viewModel;
        }

        private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Contact selected)
            {
                _viewModel.LoadContact(selected);
                await Navigation.PushAsync(new ContactDetailsPage(_viewModel));
            }
        }

        private async void OnAddContactClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddContactPage(_viewModel));
        }
    }
}
