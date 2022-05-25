using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMFlyout.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationHeader : ContentView
    {
        public NavigationHeader()
        {
            InitializeComponent();
        }
    }
}