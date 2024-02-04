using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataBinding : ContentPage
    {
        public DataBinding()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var fontSize = e.NewValue;
            label.FontSize = fontSize;
        }
    }
}