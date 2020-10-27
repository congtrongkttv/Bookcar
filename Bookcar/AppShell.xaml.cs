using System;
using System.Collections.Generic;
using Bookcar.ViewModels;
using Bookcar.Views;
using Xamarin.Forms;

namespace Bookcar
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
