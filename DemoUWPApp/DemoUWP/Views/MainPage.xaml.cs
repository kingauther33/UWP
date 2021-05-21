using System;

using DemoUWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace DemoUWP.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
