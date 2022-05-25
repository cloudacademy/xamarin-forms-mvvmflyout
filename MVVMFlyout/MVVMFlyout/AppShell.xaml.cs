using MVVMFlyout.ViewModels;
using MVVMFlyout.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MVVMFlyout
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
            Routing.RegisterRoute(nameof(StudentPage), typeof(StudentPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
