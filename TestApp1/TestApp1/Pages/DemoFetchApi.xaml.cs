using System.Net.Http;
using TestApp1.Services;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using TestApp1.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TestApp1.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DemoFetchApi : Page
    {
        public DemoFetchApi()
        {
            this.InitializeComponent();
        }

        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {
            // 1 danh sach cac items truyen vao LIST lay tu api file json
            //List<Item> lists = new List<Item>();
            //lists.Add(new Item { id = 1, icon = "\uE700", name = "burger" });
            //lists.Add(new Item { id = 2, icon = "\uE701", name = "burger" });
            //lists.Add(new Item { id = 3, icon = "\uE703", name = "burger" });

            //DemoMenuItems.Items.Add(lists);
            //DemoMenuItems.ItemsSource = lists;
            // lay data tu api
            GetMenu();
        }

        public async void GetMenu() // bao hieu su dung async
        {
            HttpClient httpClient = new HttpClient();
            var respone = await httpClient.GetAsync("https://foodgroup.herokuapp.com/api/menu");
            // bat ctrinh phai thuc hien xong cau lenh nay moi thuc hien cau lenh tiep theo, ~ file_get_content() // CURL
            //if (respone.StatusCode == HttpStatusCode.OK)
            //{
            //    var stringContent = await respone.Content.ReadAsStringAsync(); // string json lay tu website
            //    // convert string thanh 1 object -- php json decode
            //    Menu menu = JsonConvert.DeserializeObject<Menu>(stringContent);
            //    DemoMenuItems.ItemsSource = menu.data;
            //}

            // Dung Service
            MenuService service = new MenuService();
            Menu menu = await service.GetMenu();
            if (menu != null)
            {
                DemoMenuItems.ItemsSource = menu.data;
            }
        } 
    }
}