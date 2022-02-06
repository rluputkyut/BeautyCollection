using System;
using System.Collections.Generic;
using BeautyCollection.ViewModels;
using BeautyCollection.Views;
using Xamarin.Forms;

namespace BeautyCollection
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
