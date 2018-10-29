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
            MoveAsync();


            Box1.PropertyChanged += (sender, e) =>
            {
                Box1Height = Box1.Y;
                Box1Width = Box1.X;
                
            };
        }

        public double Box1Width { get; set; }
        public double Box1Height { get; set; }

        public async Task MoveAsync()
        {
            await MoveRectanglesAsync();
        }

        public async Task MoveRectanglesAsync()
        {
           await Box1.TranslateTo(200, 80, 5000, Easing.Linear);
            await Box1.TranslateTo(- Box1Width, - Box1Height, 5000, Easing.Linear);
        }
    }
}
