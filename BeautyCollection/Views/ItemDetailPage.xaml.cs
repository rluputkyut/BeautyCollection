using System.ComponentModel;
using Xamarin.Forms;
using BeautyCollection.ViewModels;

namespace BeautyCollection.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
