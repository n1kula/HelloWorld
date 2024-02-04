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
    public partial class ControlsPage : ContentPage
    {
        public ControlsPage()
        {
            InitializeComponent();

            var label = new Label()
            {
                Text = "First LAbel",
                FontSize = 12,
                FontAttributes = FontAttributes.Bold,
                FontFamily = "Arial",
                TextColor = Color.Blue,
            };
            ContentContainer.Children.Add(label);

            var entry = new Entry()
            {
                Keyboard = Keyboard.Numeric,
                Placeholder = "Wartosc numeryczna"
            };

            ContentContainer.Children.Add(entry);

            var button = new Button()
            {
                Text = "kliknij mnie"
            };
            ContentContainer.Children.Add(button);

            var checkbox = new CheckBox()
            {
                IsChecked = true,
                HorizontalOptions = LayoutOptions.End
            };

            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}