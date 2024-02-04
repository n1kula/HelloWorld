using System.ComponentModel;
using HelloWorld.ViewModels;
using Xamarin.Forms;

namespace HelloWorld.Views
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