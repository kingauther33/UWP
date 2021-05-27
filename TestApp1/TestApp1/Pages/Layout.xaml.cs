using TestApp1.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TestApp1.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Layout : Page
    {
        public Layout()
        {
            this.InitializeComponent();
        }

        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {
            //List<MenuItem> items = new List<MenuItem>();
            //items.Add(new MenuItem { Name = "Home", MenuPage = "home" });
            //items.Add(new MenuItem { Name = "Category", MenuPage = "category" });
            MN.Items.Add(new MenuItem { Name = "Home", MenuPage = "home" });
            MN.Items.Add(new MenuItem { Name = "Category", MenuPage = "category" });
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem item = MN.SelectedItem as MenuItem;

            switch (item.MenuPage)
            {
                case "home": 
                    {
                        MainFrame.Navigate(typeof(Pages.Home), "Day la trang chu");
                        break;
                    }
                case "category":
                    {
                        MainFrame.Navigate(typeof(Pages.Category), "Day la trang category");
                        break;
                    }
            }
        }
    }
}