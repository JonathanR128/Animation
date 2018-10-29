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


            int counterPropertyChangedBox2 = 0; 


            Box1.PropertyChanged += (sender, e) =>
            {
                Box1Height = Box1.Y;
                Box1Width = Box1.X;              
            };

            Box2.PropertyChanged += (sender, e) =>
            {
                if (counterPropertyChangedBox2 < 5)
                {
                    ++counterPropertyChangedBox2;
                    Box2StartWidth = Box2.X;
                    Box2StartHeight = Box2.Y;
                }

                Box2Height = Box2.Y;
                Box2Width = Box2.X;
            };

            Box3.PropertyChanged += (sender, e) =>
            {
                Box3Height = Box3.Y;
                Box3Width = Box3.X;
            };

            Box4.PropertyChanged += (sender, e) =>
            {
                Box4Height = Box4.Y;
                Box4Width = Box4.X;
            };

        }

        public double Box1Width { get; set; }
        public double Box1Height { get; set; }

        public double Box2Width { get; set; }
        public double Box2Height { get; set; }
        public double Box2StartWidth { get; set; }
        public double Box2StartHeight { get; set; }

        public double Box3Width { get; set; }
        public double Box3Height { get; set; }

        public double Box4Width { get; set; }
        public double Box4Height { get; set; }

        public async Task MoveAsync()
        {
             await MoveToCenter();
        }

        public async Task MoveToCenter()
        {
            await Box2.TranslateTo(-400, 80, 2000, Easing.Linear);
            await Box1.TranslateTo(140, 20, 2000, Easing.Linear);
            await Box2.TranslateTo(Box2StartWidth - Box2Width, Box2StartHeight - Box2Height, 3000, Easing.Linear); // moves box 2 back in Start Position
        }
    }
}
