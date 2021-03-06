using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using LabS3.Pages;
using LabS3.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LabS3.Pages.Menus
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddContact : Page
    {
         private List<ContactUser> contactUsers = new List<ContactUser>();

        public AddContact()
        {
            this.InitializeComponent();
            contactUsers = new List<ContactUser>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = inputName.Text;
            string age = inputAge.Text;
            string address = inputAddress.Text;
            contactUsers.Add(new ContactUser(name, age, address));

            successText.Text = "You have submitted new contact successfully!";
        }

        private void BackButton(object sender, RoutedEventArgs e)
        {
            Layout.MainNavigationFrame.Navigate(typeof(Pages.Menus.Contact), contactUsers);
        }

    }
}
