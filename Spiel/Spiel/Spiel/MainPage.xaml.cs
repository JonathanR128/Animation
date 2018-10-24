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

            await Task.WhenAll(
               FirstImage.TranslateTo(400, 50, 1000, Easing.SinInOut),
               SecondImage.TranslateTo(400, 150, 1000, Easing.SinInOut)
             );

            await Task.WhenAll(
                ThirdImage.TranslateTo(500, 200, 1500, Easing.Linear),
                SecondImage.RotateTo(90, 1500, Easing.Linear)
             );

            SecondImage.AnchorX = 1.1;
            await Task.WhenAll(
                FirstImage.TranslateTo(700, 50, 1500, Easing.SinInOut),
                 SecondImage.RotateTo(180, 1500, Easing.Linear)

                );
        }


        public void MakeImage()
        {
            
        }

    }
}
