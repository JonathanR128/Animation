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
            //await SecondGrid.TranslateTo(100, 0, 1000, Easing.Linear);

            //MainGrid.AnchorY = 5; 
            //await MainGrid.RotateTo(360, 2000, Easing.Linear);
            //MainGrid.BackgroundColor = System.Drawing.Color.Black;

            //SecondGrid.AnchorY = 2;
            //await SecondGrid.RotateTo(360, 3000, Easing.CubicOut);

            //ThirdGrid.AnchorX = 2;
            //await ThirdGrid.RotateTo(360, 4000, Easing.Linear);
            //MainGrid.AnchorY = 3;
            //SecondGrid.AnchorY = 3;
            //ThirdGrid.AnchorY = 3;
            //MainGrid.TranslateTo(100, 0, 2000, Easing.Linear);
            //SecondGrid.TranslateTo(-100, 0, 2000, Easing.Linear);
            //await ThirdGrid.TranslateTo(100, 0, 2000, Easing.Linear);
            //await MainGrid.TranslateTo(0, 100, 2000, Easing.Linear);
            //await MainGrid.RotateTo(360, 2000, Easing.Linear);
            //await SecondGrid.RotateTo(360, 2000, Easing.Linear);
            //await ThirdGrid.RotateTo(360, 2000, Easing.Linear);

            //await SecondGrid.RotateTo(1440, 2000, Easing.SinInOut);
            //SecondGrid.BackgroundColor = System.Drawing.Color.Purple;

            //MainGrid.AnchorY = 2.3;
            //SecondGrid.AnchorY = 2.3;
            //ThirdGrid.AnchorY = -1.3;
            //await MainGrid.RotateTo(180, 1000, Easing.BounceOut);

            //MainGrid.TranslateTo(100, 0, 2000, Easing.Linear);
            //SecondGrid.TranslateTo(100, 0, 2000, Easing.Linear);
            //SecondGrid.RotateTo(180, 2000, Easing.Linear);
            //await ThirdGrid.TranslateTo(100, 0, 2000, Easing.Linear);

            //ThirdGrid.RotateTo(360, 2000, Easing.Linear);


            //await SecondGrid.RotateTo(1440, 2000, Easing.SinInOut);
            //SecondGrid.BackgroundColor = System.Drawing.Color.Purple;

            //MainGrid.AnchorY = 1.7;
            //SecondGrid.AnchorY = 2.3;
            //ThirdGrid.AnchorY = -0.7;
            //MainGrid.RotateTo(180, 2000, Easing.Linear);
            //ThirdGrid.RotateTo(180, 2000, Easing.Linear);




            //await SecondGrid.RotateTo(1440, 2000, Easing.SinInOut);    
            //SecondGrid.BackgroundColor = System.Drawing.Color.Purple;

            //MainGrid.AnchorY = 2.3;
            //SecondGrid.AnchorY = 2.3;
            //ThirdGrid.AnchorY = -0.7;
            //MainGrid.RotateTo(180, 2000, Easing.Linear);
            //await SecondGrid.RotateTo(180, 2000, Easing.Linear);
            //SecondGrid.AnchorY = -1.3;
            //await SecondGrid.RotateTo(180, 4000, Easing.Linear);

            //await SecondGrid.RotateTo(1440, 2000, Easing.SinInOut);  
            //SecondGrid.BackgroundColor = System.Drawing.Color.Purple;

            //MainGrid.AnchorY = 2.3;
            //SecondGrid.AnchorY = 2.3;
            //ThirdGrid.AnchorY = -1.3;

            //await ThirdGrid.RotateTo(180, 2000, Easing.Linear);

            //SecondGrid.RotateTo(1440, 2000, Easing.SinInOut);

            /////////////////////////////////////////////////////
            ///Gutes Gleichzeitig 


            //SecondGrid.BackgroundColor = System.Drawing.Color.Purple;

            //MainGrid.AnchorY = 1.1;
            //SecondGrid.AnchorY = -0.1;
            //ThirdGrid.AnchorY = -0.1;

            //MainGrid.RotateTo(180, 1000, Easing.Linear);
            //SecondGrid.RotateTo(180, 1000, Easing.Linear);
            //MainGrid.TranslateTo(50, 0, 1500, Easing.Linear);
            //SecondGrid.TranslateTo(-50, 0, 1500, Easing.Linear);

            /////////////////////////////////////////////////////////////
            ///Gute Rotation nach Versuch Wert für Anchor beim Debuggen rauszufinden funktioniert es nicht mehr...

            SecondGrid.BackgroundColor = System.Drawing.Color.Purple;

            MainGrid.AnchorY = 1.1;
            SecondGrid.AnchorY = -0.1;
            ThirdGrid.AnchorY = -0.1;
            
            MainGrid.RotateTo(180, 1000, Easing.Linear);
            SecondGrid.RotateTo(180, 1000, Easing.Linear);
            MainGrid.TranslateTo(35, 0, 1500, Easing.Linear);
            await SecondGrid.TranslateTo(-35, 35, 1500, Easing.Linear);
            await ThirdGrid.TranslateTo(0, -35, 500, Easing.Linear);

            ThirdGrid.AnchorX = 1.7;
            ThirdGrid.AnchorY = 0.5;

            ThirdGrid.RotateTo(180, 1000, Easing.Linear);
           await SecondGrid.TranslateTo(35, 35, 2500, Easing.Linear);


              MainGrid.AnchorX = -0.7;
              MainGrid.AnchorY = 0.5;

            await MainGrid.RotateTo(180, 2000, Easing.Linear);






        }
    }
}
