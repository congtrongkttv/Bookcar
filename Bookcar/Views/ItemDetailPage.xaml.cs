using System.ComponentModel;
using Xamarin.Forms;
using Bookcar.ViewModels;

namespace Bookcar.Views
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