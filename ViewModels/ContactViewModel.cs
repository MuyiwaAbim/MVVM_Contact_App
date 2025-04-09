using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVM_Contact_App.Models;
using System.Collections.ObjectModel;
using System.Xml.Linq;
using Contact = MVVM_Contact_App.Models.Contact; // Alias for your Contact model

namespace MVVM_Contact_App.ViewModels
{
    public partial class ContactViewModel : ObservableObject
    {
        public ObservableCollection<Contact> Contacts { get; } = new();

        [ObservableProperty] private string name;
        [ObservableProperty] private string email;
        [ObservableProperty] private string phoneNumber;
        [ObservableProperty] private string description;

        [ObservableProperty] private Contact selectedContact;

        public void AddContact()
        {
            var contact = new Contact
            {
                Name = Name,
                Email = Email,
                PhoneNumber = PhoneNumber,
                Description = Description
            };
            Contacts.Add(contact);
            ClearFields();
        }

        public void UpdateContact(Contact contact)
        {
            contact.Name = Name;
            contact.Email = Email;
            contact.PhoneNumber = PhoneNumber;
            contact.Description = Description;
        }

        public void LoadContact(Contact contact)
        {
            SelectedContact = contact;
            Name = contact.Name;
            Email = contact.Email;
            PhoneNumber = contact.PhoneNumber;
            Description = contact.Description;
        }

        private void ClearFields()
        {
            Name = Email = PhoneNumber = Description = string.Empty;
        }
    }
}
