using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListView : ContentPage
    {
        public ListView()
        {
            InitializeComponent();
            List<Item> itemList = new List<Item>
            {
                new Item{ Text = "Tresc1", Description = "opis1"},
                new Item{ Text = "Tresc2", Description = "opis2"},
                new Item{ Text = "Tresc3", Description = "opis3"},
                new Item{ Text = "Tresc4", Description = "opis4"},
            };
            ItemListView.ItemsSource = itemList;
        }
    }
}