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
using Practical.Models;
using Newtonsoft.Json;
using Windows.Storage;
using Windows.ApplicationModel;
using System.IO;
using System.Threading.Tasks;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Practical.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Question1 : Page
    {
        public Question1()
        {
            this.InitializeComponent();
            Employee_GetData();
        }

        public static async Task<string> ReadFile(string fileName)
        {
            // Tao file employee.json trong package cua may tinh
            //var storage = Windows.Storage.ApplicationData.Current.LocalFolder;

            var storage = Windows.ApplicationModel.Package.Current.InstalledLocation;
            var demoFile = await storage.CreateFileAsync(fileName, Windows.Storage.CreationCollisionOption.OpenIfExists);
            return await FileIO.ReadTextAsync(demoFile);
        }

        private async void Employee_GetData()
        {
            string jsonString = await ReadFile("employee.json");
            EmployeeList employees = JsonConvert.DeserializeObject<EmployeeList>(jsonString);
            Question1LV.ItemsSource = employees.employee_list;
        }
    }
}
