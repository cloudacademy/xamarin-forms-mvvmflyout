using MVVMFlyout.Models;
using MVVMFlyout.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMFlyout.Views
{
    public partial class StudentPage : ContentPage
    {
        public Language Item { get; set; }

        public StudentPage()
        {
            InitializeComponent();
            //BindingContext = new StudentViewModel();
            Button saveBtn = new Button();
        }

    }
}