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

            await Task.Delay(2000);
            await MoveToCenterInRow();
            await RotateSix();
            await RotateSix();
            await RotateFive();
            await RotateThreePlus();
            await RotateThreePlus();
            await RotateOne();
            await RotateTwo();
            await RotateOne();
            await RotateTwo();
            await MoveBackInCorners();           

        }

        public async Task RotateOne()
        {
            StoreNames();
            await Task.Delay(200);

       
            LeftBox.AnchorX = DreiPositionen;
            MiddleLeftBox.AnchorX = EinePosition;
            MiddleRightBox.AnchorX = -(EinePosition - 1);
            await Task.WhenAll(
                LeftBox.RotateTo(180, 1200),
                MiddleLeftBox.RotateTo(-180, 1200),
                MiddleRightBox.RotateTo(- 180, 1200),
                RightBox.TranslateTo(RightBox.TranslationX + 50,RightBox.TranslationY + 0, 1200)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            LeftBox.TranslationX += 150;
            MiddleLeftBox.TranslationX += 50;
            MiddleRightBox.TranslationX += -50;
            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            NameChanger = NameRight;
            NameRight = NameRight;
            NameChanger = NameMiddleRight;
            NameMiddleRight = NameLeft;
            NameLeft = NameChanger;    
        }

        public async Task RotateTwo()
        {
            StoreNames();
            await Task.Delay(200);

            RightBox.AnchorX = -(DreiPositionen-1);
            MiddleLeftBox.AnchorX = EinePosition;
            MiddleRightBox.AnchorX = -(EinePosition - 1);
            await Task.WhenAll(
                RightBox.RotateTo(-180, 1200),
                MiddleLeftBox.RotateTo(180, 1200),
                MiddleRightBox.RotateTo(180, 1200),
                LeftBox.TranslateTo(LeftBox.TranslationX - 50, LeftBox.TranslationY + 0, 1200)
                );

            // Set Anchor to normal and compensate the translation
            RightBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.TranslationX += - 150;
            MiddleLeftBox.TranslationX += 50;
            MiddleRightBox.TranslationX += -50;
            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            NameChanger = NameMiddleLeft;
            NameMiddleLeft = NameRight;
            NameRight = NameChanger;
        }


        public async Task RotateThree()
        {
            StoreNames();
            await Task.Delay(200);

            LeftBox.AnchorX = EinePosition;
            RightBox.AnchorX = -(EinePosition - 1);

            await Task.WhenAll(
                RightBox.RotateTo(-180, 1200),
                LeftBox.RotateTo(180, 1200),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX - 50, MiddleLeftBox.TranslationY + 0, 1200),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX + 50, MiddleRightBox.TranslationY + 0, 1200)
                );

            // Set Anchor to normal and compensate the translation
            RightBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            LeftBox.AnchorX = 0.5;
            RightBox.TranslationX += -50;
            LeftBox.TranslationX += 50;
            
            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            NameChanger = NameMiddleLeft;
            NameMiddleLeft = NameLeft;
            NameLeft = NameChanger;

            NameChanger = NameMiddleRight;
            NameMiddleRight = NameRight;
            NameRight = NameChanger;
        }


        public async Task RotateThreePlus()
        {
            StoreNames();
            await Task.Delay(200);

            LeftBox.AnchorX = EinePosition;
            MiddleLeftBox.AnchorX = -(EinePosition - 1);
            MiddleRightBox.AnchorX = EinePosition;
            RightBox.AnchorX = -(EinePosition - 1);


            await Task.WhenAll(
                RightBox.RotateTo(-180, 1200),
                MiddleRightBox.RotateTo(-180, 1200),
                MiddleLeftBox.RotateTo(180, 1200),
                LeftBox.RotateTo(180, 1200)                
                );

            // Set Anchor to normal and compensate the translation
            RightBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            LeftBox.AnchorX = 0.5;
            RightBox.TranslationX += -50;
            MiddleRightBox.TranslationX += 50;
            MiddleLeftBox.TranslationX += -50;
            LeftBox.TranslationX += 50;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            NameChanger = NameMiddleLeft;
            NameMiddleLeft = NameLeft;
            NameLeft = NameChanger;

            NameChanger = NameMiddleRight;
            NameMiddleRight = NameRight;
            NameRight = NameChanger;
        }

        public async Task RotateFive()
        {
            StoreNames();
            await Task.Delay(200);

            LeftBox.AnchorX = VierPositionen;
            RightBox.AnchorX = -(VierPositionen -1);

            await Task.WhenAll(
                LeftBox.RotateTo(180, 1200),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX - 50, MiddleLeftBox.TranslationY, 2400),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX + 50, MiddleRightBox.TranslationY, 2400),
                RightBox.RotateTo(180, 1200)

                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;

            LeftBox.TranslationX += 200;
            RightBox.TranslationX += -200;


            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            LeftBox.AnchorX = -(ZweiPositionen - 1);
            RightBox.AnchorX = ZweiPositionen;

            await Task.WhenAll(
            LeftBox.RotateTo(-180, 1000),
            RightBox.RotateTo(180, 1000)
            );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;

            LeftBox.TranslationX += -100;
            RightBox.TranslationX += 100;


            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            NameChanger = NameLeft;
            NameLeft = NameMiddleLeft;
            NameMiddleLeft = NameRight;
            NameRight = NameMiddleRight;
            NameMiddleRight  = NameChanger;


        }

        public async Task RotateSix()
        {
            StoreNames();
            await Task.Delay(200);

            MiddleLeftBox.AnchorX = VierPositionen;
            MiddleRightBox.AnchorX = ZweiPositionen;
            RightBox.AnchorX = -( DreiPositionen-1);


            await Task.WhenAll(
                RightBox.RotateTo(180, 1200),
                MiddleRightBox.RotateTo(180, 1200),
                MiddleLeftBox.RotateTo(180, 1200),
                LeftBox.TranslateTo(LeftBox.TranslationX + 50, LeftBox.TranslationY, 1200)
                
                );

            // Set Anchor to normal and compensate the translation            
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;

            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.TranslationX += 200;            
            MiddleRightBox.TranslationX += 100;
            RightBox.TranslationX += -150;

            await Task.WhenAll(                
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX - 100, MiddleLeftBox.TranslationY, 1200),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX - 100, MiddleRightBox.TranslationY, 1200)
                );


            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            NameChanger = NameLeft;
            NameLeft = NameRight;
            NameRight = NameMiddleLeft;
            NameMiddleLeft = NameChanger;
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




        //public async Task RotateWhatEver()
        //{
        //    StoreNames();
        //    await Task.Delay(200);

        //    LeftBox.AnchorX = AnchorLeft;
        //    MiddleLeftBox.AnchorX = AnchorMiddleLeft;
        //    MiddleRightBox.AnchorX = AnchorMiddleRight;
        //    RightBox.AnchorX = AnchorRight;

        //    await Task.WhenAll(
        //        LeftBox.RotateTo(degreesLeft, time, easing),
        //        MiddleLeftBox.RotateTo(degreesLeft, time, easing),
        //        MiddleRightBox.RotateTo(degreesLeft, time, easing),
        //        RightBox.RotateTo(degreesLeft, time, easing),

        //        LeftBox.TranslateTo(LeftBox.TranslationX + LeftTranslationX, LeftBox.TranslationY + LeftTranslationY, time, easing),
        //        MiddleLeftBox.TranslateTo(LeftBox.TranslationX + LeftTranslationX, LeftBox.TranslationY + LeftTranslationY, time, easing),
        //        MiddleLeftBox.TranslateTo(LeftBox.TranslationX + LeftTranslationX, LeftBox.TranslationY + LeftTranslationY, time, easing),
        //        MiddleLeftBox.TranslateTo(LeftBox.TranslationX + LeftTranslationX, LeftBox.TranslationY + LeftTranslationY, time, easing)
        //        );

        //    // Set Anchor to normal and compensate the translation
        //    LeftBox.AnchorX = 0.5;
        //    MiddleLeftBox.AnchorX = 0.5;      
        //    MiddleRightBox.AnchorX = 0.5;
        //    RightBox.AnchorX = 0.5;

        //    LeftBox.TranslationX += LeftBoxTranslationThroughRotation;
        //    LeftBox.TranslationX += LeftBoxTranslationThroughRotation;
        //    LeftBox.TranslationX += LeftBoxTranslationThroughRotation;
        //    LeftBox.TranslationX += LeftBoxTranslationThroughRotation;

        //    LeftBox.Rotation = 0;
        //    MiddleLeftBox.Rotation = 0;
        //    MiddleRightBox.Rotation = 0;
        //    RightBox.Rotation = 0;
        //    // irgendwie Namechanging allgemein?
        //    //NameChanger = NameMiddleLeft;
        //    //NameMiddleLeft = NameRight;
        //    //NameRight = NameChanger;

        //}
    }
}
