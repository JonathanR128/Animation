using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Spiel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //await MainGrid.TranslateTo(200, 300, 1000, Easing.Linear);

            //await MainGrid.TranslateTo(400, 400, 7000, Easing.Linear);

            MainGrid.AnchorY = 5; 
            await MainGrid.RotateTo(200, 2000, Easing.Linear);
        }
    }
}
