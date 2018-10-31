using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mase
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            int counterPropertyChangedBox2 = 0;
            int counterPropertyChangedBox3 = 0;
            int counterPropertyChangedBox4 = 0;

            Name1 = "Box1";
            Name2 = "Box2";
            Name3 = "Box3";
            Name4 = "Box4";

            Box4.Color = System.Drawing.Color.Purple;

            MoveAsync();
            Box1StartHeight = 0;
            Box1StartWidth = 0;

            Box1.PropertyChanged += (sender, e) =>
            {
                Box1Height = Box1.Y;
                Box1Width = Box1.X;
            };
            Box2.PropertyChanged += (sender, e) =>
            {
                if (counterPropertyChangedBox2 < 4)
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
                if (counterPropertyChangedBox3 < 4)
                {
                    ++counterPropertyChangedBox3;
                    Box3StartWidth = Box3.X;
                    Box3StartHeight = Box3.Y;
                }
                Box3Height = Box3.Y;
                Box3Width = Box3.X;
            };
            Box4.PropertyChanged += (sender, e) =>
            {
                if (counterPropertyChangedBox4 < 3)
                {
                    ++counterPropertyChangedBox4;
                    Box4StartWidth = Box4.X;
                    Box4StartHeight = Box4.Y;
                }
                Box4Height = Box4.Y;
                Box4Width = Box4.X;
            };
        }

        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public string Name4 { get; set; }
        public string NameChanger { get; set; }

        public BoxView LeftBox { get; set; }
        public BoxView MiddleLeftBox { get; set; }
        public BoxView MiddleRightBox { get; set; }
        public BoxView RightBox { get; set; }

        public double Box1Width { get; set; }
        public double Box1Height { get; set; }
        public double Box1StartWidth { get; set; }
        public double Box1StartHeight { get; set; }

        public double Box2Width { get; set; }
        public double Box2Height { get; set; }
        public double Box2StartWidth { get; set; }
        public double Box2StartHeight { get; set; }

        public double Box3Width { get; set; }
        public double Box3Height { get; set; }
        public double Box3StartWidth { get; set; }
        public double Box3StartHeight { get; set; }

        public double Box4Width { get; set; }
        public double Box4Height { get; set; }
        public double Box4StartWidth { get; set; }
        public double Box4StartHeight { get; set; }

        public async Task MoveAsync()
        {
            Box4.BackgroundColor = System.Drawing.Color.Purple;

            await MoveToCenterInRowRightNames();
            await MoveBoxes();
        }

        public async Task MoveToCenter()
        {
            await Box1.TranslateTo(Box4StartWidth / 2, Box4StartHeight / 2, 1000, Easing.Linear); // bewirkt nichts, weil der den ersten Befehl hier nicht packt..

            await Box1.TranslateTo(Box4StartWidth / 2, Box4StartHeight / 2, 2000, Easing.Linear);
            await Box2.TranslateTo(-(Box4StartWidth / 2), Box4StartHeight / 2, 2000, Easing.Linear);
            await Box3.TranslateTo(Box4StartWidth / 2, -(Box4StartHeight / 2), 2000, Easing.Linear);
            await Box4.TranslateTo(-(Box4StartWidth / 2), -(Box4StartHeight / 2), 2000, Easing.Linear);
        }

        public async Task MoveToCenterInRow()
        {
            await Box1.TranslateTo(Box4StartWidth / 2, Box4StartHeight / 2, 1000, Easing.Linear); // bewirkt nichts, weil der den ersten Befehl hier nicht packt..
            await Box1.TranslateTo((Box4StartWidth / 2) - 80, Box4StartHeight / 2, 2000, Easing.Linear);
            await Box2.TranslateTo(-(Box4StartWidth / 2) - 30, Box4StartHeight / 2, 2000, Easing.Linear);
            await Box3.TranslateTo((Box4StartWidth / 2) + 30, -(Box4StartHeight / 2), 2000, Easing.Linear);
            await Box4.TranslateTo(-(Box4StartWidth / 2) + 80, -(Box4StartHeight / 2), 2000, Easing.Linear);
        }

        public async Task MoveBackInCorners()
        {
            Box1.Color = System.Drawing.Color.CornflowerBlue;
            await Box1.TranslateTo(-Box1Width, -Box1Height, 2000, Easing.Linear);                                // moves box 1 back in Start Poition 
            await Box2.TranslateTo(Box2StartWidth - Box2Width, Box2StartHeight - Box2Height, 2000, Easing.Linear); // moves box 2 back in Start Position
            await Box3.TranslateTo(Box3StartWidth - Box3Width, Box3StartHeight - Box3Height, 2000, Easing.Linear); // moves box 3 back in Start Position
            await Box4.TranslateTo(Box4StartWidth - Box4Width, Box4StartHeight - Box4Height, 2000, Easing.Linear); // moves box 4 back in Start Position
        }

        public async Task FindByNameAndMove()
        {
            var BoxView = this.FindByName<BoxView>(Name1);
            await BoxView.TranslateTo(1000, 10, 4000, Easing.Linear);
        }

        public void StoreNames()
        {
            LeftBox = this.FindByName<BoxView>(Name1);
            MiddleLeftBox = this.FindByName<BoxView>(Name2);
            MiddleRightBox = this.FindByName<BoxView>(Name3);
            RightBox = this.FindByName<BoxView>(Name4);
        }

        public async Task MoveWithRightNames()
        {
            StoreNames();
            await LeftBox.TranslateTo(0, 100, 2000, Easing.Linear);
            await MiddleLeftBox.TranslateTo(0, -50, 2000, Easing.Linear);
            await MiddleRightBox.TranslateTo(0, 50, 2000, Easing.Linear);
            await RightBox.TranslateTo(0, -50, 2000, Easing.Linear);
        }

        public async Task MoveToCenterInRowRightNames()
        {
            StoreNames();
            // await Box1.TranslateTo(Box4StartWidth / 2, Box4StartHeight / 2, 1000, Easing.Linear); // bewirkt nichts, weil der den ersten Befehl hier nicht packt..
            await LeftBox.TranslateTo(100, 100, 2000, Easing.Linear);
            await MiddleLeftBox.TranslateTo(-100, 100, 2000, Easing.Linear);
            await MiddleRightBox.TranslateTo(100, -100, 2000, Easing.Linear);
            await RightBox.TranslateTo(-100, -100, 2000, Easing.Linear);
            Name1 = "Box4";
            Name2 = "Box3";
            Name3 = "Box2";
            Name4 = "Box1";

        }

        public async Task MoveBoxes()
        {
            StoreNames();
            await LeftBox.TranslateTo(10, 10, 3000, Easing.Linear);
            await MiddleLeftBox.TranslateTo(10, 10, 3000, Easing.Linear);
            await MiddleRightBox.TranslateTo(10, 10, 3000, Easing.Linear);
            await RightBox.TranslateTo(10, 10, 3000, Easing.Linear);
        }
    }
}
