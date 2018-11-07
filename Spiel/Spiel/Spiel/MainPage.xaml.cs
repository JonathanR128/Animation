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

            NameLeft = "Box1";
            NameMiddleLeft = "Box2";
            NameMiddleRight = "Box3";
            NameRight = "Box4";
            VierPositionen = 3;
            DreiPositionen = 2.375;
            ZweiPositionen = 1.75;
            EinePosition = 1.125;

            Box4.Color = System.Drawing.Color.Purple;
            
            MoveAsync();     
        
        }
        public double EinePosition { get; set; }
        public double ZweiPositionen { get; set; }
        public double DreiPositionen { get; set; }
        public double VierPositionen { get; set; }

        public string NameLeft { get; set; }
        public string NameMiddleLeft { get; set; }
        public string NameMiddleRight { get; set; }
        public string NameRight { get; set; }
        public string NameChanger { get; set; }

        public BoxView LeftBox { get; set; }
        public BoxView MiddleLeftBox { get; set; }
        public BoxView MiddleRightBox { get; set; }
        public BoxView RightBox { get; set; }

      
        public async Task MoveAsync()
        {
            //Box4.BackgroundColor = System.Drawing.Color.Purple;

            //await Task.Delay(1200);
            //Box1.AnchorX = 1.5;
            //await Box1.RotateTo(180, 2000);
            //Box1.AnchorX = 0.5;
            //// Compensate for the change in AnchorX and AnchorY.
            //Box1.TranslationX += 80;
            //Box1.Rotation = 0;

            //await Box1.TranslateTo(20, 5);
            //Box1.AnchorX = 1.5;
            //await Box1.RotateTo(180, 2000, Easing.Linear);

            await MoveToCenterInRow();
            await RotateOne();
            await MoveBackInCorners();

            

        }

        public async Task RotateOne()
        {
            StoreNames();


       
            LeftBox.AnchorX = DreiPositionen;
            MiddleLeftBox.AnchorX = EinePosition;
            MiddleRightBox.AnchorX = -(EinePosition - 1);
            await Task.WhenAll(
                LeftBox.RotateTo(180, 3000),
                MiddleLeftBox.RotateTo(-180, 3000),
                MiddleRightBox.RotateTo(- 180, 3000),
                RightBox.TranslateTo(RightBox.TranslationX + 50,RightBox.TranslationY + 0, 3000)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            LeftBox.TranslationX += 150;
            MiddleLeftBox.TranslationX += 50;
            MiddleRightBox.TranslationX += -50;
                
        }

        

        public async Task MoveToCenter()
        {            
            await Box1.TranslateTo(Box4.X / 2, Box4.Y / 2, 1000, Easing.Linear); // bewirkt nichts, weil der den ersten Befehl hier nicht packt..

            await Box1.TranslateTo(Box4.X / 2, Box4.Y / 2, 2000, Easing.Linear);
            await Box2.TranslateTo(-(Box4.X / 2), Box4.Y / 2, 2000, Easing.Linear);
            await Box3.TranslateTo(Box4.X / 2, -(Box4.Y / 2), 2000, Easing.Linear);
            await Box4.TranslateTo(-(Box4.X / 2), -(Box4.Y / 2), 2000, Easing.Linear);
        }

        public async Task MoveToCenterInRow()
        {
            await Box1.TranslateTo(10, 10, 1000, Easing.Linear); // bewirkt nichts, weil der den ersten Befehl hier nicht packt..
            await Box1.TranslateTo((Box4.X / 2) - 75, Box4.Y / 2, 2000, Easing.Linear);
            await Box2.TranslateTo(-(Box4.X / 2) - 25, Box4.Y / 2, 2000, Easing.Linear);
            await Box3.TranslateTo((Box4.X / 2) + 25, -(Box4.Y / 2), 2000, Easing.Linear);
            await Box4.TranslateTo(-(Box4.X / 2) + 75, -(Box4.Y / 2), 2000, Easing.Linear);
        }

        //public async Task RotateOne()
        //{
        //    Box1.AnchorX = 2.375;
        //    Box2.AnchorX = 1.125;
        //    Box3.AnchorX = -0.125;
        //    Box4.AnchorX = -1.375;
        //    await Task.WhenAll(
        //    Box4.RotateTo(180, 3000, Easing.Linear),
        //    Box3.RotateTo(180, 3000, Easing.Linear),
        //    Box2.RotateTo(180, 3000, Easing.Linear),
        //    Box1.RotateTo(180, 3000, Easing.Linear));
        //    NameLeft = "Box4"; NameMiddleLeft = "Box3"; NameMiddleRight = "Box2"; NameRight = "Box1";
        //    Box1.TranslationX = 50;

        //}

        //public async Task RotateTwo()
        //{
        //    Box4.AnchorX = 0.5;
        //    await Box4.TranslateTo(Box4Width, Box4Height, 1);
        //    await Box4.RotateTo(0, 1);


        //    Box4.AnchorX = 2.375;
        //    Box3.AnchorX = 1.125;
        //    Box2.AnchorX = -0.125;
        //    Box1.AnchorX = -1.375;
        //    // await Box4.RotateTo(180, 5000, Easing.Linear);
            
        //    await Task.WhenAll(
        //    Box1.RotateTo(360, 3000, Easing.Linear),
        //    Box2.RotateTo(360, 3000, Easing.Linear),
        //    Box3.RotateTo(360, 3000, Easing.Linear),
        //    Box4.RotateTo(180, 3000, Easing.Linear));
        //   // NameLeft = "Box4"; NameMiddleLeft = "Box3"; NameMiddleRight = "Box2"; NameRight = "Box1";

        //}

        //public async Task RotateTwo()
        //{

        //    StoreNames();
        //    await Box1.TranslateTo(0.1, 0, 1000, Easing.Linear);
        //    LeftBox.AnchorX = 2.375;
        //    MiddleLeftBox.AnchorX = 1.125;
        //    MiddleRightBox.AnchorX = -0.125;
        //    RightBox.AnchorX = -1.375;
        //    await Task.WhenAll(
        //    RightBox.RotateTo(180, 3000, Easing.Linear),
        //    MiddleRightBox.RotateTo(180, 3000, Easing.Linear),
        //    MiddleLeftBox.RotateTo(180, 3000, Easing.Linear),
        //    LeftBox.RotateTo(180, 3000, Easing.Linear));
        //    // NameLeft = "Box4"; NameMiddleLeft = "Box3"; NameMiddleRight = "Box2"; NameRight = "Box1";

        //}

        public async Task MoveBackInCorners()
        {
            Box1.Color = System.Drawing.Color.Black;
            await Box1.TranslateTo(0, 0, 2000, Easing.Linear);                                // moves box 1 back in Start Poition 
            await Box2.TranslateTo(0, 0, 2000, Easing.Linear); // moves box 2 back in Start Position
            await Box3.TranslateTo(0, 0, 2000, Easing.Linear); // moves box 3 back in Start Position
            await Box4.TranslateTo(0, 0, 2000, Easing.Linear); // moves box 4 back in Start Position
        }


        public void  StoreNames()
        {
            LeftBox = this.FindByName<BoxView>(NameLeft);
            MiddleLeftBox = this.FindByName<BoxView>(NameMiddleLeft);
            MiddleRightBox = this.FindByName<BoxView>(NameMiddleRight);
            RightBox = this.FindByName<BoxView>(NameRight);
        }

        //public async Task MoveWithRightNames()
        //{
        //    StoreNames();
        //    await LeftBox.TranslateTo(0, 100, 2000, Easing.Linear);
        //    await MiddleLeftBox.TranslateTo(0, -50, 2000, Easing.Linear);
        //    await MiddleRightBox.TranslateTo(0, 50, 2000, Easing.Linear);
        //    await RightBox.TranslateTo(0, -50, 2000, Easing.Linear);
        //}

        //public async Task MoveToCenterInRowRightNames()
        //{
        //    StoreNames();
        //   // await Box1.TranslateTo(Box4.X / 2, Box4.Y / 2, 1000, Easing.Linear); // bewirkt nichts, weil der den ersten Befehl hier nicht packt..
        //    await LeftBox.TranslateTo(100, 100, 2000, Easing.Linear);
        //    await MiddleLeftBox.TranslateTo(-100, 100, 2000, Easing.Linear);
        //    await MiddleRightBox.TranslateTo(100, - 100, 2000, Easing.Linear);
        //    await RightBox.TranslateTo(-100, -100, 2000, Easing.Linear);
        //    NameLeft = "Box4";
        //    NameMiddleLeft = "Box3";
        //    NameMiddleRight = "Box2";
        //    NameRight = "Box1";

        //}

        //public async Task MoveBoxes()
        //{
        //    StoreNames();
        //    await LeftBox.TranslateTo(10, 10, 3000, Easing.Linear);
        //    await MiddleLeftBox.TranslateTo(10, 10, 3000, Easing.Linear);
        //    await MiddleRightBox.TranslateTo(10, 10, 3000, Easing.Linear);
        //    await RightBox.TranslateTo(10, 10, 3000, Easing.Linear);
        //}
    }
}
