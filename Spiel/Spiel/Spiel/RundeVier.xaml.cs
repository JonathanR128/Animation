using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Spiel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RundeVier : ContentPage
	{
		public RundeVier ()
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


            MoveAsync();
            //MoveTester();
        }


        public int PositionMovedToTheRight { get; set; }
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


        public double[,] Rotationsreihenfolge = new double[,]
        {
             { 6.2, 7, 14, 15, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 8, 11, 5.1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 9.2, 4, 14.1, 13.1, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 12.1, 10, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 15, 6.1, 7.3, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 4.1, 14, 2, 1, 9.1, 0, 0, 0, 0, 0, 0, 0},
            { 8.1, 7.1, 1, 12, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 3.1, 5.1, 9, 6.2, 2, 0, 0, 0, 0, 0, 0, 0 },
            { 14, 7, 8.1, 10, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 11, 12, 13.1, 15, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 5.1, 6.1, 3, 11.1, 14, 0, 0, 0, 0, 0, 0, 0 },
            { 9.2, 11.2, 2, 14, 5, 0, 0, 0, 0, 0, 0, 0 },
            { 3.1, 4.1, 8.3, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            { 11, 12, 15, 13, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 4, 9.1, 6.2, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 1, 10, 11.2, 8, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 1, 7.3, 6.1, 13, 2, 0, 0, 0, 0, 0, 0, 0 },
            { 13, 12, 15, 6.2, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 7.2, 7.3, 11, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 10, 3, 7.3, 13.1, 14.1, 0, 0, 0, 0, 0, 0, 0}

        };

        public int[] RedBox = new int[] { 4, 2, 4, 2, 3, 3, 1, 1, 1, 2, 2, 1, 2, 3, 3, 1, 3, 1, 3, 2 };

        public async Task RotationStarten(double i)
        {
            if (i == 1)
            {
                await RotateOne();
            }
            if (i == 2)
            {
                await RotateTwo();
            }
            if (i == 3)
            {
                await RotateThree();
            }
            if (i == 3.1)
            {
                await RotateThreePointOne();
            }
            if (i == 4)
            {
                await RotateFour();
            }
            if (i == 4.1)
            {
                await RotateFourPointOne();
            }
            if (i == 5)
            {
                await RotateFive();
            }
            if (i == 5.1)
            {
                await RotateFivePointOne();
            }
            if (i == 6)
            {
                await RotateSix();
            }
            if (i == 6.1)
            {
                await RotateSixPointOne();
            }
            if (i == 6.2)
            {
                await RotateSixPointTwo();
            }
            if (i == 7)
            {
                await RotateSeven();
            }
            if (i == 7.1)
            {
                await RotateSevenPointOne();
            }
            if (i == 7.2)
            {
                await RotateSevenPointTwo();
            }
            if (i == 7.3)
            {
                await RotateSevenPointThree();
            }
            if (i == 8)
            {
                await RotateEight();
            }
            if (i == 8.1)
            {
                await RotateEightPointOne();
            }
            if (i == 8.2)
            {
                await RotateEightPointTwo();
            }
            if (i == 8.3)
            {
                await RotateEightPointThree();
            }
            if (i == 9)
            {
                await RotateNine();
            }
            if (i == 9.1)
            {
                await RotateNinePointOne();
            }
            if (i == 9.2)
            {
                await RotateNinePointTwo();
            }
            if (i == 10)
            {
                await RotateTen();
            }
            if (i == 11)
            {
                await RotateEleven();
            }
            if (i == 11.1)
            {
                await RotateElevenPointOne();
            }
            if (i == 11.2)
            {
                await RotateElevenPointTwo();
            }
            if (i == 12)
            {
                await RotateTwelve();
            }
            if (i == 12.1)
            {
                await RotateTwelvePointOne();
            }
            if (i == 13)
            {
                await RotateThirteen();
            }
            if (i == 13.1)
            {
                await RotateThirteenPointOne();
            }
            if (i == 14)
            {
                await RotateFourteen();
            }
            if (i == 14.1)
            {
                await RotateFourteen();
            }
            if (i == 15)
            {
                await RotateFifteen();
            }
        }

        public async Task MoveAsync()
        {

            await StartSequenz();

            for (int i = 0; i < 20; i++)
            {
                PositionMovedToTheRight = 0;
                DrawBoxesWhite();
                await MoveToCenterInRow();
                DrawBoxRed(RedBox[i]);
                await FadeBoxesToOne(1000);
                await Task.Delay(1000);
                DrawBoxesWhite();
                await Task.Delay(1000);

                await RotationStarten(Rotationsreihenfolge[i, 0]);
                await RotationStarten(Rotationsreihenfolge[i, 1]);
                await RotationStarten(Rotationsreihenfolge[i, 2]);
                await RotationStarten(Rotationsreihenfolge[i, 3]);
                await RotationStarten(Rotationsreihenfolge[i, 4]);
                await RotationStarten(Rotationsreihenfolge[i, 5]);
                await RotationStarten(Rotationsreihenfolge[i, 6]);
                await RotationStarten(Rotationsreihenfolge[i, 7]);
                await RotationStarten(Rotationsreihenfolge[i, 8]);
                await RotationStarten(Rotationsreihenfolge[i, 9]);
                await RotationStarten(Rotationsreihenfolge[i, 10]);
                await RotationStarten(Rotationsreihenfolge[i, 11]);

                Label1.FadeTo(1);
                Label2.FadeTo(1);
                Label3.FadeTo(1);
                Label4.FadeTo(1);

                await MoveBackInCorners();
                await Fragezeichen.FadeTo(1, 50);
                await Task.Delay(1150);
                await Fragezeichen.FadeTo(0, 50);
                DrawBoxRed(RedBox[i]);
                await Task.Delay(2750);
                await FadeBoxesToZero(1000);

                Label1.FadeTo(0);
                Label2.FadeTo(0);
                Label3.FadeTo(0);
                Label4.FadeTo(0);
            }

        }

        public async Task StartSequenz()
        {
            await Task.Delay(4500);
            await AnzeigeSpielNummer.FadeTo(0, 500);

            await Countdown10.FadeTo(1, 50);
            await Task.Delay(900);
            await Countdown10.FadeTo(0, 50, Easing.SinIn);
            await Countdown9.FadeTo(1, 50);
            await Task.Delay(900);
            await Countdown9.FadeTo(0, 50, Easing.SinIn);
            await Countdown8.FadeTo(1, 50);
            await Task.Delay(900);
            await Countdown8.FadeTo(0, 50, Easing.SinIn);
            await Countdown7.FadeTo(1, 50);
            await Task.Delay(900);
            await Countdown7.FadeTo(0, 50, Easing.SinIn);
            await Countdown6.FadeTo(1, 50);
            await Task.Delay(900);
            await Countdown6.FadeTo(0, 50, Easing.SinIn);
            await Countdown5.FadeTo(1, 50);
            await Task.Delay(900);
            await Countdown5.FadeTo(0, 50, Easing.SinIn);
            await Countdown4.FadeTo(1, 50);
            await Task.Delay(900);
            await Countdown4.FadeTo(0, 50, Easing.SinIn);
            await Countdown3.FadeTo(1, 50);
            await Task.Delay(900);
            await Countdown3.FadeTo(0, 50, Easing.SinIn);
            await Countdown2.FadeTo(1, 50);
            await Task.Delay(900);
            await Countdown2.FadeTo(0, 50, Easing.SinIn);
            await Countdown1.FadeTo(1, 50);
            await Task.Delay(900);
            await Countdown1.FadeTo(0, 50, Easing.SinIn);

        }

        public async Task RotateOne(uint t = 500)
        {
            StoreNames();
            PositionMovedToTheRight += 1;

            Easing easing = Easing.SinInOut;
            LeftBox.AnchorX = DreiPositionen;
            MiddleLeftBox.AnchorX = EinePosition;
            MiddleRightBox.AnchorX = -(EinePosition - 1);
            await Task.WhenAll(
                LeftBox.RotateTo(180, t, easing),
                MiddleLeftBox.RotateTo(-180, t, easing),
                MiddleRightBox.RotateTo(-180, t, easing),
                RightBox.TranslateTo(RightBox.TranslationX + 50, RightBox.TranslationY + 0, t, easing)
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

        public async Task RotateTwo(uint t = 500)
        {
            StoreNames();
            PositionMovedToTheRight += -1;

            RightBox.AnchorX = -(DreiPositionen - 1);
            MiddleLeftBox.AnchorX = EinePosition;
            MiddleRightBox.AnchorX = -(EinePosition - 1);
            await Task.WhenAll(
                RightBox.RotateTo(-180, t),
                MiddleLeftBox.RotateTo(180, t),
                MiddleRightBox.RotateTo(180, t),
                LeftBox.TranslateTo(LeftBox.TranslationX - 50, LeftBox.TranslationY + 0, t)
                );

            // Set Anchor to normal and compensate the translation
            RightBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.TranslationX += -150;
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

        public async Task RotateThree(uint t = 500)
        {
            StoreNames();

            LeftBox.AnchorX = EinePosition;
            RightBox.AnchorX = -(EinePosition - 1);

            await Task.WhenAll(
                RightBox.RotateTo(-180, t),
                LeftBox.RotateTo(180, t),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX - 50, MiddleLeftBox.TranslationY + 0, t, Easing.CubicIn),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX + 50, MiddleRightBox.TranslationY + 0, t, Easing.CubicIn)
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

        public async Task RotateThreePointOne(uint t = 500)
        {
            StoreNames();

            LeftBox.AnchorX = EinePosition;
            MiddleLeftBox.AnchorX = -(EinePosition - 1);
            MiddleRightBox.AnchorX = EinePosition;
            RightBox.AnchorX = -(EinePosition - 1);


            await Task.WhenAll(
                RightBox.RotateTo(-180, t),
                MiddleRightBox.RotateTo(-180, t),
                MiddleLeftBox.RotateTo(180, t),
                LeftBox.RotateTo(180, t)
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

        public async Task RotateFour(uint t = 500, uint t2 = 750, uint t3 = 1000)
        {
            StoreNames();
            PositionMovedToTheRight += -1;

            Easing easing = Easing.SinInOut;
            await Task.WhenAll(
                LeftBox.TranslateTo(LeftBox.TranslationX, LeftBox.TranslationY + 50, t),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX, MiddleLeftBox.TranslationY - 50, t),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX, MiddleRightBox.TranslationY + 50, t),
                RightBox.TranslateTo(RightBox.TranslationX, RightBox.TranslationY - 50, 750)
                );


            LeftBox.AnchorX = ZweiPositionen;
            MiddleLeftBox.AnchorX = ZweiPositionen;
            MiddleRightBox.AnchorX = -(ZweiPositionen - 1);
            RightBox.AnchorX = -(ZweiPositionen - 1);

            await Task.WhenAll(
                LeftBox.RotateTo(180, t2, easing),
                MiddleLeftBox.RotateTo(-360, t2, easing),
                MiddleRightBox.RotateTo(180, t2, easing),
                RightBox.RotateTo(-360, t2, easing)
                );


            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;

            LeftBox.TranslationX += 100;
            MiddleLeftBox.TranslationX += 0;
            MiddleRightBox.TranslationX += -100;
            RightBox.TranslationX += 0;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;


            await Task.WhenAny(
                LeftBox.TranslateTo(LeftBox.TranslationX, LeftBox.TranslationY - 50, t3),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX - 100, MiddleLeftBox.TranslationY, t3 / 2),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX, MiddleRightBox.TranslationY - 50, t3),
                RightBox.TranslateTo(RightBox.TranslationX - 100, RightBox.TranslationY, t3 / 2)
                );

            await Task.WhenAll(
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX, MiddleLeftBox.TranslationY + 50, t3 / 2),
                RightBox.TranslateTo(RightBox.TranslationX, RightBox.TranslationY + 50, t3 / 2)
                );

            NameChanger = NameLeft;
            NameLeft = NameMiddleLeft;
            NameMiddleLeft = NameMiddleRight;
            NameMiddleRight = NameRight;
            NameRight = NameChanger;

        }

        public async Task RotateFourPointOne(uint t = 500, uint t2 = 750, uint t3 = 1000)
        {
            StoreNames();
            PositionMovedToTheRight += -1;
            Easing easing = Easing.SinInOut;

            await Task.WhenAll(
                LeftBox.TranslateTo(LeftBox.TranslationX, LeftBox.TranslationY - 50, t),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX, MiddleLeftBox.TranslationY + 50, t),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX, MiddleRightBox.TranslationY - 50, t),
                RightBox.TranslateTo(RightBox.TranslationX, RightBox.TranslationY + 50, t)
                );


            LeftBox.AnchorX = ZweiPositionen;
            MiddleLeftBox.AnchorX = ZweiPositionen;
            MiddleRightBox.AnchorX = -(ZweiPositionen - 1);
            RightBox.AnchorX = -(ZweiPositionen - 1);

            await Task.WhenAll(
                LeftBox.RotateTo(-180, t2, easing),
                MiddleLeftBox.RotateTo(+360, t2, easing),
                MiddleRightBox.RotateTo(-180, t2, easing),
                RightBox.RotateTo(+360, t2, easing)
                );


            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;

            LeftBox.TranslationX += 100;
            MiddleLeftBox.TranslationX += 0;
            MiddleRightBox.TranslationX += -100;
            RightBox.TranslationX += 0;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;


            await Task.WhenAny(
                LeftBox.TranslateTo(LeftBox.TranslationX, LeftBox.TranslationY + 50, t3),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX - 100, MiddleLeftBox.TranslationY, t3 / 2),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX, MiddleRightBox.TranslationY + 50, t3),
                RightBox.TranslateTo(RightBox.TranslationX - 100, RightBox.TranslationY, t3 / 2)
                );

            await Task.WhenAll(
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX, MiddleLeftBox.TranslationY - 50, t3 / 2),
                RightBox.TranslateTo(RightBox.TranslationX, RightBox.TranslationY - 50, t3 / 2)
                );

            NameChanger = NameLeft;
            NameLeft = NameMiddleLeft;
            NameMiddleLeft = NameMiddleRight;
            NameMiddleRight = NameRight;
            NameRight = NameChanger;

        }

        public async Task RotateFive(uint t = 625, uint t2 = 625)
        {
            StoreNames();

            LeftBox.AnchorX = VierPositionen;
            RightBox.AnchorX = -(VierPositionen - 1);

            await Task.WhenAll(
                LeftBox.RotateTo(180, t),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX - 50, MiddleLeftBox.TranslationY, t),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX + 50, MiddleRightBox.TranslationY, t),
                RightBox.RotateTo(180, t)

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
            LeftBox.RotateTo(-180, t2),
            RightBox.RotateTo(180, t2)
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
            NameMiddleRight = NameChanger;


        }

        public async Task RotateFivePointOne(uint t = 750, uint t2 = 750)
        {
            StoreNames();

            LeftBox.AnchorX = VierPositionen;
            RightBox.AnchorX = -(VierPositionen - 1);

            await Task.WhenAll(
                LeftBox.RotateTo(180, t),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX - 50, MiddleLeftBox.TranslationY, t),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX + 50, MiddleRightBox.TranslationY, t),
                RightBox.RotateTo(180, t)

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

            // Zweiter Teil

            LeftBox.AnchorX = -(EinePosition - 1);
            MiddleLeftBox.AnchorX = -(EinePosition - 1);
            MiddleRightBox.AnchorX = EinePosition;
            RightBox.AnchorX = EinePosition;

            await Task.WhenAll(
            LeftBox.RotateTo(180, t2),
            MiddleLeftBox.RotateTo(180, t2),
            MiddleRightBox.RotateTo(180, t2),
            RightBox.RotateTo(180, t2),

            LeftBox.TranslateTo(LeftBox.TranslationX - 50, LeftBox.TranslationY, t2),
            MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX + 50, MiddleLeftBox.TranslationY, t2),
            MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX - 50, MiddleRightBox.TranslationY, t2),
            RightBox.TranslateTo(RightBox.TranslationX + 50, RightBox.TranslationY, t2)
            );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;

            LeftBox.TranslationX += -50;
            MiddleLeftBox.TranslationX += -50;
            MiddleRightBox.TranslationX += 50;
            RightBox.TranslationX += 50;


            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            NameChanger = NameLeft;
            NameLeft = NameMiddleLeft;
            NameMiddleLeft = NameRight;
            NameRight = NameMiddleRight;
            NameMiddleRight = NameChanger;


        }

        public async Task RotateSix(uint t = 750, uint t2 = 750)
        {
            StoreNames();

            MiddleLeftBox.AnchorX = VierPositionen;
            MiddleRightBox.AnchorX = ZweiPositionen;
            RightBox.AnchorX = -(DreiPositionen - 1);


            await Task.WhenAll(
                RightBox.RotateTo(180, t),
                MiddleRightBox.RotateTo(180, t),
                MiddleLeftBox.RotateTo(180, t),
                LeftBox.TranslateTo(LeftBox.TranslationX + 50, LeftBox.TranslationY, t)

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
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX - 100, MiddleLeftBox.TranslationY, t2),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX - 100, MiddleRightBox.TranslationY, t2)
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

        public async Task RotateSixPointOne(uint t = 750, uint t2 = 1000)
        {
            StoreNames();

            MiddleLeftBox.AnchorX = VierPositionen;
            MiddleRightBox.AnchorX = ZweiPositionen;
            RightBox.AnchorX = -(DreiPositionen - 1);


            await Task.WhenAll(
                RightBox.RotateTo(180, t),
                MiddleRightBox.RotateTo(180, t),
                MiddleLeftBox.RotateTo(180, t),
                LeftBox.TranslateTo(LeftBox.TranslationX + 50, LeftBox.TranslationY, t)

                );

            // Set Anchor to normal and compensate the translation            
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;

            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.TranslationX += 200;
            MiddleRightBox.TranslationX += 100;
            RightBox.TranslationX += -150;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;


            ////// Zweiter Teil

            MiddleLeftBox.AnchorX = -(EinePosition - 1);
            MiddleRightBox.AnchorX = EinePosition;


            await Task.WhenAll(

                MiddleLeftBox.RotateTo(180, t2),
                MiddleRightBox.RotateTo(180, t2),

                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX - 100, MiddleLeftBox.TranslationY, t2),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX - 100, MiddleRightBox.TranslationY, t2)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;


            LeftBox.TranslationX += 0;
            MiddleLeftBox.TranslationX += -50;
            MiddleRightBox.TranslationX += 50;
            RightBox.TranslationX += 0;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;


            NameChanger = NameLeft;
            NameLeft = NameRight;
            NameRight = NameMiddleRight;
            NameMiddleRight = NameMiddleLeft;
            NameMiddleLeft = NameChanger;
        }

        public async Task RotateSixPointTwo(uint t = 750, uint t2 = 1000)
        {
            StoreNames();

            MiddleLeftBox.AnchorX = VierPositionen;
            MiddleRightBox.AnchorX = ZweiPositionen;
            RightBox.AnchorX = -(DreiPositionen - 1);


            await Task.WhenAll(
                RightBox.RotateTo(180, t),
                MiddleRightBox.RotateTo(180, t),
                MiddleLeftBox.RotateTo(180, t),
                LeftBox.TranslateTo(LeftBox.TranslationX + 50, LeftBox.TranslationY, t)

                );

            // Set Anchor to normal and compensate the translation            
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;

            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.TranslationX += 200;
            MiddleRightBox.TranslationX += 100;
            RightBox.TranslationX += -150;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;


            ////// Zweiter Teil

            LeftBox.AnchorX = -(EinePosition - 1);
            MiddleLeftBox.AnchorX = -(EinePosition - 1);
            MiddleRightBox.AnchorX = EinePosition;
            RightBox.AnchorX = EinePosition;


            await Task.WhenAll(

                LeftBox.RotateTo(180, t2),
                MiddleLeftBox.RotateTo(180, t2),
                MiddleRightBox.RotateTo(180, t2),
                RightBox.RotateTo(180, t2),

                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX - 100, MiddleLeftBox.TranslationY, t2),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX - 100, MiddleRightBox.TranslationY, t2)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;


            LeftBox.TranslationX += -50;
            MiddleLeftBox.TranslationX += -50;
            MiddleRightBox.TranslationX += 50;
            RightBox.TranslationX += 50;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;


            NameChanger = NameMiddleLeft;
            NameMiddleLeft = NameRight;
            NameRight = NameMiddleRight;
            NameMiddleRight = NameChanger;
        }

        public async Task RotateSeven(uint t = 750, uint t2 = 1000)
        {
            StoreNames();


            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = VierPositionen;
            MiddleRightBox.AnchorX = ZweiPositionen;
            RightBox.AnchorX = 0.5;

            await Task.WhenAll(
                MiddleLeftBox.RotateTo(-180, t),
                MiddleRightBox.RotateTo(180, t)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;


            LeftBox.TranslationX += 0;
            MiddleLeftBox.TranslationX += 200;
            MiddleRightBox.TranslationX += 100;
            RightBox.TranslationX += 0;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            ////// Zweiter Teil
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = -(EinePosition - 1);
            MiddleRightBox.AnchorX = EinePosition;
            RightBox.AnchorX = -(DreiPositionen - 1);

            await Task.WhenAll(

                MiddleLeftBox.RotateTo(-540, t2),
                MiddleRightBox.RotateTo(-540, t2),
                RightBox.RotateTo(-180, t2 / 2),

                LeftBox.TranslateTo(LeftBox.TranslationX + 50, LeftBox.TranslationY, t2 / 2),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX - 100, MiddleLeftBox.TranslationY, t2),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX - 100, MiddleRightBox.TranslationY, t2)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;


            LeftBox.TranslationX += 0;
            MiddleLeftBox.TranslationX += -50;
            MiddleRightBox.TranslationX += 50;
            RightBox.TranslationX += -150;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;


            NameChanger = NameLeft;
            NameLeft = NameRight;
            NameRight = NameMiddleRight;
            NameMiddleRight = NameMiddleLeft;
            NameMiddleLeft = NameChanger;
        }

        public async Task RotateSevenPointOne(uint t = 750, uint t2 = 1000)
        {
            StoreNames();


            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = VierPositionen;
            MiddleRightBox.AnchorX = ZweiPositionen;
            RightBox.AnchorX = 0.5;

            await Task.WhenAll(
                MiddleLeftBox.RotateTo(-180, t),
                MiddleRightBox.RotateTo(180, t)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;


            LeftBox.TranslationX += 0;
            MiddleLeftBox.TranslationX += 200;
            MiddleRightBox.TranslationX += 100;
            RightBox.TranslationX += 0;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            ////// Zweiter Teil
            LeftBox.AnchorX = DreiPositionen;
            RightBox.AnchorX = -(DreiPositionen - 1);

            await Task.WhenAll(


                LeftBox.RotateTo(-180, t2),
                RightBox.RotateTo(-180, t2),

                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX - 150, MiddleLeftBox.TranslationY, t2),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX - 150, MiddleRightBox.TranslationY, t2)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;


            LeftBox.TranslationX += 150;
            MiddleLeftBox.TranslationX += 0;
            MiddleRightBox.TranslationX += 0;
            RightBox.TranslationX += -150;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            NameChanger = NameLeft;
            NameLeft = NameRight;
            NameRight = NameChanger;
            NameChanger = NameMiddleLeft;
            NameMiddleLeft = NameMiddleRight;
            NameMiddleRight = NameChanger;

        }

        public async Task RotateSevenPointTwo(uint t = 750, uint t2 = 1000)
        {
            StoreNames();


            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = VierPositionen;
            MiddleRightBox.AnchorX = ZweiPositionen;
            RightBox.AnchorX = 0.5;

            await Task.WhenAll(
                MiddleLeftBox.RotateTo(-180, t),
                MiddleRightBox.RotateTo(180, t)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;


            LeftBox.TranslationX += 0;
            MiddleLeftBox.TranslationX += 200;
            MiddleRightBox.TranslationX += 100;
            RightBox.TranslationX += 0;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            ////// Zweiter Teil
            LeftBox.AnchorX = DreiPositionen;
            MiddleLeftBox.AnchorX = -(EinePosition - 1);
            MiddleRightBox.AnchorX = EinePosition;
            RightBox.AnchorX = -(DreiPositionen - 1);

            await Task.WhenAll(


                LeftBox.RotateTo(-180, t2),
                MiddleLeftBox.RotateTo(180, t2),
                MiddleRightBox.RotateTo(180, t2),
                RightBox.RotateTo(-180, t2),

                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX - 150, MiddleLeftBox.TranslationY, t2),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX - 150, MiddleRightBox.TranslationY, t2)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;


            LeftBox.TranslationX += 150;
            MiddleLeftBox.TranslationX += -50;
            MiddleRightBox.TranslationX += 50;
            RightBox.TranslationX += -150;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            NameChanger = NameLeft;
            NameLeft = NameRight;
            NameRight = NameChanger;


        }

        public async Task RotateSevenPointThree(uint t = 750, uint t2 = 1750)
        {
            StoreNames();


            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = VierPositionen;
            MiddleRightBox.AnchorX = ZweiPositionen;
            RightBox.AnchorX = 0.5;

            await Task.WhenAll(
                MiddleLeftBox.RotateTo(-180, t),
                MiddleRightBox.RotateTo(180, t)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;


            LeftBox.TranslationX += 0;
            MiddleLeftBox.TranslationX += 200;
            MiddleRightBox.TranslationX += 100;
            RightBox.TranslationX += 0;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            ////// Zweiter Teil
            LeftBox.AnchorX = DreiPositionen;
            MiddleLeftBox.AnchorX = -(EinePosition - 1);
            MiddleRightBox.AnchorX = EinePosition;
            RightBox.AnchorX = -(DreiPositionen - 1);

            await Task.WhenAll(


                LeftBox.RotateTo(-180, t2),
                MiddleLeftBox.RotateTo(540, t2),
                MiddleRightBox.RotateTo(540, t2),
                RightBox.RotateTo(-180, t2),

                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX - 150, MiddleLeftBox.TranslationY, t2),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX - 150, MiddleRightBox.TranslationY, t2)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;


            LeftBox.TranslationX += 150;
            MiddleLeftBox.TranslationX += -50;
            MiddleRightBox.TranslationX += 50;
            RightBox.TranslationX += -150;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            NameChanger = NameLeft;
            NameLeft = NameRight;
            NameRight = NameChanger;


        }

        public async Task RotateEight(uint t = 750, uint t2 = 1500, uint t3 = 500)
        {
            StoreNames();

            LeftBox.AnchorX = ZweiPositionen;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = -(ZweiPositionen - 1);

            await Task.WhenAll(
                LeftBox.RotateTo(180, t - 100, Easing.CubicIn),
                RightBox.RotateTo(-180, t, Easing.CubicOut),

                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX, MiddleLeftBox.TranslationY + 50, t),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX, MiddleRightBox.TranslationY + 50, t)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;



            LeftBox.TranslationX += 100;
            MiddleLeftBox.TranslationX += 0;
            MiddleRightBox.TranslationX += 0;
            RightBox.TranslationX += -100;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            // Zweiter Teil

            LeftBox.AnchorX = -(EinePosition - 1);
            LeftBox.AnchorY = EinePosition;
            MiddleLeftBox.AnchorX = EinePosition;
            MiddleLeftBox.AnchorY = -(EinePosition - 1);
            MiddleRightBox.AnchorX = -(EinePosition - 1);
            MiddleRightBox.AnchorY = -(EinePosition - 1);
            RightBox.AnchorX = EinePosition;
            RightBox.AnchorY = EinePosition;

            Easing easing = Easing.SinInOut;

            await Task.WhenAll(
                LeftBox.RotateTo(540, t2, easing),
                MiddleLeftBox.RotateTo(540, t2, easing),
                MiddleRightBox.RotateTo(540, t2, easing),
                RightBox.RotateTo(540, t2, easing)

                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            LeftBox.AnchorY = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorY = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            MiddleRightBox.AnchorY = 0.5;
            RightBox.AnchorX = 0.5;
            RightBox.AnchorY = 0.5;


            LeftBox.TranslationX += -50;
            LeftBox.TranslationY += 50;
            MiddleLeftBox.TranslationX += 50;
            MiddleLeftBox.TranslationY += -50;
            MiddleRightBox.TranslationX += -50;
            MiddleRightBox.TranslationY += -50;
            RightBox.TranslationX += 50;
            RightBox.TranslationY += 50;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            // Teil Drei


            await Task.WhenAll(
                LeftBox.TranslateTo(LeftBox.TranslationX - 50, LeftBox.TranslationY - 50, t3),
                RightBox.TranslateTo(RightBox.TranslationX + 50, RightBox.TranslationY - 50, t3)
                );

            NameChanger = NameMiddleLeft;
            NameMiddleLeft = NameMiddleRight;
            NameMiddleRight = NameChanger;

        }

        public async Task RotateEightPointOne(uint t = 750, uint t2 = 750, uint t3 = 500)
        {
            StoreNames();

            LeftBox.AnchorX = ZweiPositionen;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = -(ZweiPositionen - 1);

            await Task.WhenAll(
                LeftBox.RotateTo(180, t - 100, Easing.CubicIn),
                RightBox.RotateTo(-180, t, Easing.CubicOut),

                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX, MiddleLeftBox.TranslationY + 50, t),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX, MiddleRightBox.TranslationY + 50, t)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;



            LeftBox.TranslationX += 100;
            MiddleLeftBox.TranslationX += 0;
            MiddleRightBox.TranslationX += 0;
            RightBox.TranslationX += -100;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            // Zweiter Teil

            LeftBox.AnchorX = -(EinePosition - 1);
            LeftBox.AnchorY = EinePosition;
            MiddleLeftBox.AnchorX = EinePosition;
            MiddleLeftBox.AnchorY = -(EinePosition - 1);
            MiddleRightBox.AnchorX = -(EinePosition - 1);
            MiddleRightBox.AnchorY = -(EinePosition - 1);
            RightBox.AnchorX = EinePosition;
            RightBox.AnchorY = EinePosition;

            Easing easing = Easing.SinInOut;

            await Task.WhenAll(
                LeftBox.RotateTo(180, t2, easing),
                MiddleLeftBox.RotateTo(180, t2, easing),
                MiddleRightBox.RotateTo(180, t2, easing),
                RightBox.RotateTo(180, t2, easing)

                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            LeftBox.AnchorY = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorY = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            MiddleRightBox.AnchorY = 0.5;
            RightBox.AnchorX = 0.5;
            RightBox.AnchorY = 0.5;


            LeftBox.TranslationX += -50;
            LeftBox.TranslationY += 50;
            MiddleLeftBox.TranslationX += 50;
            MiddleLeftBox.TranslationY += -50;
            MiddleRightBox.TranslationX += -50;
            MiddleRightBox.TranslationY += -50;
            RightBox.TranslationX += 50;
            RightBox.TranslationY += 50;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            // Teil Drei


            await Task.WhenAll(
                LeftBox.TranslateTo(LeftBox.TranslationX - 50, LeftBox.TranslationY - 50, t3),
                RightBox.TranslateTo(RightBox.TranslationX + 50, RightBox.TranslationY - 50, t3)
                );

            NameChanger = NameMiddleLeft;
            NameMiddleLeft = NameMiddleRight;
            NameMiddleRight = NameChanger;

        }

        public async Task RotateEightPointTwo(uint t = 750, uint t2 = 1000, uint t3 = 500)
        {
            StoreNames();

            LeftBox.AnchorX = ZweiPositionen;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = -(ZweiPositionen - 1);

            await Task.WhenAll(
                LeftBox.RotateTo(180, t - 100, Easing.CubicIn),
                RightBox.RotateTo(-180, t, Easing.CubicOut),

                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX, MiddleLeftBox.TranslationY + 50, t),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX, MiddleRightBox.TranslationY + 50, t)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;



            LeftBox.TranslationX += 100;
            MiddleLeftBox.TranslationX += 0;
            MiddleRightBox.TranslationX += 0;
            RightBox.TranslationX += -100;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            // Zweiter Teil

            LeftBox.AnchorX = -(EinePosition - 1);
            LeftBox.AnchorY = EinePosition;
            MiddleLeftBox.AnchorX = EinePosition;
            MiddleLeftBox.AnchorY = -(EinePosition - 1);
            MiddleRightBox.AnchorX = -(EinePosition - 1);
            MiddleRightBox.AnchorY = -(EinePosition - 1);
            RightBox.AnchorX = EinePosition;
            RightBox.AnchorY = EinePosition;

            Easing easing = Easing.SinInOut;

            await Task.WhenAll(
                LeftBox.RotateTo(270, t2, easing),
                MiddleLeftBox.RotateTo(270, t2, easing),
                MiddleRightBox.RotateTo(270, t2, easing),
                RightBox.RotateTo(270, t2, easing)

                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            LeftBox.AnchorY = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorY = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            MiddleRightBox.AnchorY = 0.5;
            RightBox.AnchorX = 0.5;
            RightBox.AnchorY = 0.5;


            LeftBox.TranslationX += -50;
            LeftBox.TranslationY += 0;
            MiddleLeftBox.TranslationX += 50;
            MiddleLeftBox.TranslationY += 0;
            MiddleRightBox.TranslationX += 0;
            MiddleRightBox.TranslationY += -50;
            RightBox.TranslationX += 0;
            RightBox.TranslationY += 50;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            // Teil Drei


            await Task.WhenAll(
                RightBox.TranslateTo(RightBox.TranslationX - 50, RightBox.TranslationY - 50, t3),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX + 50, MiddleLeftBox.TranslationY - 50, t3)
                );

            NameChanger = NameLeft;
            NameLeft = NameRight;
            NameRight = NameMiddleLeft;
            NameMiddleLeft = NameChanger;

        }

        public async Task RotateEightPointThree(uint t = 750, uint t2 = 1875, uint t3 = 625)
        {
            StoreNames();

            LeftBox.AnchorX = ZweiPositionen;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = -(ZweiPositionen - 1);

            await Task.WhenAll(
                LeftBox.RotateTo(180, t - 100, Easing.CubicIn),
                RightBox.RotateTo(-180, t, Easing.CubicOut),

                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX, MiddleLeftBox.TranslationY + 50, t),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX, MiddleRightBox.TranslationY + 50, t)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;



            LeftBox.TranslationX += 100;
            MiddleLeftBox.TranslationX += 0;
            MiddleRightBox.TranslationX += 0;
            RightBox.TranslationX += -100;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            // Zweiter Teil

            LeftBox.AnchorX = -(EinePosition - 1);
            LeftBox.AnchorY = EinePosition;
            MiddleLeftBox.AnchorX = EinePosition;
            MiddleLeftBox.AnchorY = -(EinePosition - 1);
            MiddleRightBox.AnchorX = -(EinePosition - 1);
            MiddleRightBox.AnchorY = -(EinePosition - 1);
            RightBox.AnchorX = EinePosition;
            RightBox.AnchorY = EinePosition;

            Easing easing = Easing.SinInOut;

            await Task.WhenAll(
                LeftBox.RotateTo(540, t2, easing),
                MiddleLeftBox.RotateTo(540, t2, easing),
                MiddleRightBox.RotateTo(540, t2, easing),
                RightBox.RotateTo(540, t2, easing),

                LeftBox.TranslateTo(LeftBox.TranslationX, LeftBox.TranslationY - 100, t3, easing),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX, MiddleLeftBox.TranslationY - 100, t3, easing),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX, MiddleRightBox.TranslationY - 100, t3, easing),
                RightBox.TranslateTo(RightBox.TranslationX, RightBox.TranslationY - 100, t3, easing)

                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            LeftBox.AnchorY = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorY = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            MiddleRightBox.AnchorY = 0.5;
            RightBox.AnchorX = 0.5;
            RightBox.AnchorY = 0.5;


            LeftBox.TranslationX += -50;
            LeftBox.TranslationY += 50;
            MiddleLeftBox.TranslationX += 50;
            MiddleLeftBox.TranslationY += -50;
            MiddleRightBox.TranslationX += -50;
            MiddleRightBox.TranslationY += -50;
            RightBox.TranslationX += 50;
            RightBox.TranslationY += 50;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            // Teil Drei


            await Task.WhenAll(
                LeftBox.TranslateTo(LeftBox.TranslationX - 50, LeftBox.TranslationY + 50, t3),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX, MiddleLeftBox.TranslationY + 100, t3, easing),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX, MiddleRightBox.TranslationY + 100, t3, easing),
                RightBox.TranslateTo(RightBox.TranslationX + 50, RightBox.TranslationY + 50, t3)
                );

            NameChanger = NameMiddleLeft;
            NameMiddleLeft = NameMiddleRight;
            NameMiddleRight = NameChanger;

        }

        public async Task RotateNine(uint t = 750, uint t2 = 500, uint t3 = 500)
        {
            StoreNames();
            PositionMovedToTheRight += 1;

            LeftBox.AnchorX = ZweiPositionen;
            MiddleLeftBox.AnchorX = ZweiPositionen;
            MiddleRightBox.AnchorX = ZweiPositionen;
            RightBox.AnchorX = -(DreiPositionen - 1);

            await Task.WhenAll(
                LeftBox.RotateTo(-90, t, Easing.SinInOut),
                MiddleLeftBox.RotateTo(90, t, Easing.SinInOut),
                MiddleRightBox.RotateTo(-180, t, Easing.SinInOut),
                RightBox.RotateTo(-180, t, Easing.SinInOut)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;


            LeftBox.TranslationX += 50;
            LeftBox.TranslationY += 50;
            MiddleLeftBox.TranslationX += 50;
            MiddleLeftBox.TranslationY += -50;
            MiddleRightBox.TranslationX += 100;
            RightBox.TranslationX += -150;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            // Zweiter Teil

            await Task.WhenAll(

                LeftBox.TranslateTo(LeftBox.TranslationX + 100, LeftBox.TranslationY, t2, Easing.SinInOut),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX - 50, MiddleLeftBox.TranslationY, t2, Easing.SinInOut),
                RightBox.TranslateTo(RightBox.TranslationX + 100, RightBox.TranslationY, t2, Easing.SinInOut)
                );


            // Dritter Teil

            await Task.WhenAll(

                LeftBox.TranslateTo(LeftBox.TranslationX, LeftBox.TranslationY - 50, t3, Easing.SinInOut),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX, MiddleLeftBox.TranslationY + 50, t3, Easing.SinInOut)
                );

            NameChanger = NameLeft;
            NameLeft = NameMiddleLeft;
            NameMiddleLeft = NameRight;
            NameRight = NameMiddleRight;
            NameMiddleRight = NameChanger;

        }

        public async Task RotateNinePointOne(uint t = 750, uint t2 = 750, uint t3 = 500)
        {
            StoreNames();
            PositionMovedToTheRight += 1;

            LeftBox.AnchorX = ZweiPositionen;
            MiddleLeftBox.AnchorX = ZweiPositionen;
            MiddleRightBox.AnchorX = ZweiPositionen;
            RightBox.AnchorX = -(DreiPositionen - 1);

            await Task.WhenAll(
                LeftBox.RotateTo(-90, t, Easing.SinInOut),
                MiddleLeftBox.RotateTo(90, t, Easing.SinInOut),
                MiddleRightBox.RotateTo(-180, t, Easing.SinInOut),
                RightBox.RotateTo(-180, t, Easing.SinInOut)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;


            LeftBox.TranslationX += 50;
            LeftBox.TranslationY += 50;
            MiddleLeftBox.TranslationX += 50;
            MiddleLeftBox.TranslationY += -50;
            MiddleRightBox.TranslationX += 100;
            RightBox.TranslationX += -150;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            // Zweiter Teil


            RightBox.AnchorX = ZweiPositionen;
            RightBox.AnchorY = -(ZweiPositionen - 1);

            await Task.WhenAll(

                LeftBox.TranslateTo(LeftBox.TranslationX + 100, LeftBox.TranslationY, t2, Easing.SinInOut),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX - 50, MiddleLeftBox.TranslationY, t2, Easing.SinInOut),
                RightBox.RotateTo(180, t2, Easing.SinInOut)
                );

            // Set Anchor to normal and compensate the translation

            RightBox.AnchorX = 0.5;
            RightBox.AnchorY = 0.5;

            RightBox.TranslationX += 100;
            RightBox.TranslationY += -100;

            RightBox.Rotation = 0;

            // Dritter Teil

            await Task.WhenAll(

                LeftBox.TranslateTo(LeftBox.TranslationX, LeftBox.TranslationY - 50, t3, Easing.SinInOut),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX, MiddleLeftBox.TranslationY + 50, t3, Easing.SinInOut),
                RightBox.TranslateTo(RightBox.TranslationX + 0, RightBox.TranslationY + 100, t3, Easing.SinInOut)
                );

            NameChanger = NameLeft;
            NameLeft = NameMiddleLeft;
            NameMiddleLeft = NameRight;
            NameRight = NameMiddleRight;
            NameMiddleRight = NameChanger;

        }

        public async Task RotateNinePointTwo(uint t = 750, uint t2 = 750, uint t3 = 750)
        {
            StoreNames();

            LeftBox.AnchorX = ZweiPositionen;
            MiddleLeftBox.AnchorX = ZweiPositionen;
            MiddleRightBox.AnchorX = ZweiPositionen;
            RightBox.AnchorX = -(DreiPositionen - 1);

            await Task.WhenAll(
                LeftBox.RotateTo(-90, t, Easing.SinInOut),
                MiddleLeftBox.RotateTo(90, t, Easing.SinInOut),
                MiddleRightBox.RotateTo(-180, t, Easing.SinInOut),
                RightBox.RotateTo(-180, t, Easing.SinInOut)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;


            LeftBox.TranslationX += 50;
            LeftBox.TranslationY += 50;
            MiddleLeftBox.TranslationX += 50;
            MiddleLeftBox.TranslationY += -50;
            MiddleRightBox.TranslationX += 100;
            RightBox.TranslationX += -150;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            // Zweiter Teil


            RightBox.AnchorX = ZweiPositionen;
            RightBox.AnchorY = -(ZweiPositionen - 1);
            MiddleRightBox.AnchorX = -(ZweiPositionen - 1);
            MiddleRightBox.AnchorY = ZweiPositionen;

            await Task.WhenAll(

                LeftBox.TranslateTo(LeftBox.TranslationX + 50, LeftBox.TranslationY, t2, Easing.SinInOut),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX + 50, MiddleLeftBox.TranslationY, t2, Easing.SinInOut),
                MiddleRightBox.RotateTo(180, t2, Easing.SinInOut),
                RightBox.RotateTo(180, t2, Easing.SinInOut)
                );

            // Set Anchor to normal and compensate the translation

            MiddleRightBox.AnchorX = 0.5;
            MiddleRightBox.AnchorY = 0.5;
            RightBox.AnchorX = 0.5;
            RightBox.AnchorY = 0.5;

            MiddleRightBox.TranslationX += -100;
            MiddleRightBox.TranslationY += 100;
            RightBox.TranslationX += 100;
            RightBox.TranslationY += -100;

            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            // Dritter Teil

            await Task.WhenAll(

                LeftBox.TranslateTo(LeftBox.TranslationX + 50, LeftBox.TranslationY - 50, t3, Easing.SinInOut),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX - 50, MiddleLeftBox.TranslationY + 50, t3, Easing.SinInOut),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX - 100, MiddleRightBox.TranslationY - 100, t3, Easing.SinInOut),
                RightBox.TranslateTo(RightBox.TranslationX - 50, RightBox.TranslationY + 100, t3, Easing.SinInOut)
                );

            NameChanger = NameLeft;
            NameLeft = NameMiddleRight;
            NameMiddleRight = NameMiddleLeft;
            NameMiddleLeft = NameRight;
            NameRight = NameChanger;

        }

        public async Task RotateTen(uint t = 500, uint t2 = 500, uint t3 = 500)
        {
            StoreNames();

            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = -(ZweiPositionen - 1);
            MiddleRightBox.AnchorX = ZweiPositionen;
            RightBox.AnchorX = 0.5;

            await Task.WhenAll(
                MiddleLeftBox.RotateTo(-270, t, Easing.Linear),
                MiddleRightBox.RotateTo(90, t, Easing.Linear)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;

            MiddleLeftBox.TranslationX += -50;
            MiddleLeftBox.TranslationY += 50;
            MiddleRightBox.TranslationX += 50;
            MiddleRightBox.TranslationY += -50;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;


            // Zweiter Teil


            await Task.WhenAll(

                LeftBox.TranslateTo(LeftBox.TranslationX + 50, LeftBox.TranslationY, t2, Easing.SinInOut),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX + 100, MiddleLeftBox.TranslationY, t2, Easing.SinInOut),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX - 100, MiddleRightBox.TranslationY, t2),
                RightBox.TranslateTo(RightBox.TranslationX - 50, RightBox.TranslationY, t2, Easing.SinInOut)
                );

            // Dritter Teil


            await Task.WhenAll(

                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX + 50, MiddleLeftBox.TranslationY - 50, t3, Easing.SinInOut),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX - 50, MiddleRightBox.TranslationY + 50, t3, Easing.SinInOut)
                );


            NameChanger = NameLeft;
            NameLeft = NameMiddleRight;
            NameMiddleRight = NameRight;
            NameRight = NameMiddleLeft;
            NameMiddleLeft = NameChanger;
        }

        public async Task RotateEleven(uint t = 1750)
        {
            StoreNames();

            LeftBox.AnchorX = EinePosition;
            MiddleLeftBox.AnchorX = -(EinePosition - 1);
            MiddleRightBox.AnchorX = EinePosition;
            RightBox.AnchorX = -(EinePosition - 1);

            await Task.WhenAny(
                LeftBox.RotateTo(900, t),
                MiddleLeftBox.RotateTo(900, t),
                MiddleRightBox.RotateTo(720, t),
                RightBox.RotateTo(720, t),

                LeftBox.TranslateTo(LeftBox.TranslationX, LeftBox.TranslationY - 75, t / 2, Easing.SinInOut),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX, MiddleLeftBox.TranslationY - 75, t / 2, Easing.SinInOut),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX, MiddleRightBox.TranslationY + 75, t / 2, Easing.SinInOut),
                RightBox.TranslateTo(RightBox.TranslationX, RightBox.TranslationY + 75, t / 2, Easing.SinInOut)
                );

            await Task.WhenAll(
                  LeftBox.TranslateTo(LeftBox.TranslationX, LeftBox.TranslationY + 75, t / 2, Easing.SinInOut),
                  MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX, MiddleLeftBox.TranslationY + 75, t / 2, Easing.SinInOut),
                  MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX, MiddleRightBox.TranslationY - 75, t / 2, Easing.SinInOut),
                  RightBox.TranslateTo(RightBox.TranslationX, RightBox.TranslationY - 75, t / 2, Easing.SinInOut)
                  );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;


            LeftBox.TranslationX += 50;
            MiddleLeftBox.TranslationX += -50;
            MiddleRightBox.TranslationX += 0;
            RightBox.TranslationX += 0;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            NameChanger = NameLeft;
            NameLeft = NameMiddleLeft;
            NameMiddleLeft = NameChanger;

        }

        public async Task RotateElevenPointOne(uint t = 1500)
        {
            StoreNames();

            LeftBox.AnchorX = EinePosition;
            MiddleLeftBox.AnchorX = -(EinePosition - 1);
            MiddleRightBox.AnchorX = EinePosition;
            RightBox.AnchorX = -(EinePosition - 1);

            await Task.WhenAny(
                LeftBox.RotateTo(540, t),
                MiddleLeftBox.RotateTo(540, t),
                MiddleRightBox.RotateTo(360, t),
                RightBox.RotateTo(360, t),

                LeftBox.TranslateTo(LeftBox.TranslationX, LeftBox.TranslationY - 75, t / 2, Easing.SinInOut),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX, MiddleLeftBox.TranslationY - 75, t / 2, Easing.SinInOut),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX, MiddleRightBox.TranslationY + 75, t / 2, Easing.SinInOut),
                RightBox.TranslateTo(RightBox.TranslationX, RightBox.TranslationY + 75, t / 2, Easing.SinInOut)
                );

            await Task.WhenAll(
                  LeftBox.TranslateTo(LeftBox.TranslationX, LeftBox.TranslationY + 75, t / 2, Easing.SinInOut),
                  MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX, MiddleLeftBox.TranslationY + 75, t / 2, Easing.SinInOut),
                  MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX, MiddleRightBox.TranslationY - 75, t / 2, Easing.SinInOut),
                  RightBox.TranslateTo(RightBox.TranslationX, RightBox.TranslationY - 75, t / 2, Easing.SinInOut)
                  );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;


            LeftBox.TranslationX += 50;
            MiddleLeftBox.TranslationX += -50;
            MiddleRightBox.TranslationX += 0;
            RightBox.TranslationX += 0;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            NameChanger = NameLeft;
            NameLeft = NameMiddleLeft;
            NameMiddleLeft = NameChanger;

        }

        public async Task RotateElevenPointTwo(uint t = 1250)
        {
            StoreNames();

            LeftBox.AnchorX = EinePosition;
            MiddleLeftBox.AnchorX = -(EinePosition - 1);
            MiddleRightBox.AnchorX = EinePosition;
            RightBox.AnchorX = -(EinePosition - 1);

            await Task.WhenAny(
                LeftBox.RotateTo(180, t),
                MiddleLeftBox.RotateTo(180, t),
                MiddleRightBox.RotateTo(360, t),
                RightBox.RotateTo(360, t),

                LeftBox.TranslateTo(LeftBox.TranslationX, LeftBox.TranslationY - 75, t / 2, Easing.SinInOut),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX, MiddleLeftBox.TranslationY - 75, t / 2, Easing.SinInOut),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX, MiddleRightBox.TranslationY + 75, t / 2, Easing.SinInOut),
                RightBox.TranslateTo(RightBox.TranslationX, RightBox.TranslationY + 75, t / 2, Easing.SinInOut)
                );

            await Task.WhenAll(
                  LeftBox.TranslateTo(LeftBox.TranslationX, LeftBox.TranslationY + 75, t / 2, Easing.SinInOut),
                  MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX, MiddleLeftBox.TranslationY + 75, t / 2, Easing.SinInOut),
                  MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX, MiddleRightBox.TranslationY - 75, t / 2, Easing.SinInOut),
                  RightBox.TranslateTo(RightBox.TranslationX, RightBox.TranslationY - 75, t / 2, Easing.SinInOut)
                  );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;


            LeftBox.TranslationX += 50;
            MiddleLeftBox.TranslationX += -50;
            MiddleRightBox.TranslationX += 0;
            RightBox.TranslationX += 0;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            NameChanger = NameLeft;
            NameLeft = NameMiddleLeft;
            NameMiddleLeft = NameChanger;

        }

        public async Task RotateTwelve(uint t = 500, uint t2 = 750, uint t3 = 500)
        {
            StoreNames();


            await Task.WhenAll(

                LeftBox.TranslateTo(LeftBox.TranslationX, LeftBox.TranslationY + 100, t),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX, MiddleLeftBox.TranslationY + 50, t),
                RightBox.TranslateTo(RightBox.TranslationX, RightBox.TranslationY - 50, t)
                );

            LeftBox.AnchorX = DreiPositionen;
            LeftBox.AnchorY = -(DreiPositionen - 1);
            MiddleLeftBox.AnchorX = EinePosition;
            MiddleLeftBox.AnchorY = -(EinePosition - 1);
            MiddleRightBox.AnchorX = -(EinePosition - 1);
            MiddleRightBox.AnchorY = EinePosition;
            RightBox.AnchorX = -(DreiPositionen - 1);
            RightBox.AnchorY = DreiPositionen;

            await Task.WhenAll(
                LeftBox.RotateTo(270, t2),
                MiddleLeftBox.RotateTo(270, t2),
                MiddleRightBox.RotateTo(270, t2),
                RightBox.RotateTo(270, t2)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            LeftBox.AnchorY = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorY = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            MiddleRightBox.AnchorY = 0.5;
            RightBox.AnchorX = 0.5;
            RightBox.AnchorY = 0.5;


            LeftBox.TranslationX += 150;
            MiddleLeftBox.TranslationX += 50;
            MiddleRightBox.TranslationX += -50;
            RightBox.TranslationX += -150;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            await Task.WhenAll(
                LeftBox.TranslateTo(LeftBox.TranslationX, LeftBox.TranslationY - 100, t3),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX, MiddleLeftBox.TranslationY - 50, t3),
                RightBox.TranslateTo(RightBox.TranslationX, RightBox.TranslationY + 50, t3)
                );

            NameChanger = NameLeft;
            NameLeft = NameRight;
            NameRight = NameChanger;
            NameChanger = NameMiddleLeft;
            NameMiddleLeft = NameMiddleRight;
            NameMiddleRight = NameChanger;
        }

        public async Task RotateTwelvePointOne(uint t = 500, uint t2 = 2000, uint t3 = 500)
        {
            StoreNames();
            Easing easing = Easing.SinInOut;

            await Task.WhenAll(

                LeftBox.TranslateTo(LeftBox.TranslationX, LeftBox.TranslationY + 100, t),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX, MiddleLeftBox.TranslationY + 50, t),
                RightBox.TranslateTo(RightBox.TranslationX, RightBox.TranslationY - 50, t)
                );

            LeftBox.AnchorX = DreiPositionen;
            LeftBox.AnchorY = -(DreiPositionen - 1);
            MiddleLeftBox.AnchorX = EinePosition;
            MiddleLeftBox.AnchorY = -(EinePosition - 1);
            MiddleRightBox.AnchorX = -(EinePosition - 1);
            MiddleRightBox.AnchorY = EinePosition;
            RightBox.AnchorX = -(DreiPositionen - 1);
            RightBox.AnchorY = DreiPositionen;

            await Task.WhenAll(
                LeftBox.RotateTo(630, t2, easing),
                MiddleLeftBox.RotateTo(630, t2, easing),
                MiddleRightBox.RotateTo(630, t2, easing),
                RightBox.RotateTo(630, t2, easing)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            LeftBox.AnchorY = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorY = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            MiddleRightBox.AnchorY = 0.5;
            RightBox.AnchorX = 0.5;
            RightBox.AnchorY = 0.5;


            LeftBox.TranslationX += 150;
            MiddleLeftBox.TranslationX += 50;
            MiddleRightBox.TranslationX += -50;
            RightBox.TranslationX += -150;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            await Task.WhenAll(
                LeftBox.TranslateTo(LeftBox.TranslationX, LeftBox.TranslationY - 100, t3),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX, MiddleLeftBox.TranslationY - 50, t3),
                RightBox.TranslateTo(RightBox.TranslationX, RightBox.TranslationY + 50, t3)
                );

            NameChanger = NameLeft;
            NameLeft = NameRight;
            NameRight = NameChanger;
            NameChanger = NameMiddleLeft;
            NameMiddleLeft = NameMiddleRight;
            NameMiddleRight = NameChanger;
        }

        public async Task RotateThirteen(uint t = 750)
        {
            StoreNames();
            Easing easing = Easing.SinInOut;

            LeftBox.AnchorX = DreiPositionen;
            MiddleLeftBox.AnchorX = EinePosition;
            MiddleRightBox.AnchorX = -(EinePosition - 1);
            RightBox.AnchorX = -(DreiPositionen - 1);
            await Task.WhenAll(
                LeftBox.RotateTo(180, t, easing),
                MiddleLeftBox.RotateTo(180, t, easing),
                MiddleRightBox.RotateTo(180, t, easing),
                RightBox.RotateTo(180, t, easing)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            LeftBox.TranslationX += 150;
            MiddleLeftBox.TranslationX += 50;
            MiddleRightBox.TranslationX += -50;
            RightBox.TranslationX += -150;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            NameChanger = NameLeft;
            NameLeft = NameRight;
            NameRight = NameChanger;
            NameChanger = NameMiddleLeft;
            NameMiddleLeft = NameMiddleRight;
            NameMiddleRight = NameChanger;
        }

        public async Task RotateThirteenPointOne(uint t = 750)
        {
            StoreNames();
            Easing easing = Easing.SinInOut;

            LeftBox.AnchorX = DreiPositionen;
            MiddleLeftBox.AnchorX = EinePosition;
            MiddleRightBox.AnchorX = -(EinePosition - 1);
            RightBox.AnchorX = -(DreiPositionen - 1);
            await Task.WhenAll(
                LeftBox.RotateTo(180, t, easing),
                MiddleLeftBox.RotateTo(-180, t, easing),
                MiddleRightBox.RotateTo(-180, t, easing),
                RightBox.RotateTo(180, t, easing)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            LeftBox.TranslationX += 150;
            MiddleLeftBox.TranslationX += 50;
            MiddleRightBox.TranslationX += -50;
            RightBox.TranslationX += -150;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            NameChanger = NameLeft;
            NameLeft = NameRight;
            NameRight = NameChanger;
            NameChanger = NameMiddleLeft;
            NameMiddleLeft = NameMiddleRight;
            NameMiddleRight = NameChanger;
        }

        public async Task RotateFourteen(uint t = 750)
        {
            StoreNames();
            PositionMovedToTheRight += -1;

            LeftBox.AnchorX = EinePosition;
            MiddleLeftBox.AnchorX = -(EinePosition - 1);
            MiddleRightBox.AnchorX = EinePosition;
            RightBox.AnchorX = -(EinePosition - 1);

            await Task.WhenAll(
                LeftBox.RotateTo(-180, t),
                MiddleLeftBox.RotateTo(-180, t),
                MiddleRightBox.RotateTo(-180, t),
                RightBox.RotateTo(-180, t),

                LeftBox.TranslateTo(LeftBox.TranslationX - 50, LeftBox.TranslationY, t),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX - 50, MiddleLeftBox.TranslationY, t),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX - 50, MiddleRightBox.TranslationY, t),
                RightBox.TranslateTo(RightBox.TranslationX - 50, RightBox.TranslationY, t)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;


            LeftBox.TranslationX += 50;
            MiddleLeftBox.TranslationX += -50;
            MiddleRightBox.TranslationX += 50;
            RightBox.TranslationX += -50;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            NameChanger = NameLeft;
            NameLeft = NameMiddleLeft;
            NameMiddleLeft = NameChanger;
            NameChanger = NameMiddleRight;
            NameMiddleRight = NameRight;
            NameRight = NameChanger;
        }

        public async Task RotateFourteenPointOne(uint t = 750)
        {
            StoreNames();
            PositionMovedToTheRight += 1;

            LeftBox.AnchorX = EinePosition;
            MiddleLeftBox.AnchorX = -(EinePosition - 1);
            MiddleRightBox.AnchorX = EinePosition;
            RightBox.AnchorX = -(EinePosition - 1);

            await Task.WhenAll(
                LeftBox.RotateTo(-180, t),
                MiddleLeftBox.RotateTo(-180, t),
                MiddleRightBox.RotateTo(-180, t),
                RightBox.RotateTo(-180, t),

                LeftBox.TranslateTo(LeftBox.TranslationX + 50, LeftBox.TranslationY, t),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX + 50, MiddleLeftBox.TranslationY, t),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX + 50, MiddleRightBox.TranslationY, t),
                RightBox.TranslateTo(RightBox.TranslationX + 50, RightBox.TranslationY, t)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;


            LeftBox.TranslationX += 50;
            MiddleLeftBox.TranslationX += -50;
            MiddleRightBox.TranslationX += 50;
            RightBox.TranslationX += -50;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            NameChanger = NameLeft;
            NameLeft = NameMiddleLeft;
            NameMiddleLeft = NameChanger;
            NameChanger = NameMiddleRight;
            NameMiddleRight = NameRight;
            NameRight = NameChanger;
        }

        public async Task RotateFifteen(uint t = 750, uint t2 = 1000)
        {
            StoreNames();


            LeftBox.AnchorX = EinePosition;
            MiddleLeftBox.AnchorX = -(EinePosition - 1);
            MiddleRightBox.AnchorX = EinePosition;
            RightBox.AnchorX = -(EinePosition - 1);

            await Task.WhenAll(
                LeftBox.RotateTo(-180, t, Easing.SinInOut),
                MiddleLeftBox.RotateTo(-180, t, Easing.SinInOut),
                MiddleRightBox.RotateTo(-180, t, Easing.SinInOut),
                RightBox.RotateTo(-180, t, Easing.SinInOut),

                LeftBox.TranslateTo(LeftBox.TranslationX - 50, LeftBox.TranslationY, t, Easing.SinInOut),
                MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX - 50, MiddleLeftBox.TranslationY, t, Easing.SinInOut),
                MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX + 50, MiddleRightBox.TranslationY, t, Easing.SinInOut),
                RightBox.TranslateTo(RightBox.TranslationX + 50, RightBox.TranslationY, t, Easing.SinInOut)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;


            LeftBox.TranslationX += 50;
            MiddleLeftBox.TranslationX += -50;
            MiddleRightBox.TranslationX += 50;
            RightBox.TranslationX += -50;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            // Teil Zwei
            LeftBox.AnchorX = ZweiPositionen;
            MiddleLeftBox.AnchorX = VierPositionen;
            MiddleRightBox.AnchorX = -(VierPositionen - 1);
            RightBox.AnchorX = -(ZweiPositionen - 1);

            await Task.WhenAll(
                LeftBox.RotateTo(-180, t2, Easing.SinInOut),
                MiddleLeftBox.RotateTo(180, t2, Easing.SinInOut),
                MiddleRightBox.RotateTo(180, t2, Easing.SinInOut),
                RightBox.RotateTo(-180, t2, Easing.SinInOut)
                );

            // Set Anchor to normal and compensate the translation
            LeftBox.AnchorX = 0.5;
            MiddleLeftBox.AnchorX = 0.5;
            MiddleRightBox.AnchorX = 0.5;
            RightBox.AnchorX = 0.5;


            LeftBox.TranslationX += 100;
            MiddleLeftBox.TranslationX += 200;
            MiddleRightBox.TranslationX += -200;
            RightBox.TranslationX += -100;

            LeftBox.Rotation = 0;
            MiddleLeftBox.Rotation = 0;
            MiddleRightBox.Rotation = 0;
            RightBox.Rotation = 0;

            NameChanger = NameLeft;
            NameLeft = NameMiddleRight;
            NameMiddleRight = NameChanger;
            NameChanger = NameMiddleLeft;
            NameMiddleLeft = NameRight;
            NameRight = NameChanger;
        }


        public async Task MoveToCenterInRow()
        {
            await Box1.TranslateTo(10, 10, 1, Easing.Linear); // bewirkt nichts, weil der den ersten Befehl hier nicht packt..
            await Box1.TranslateTo((Box4.X / 2) - 75, Box4.Y / 2, 0, Easing.Linear);
            await Box2.TranslateTo(-(Box4.X / 2) - 25, Box4.Y / 2, 0, Easing.Linear);
            await Box3.TranslateTo((Box4.X / 2) + 25, -(Box4.Y / 2), 0, Easing.Linear);
            await Box4.TranslateTo(-(Box4.X / 2) + 75, -(Box4.Y / 2), 0, Easing.Linear);

            NameLeft = "Box1";
            NameMiddleLeft = "Box2";
            NameMiddleRight = "Box3";
            NameRight = "Box4";
        }

        public async Task MoveBackInCorners(uint t = 250, uint t2 = 750)
        {
            StoreNames();


            await Task.WhenAll(
              LeftBox.TranslateTo(LeftBox.TranslationX, LeftBox.TranslationY - 25, t, Easing.SinInOut),
              MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX, MiddleLeftBox.TranslationY - 25, t, Easing.SinInOut),
              MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX, MiddleRightBox.TranslationY + 25, t, Easing.SinInOut),
              RightBox.TranslateTo(RightBox.TranslationX, RightBox.TranslationY + 25, t, Easing.SinInOut)
             );

            await Task.WhenAll(
             LeftBox.TranslateTo(LeftBox.TranslationX - ((Box4.X / 2) - 75) - (PositionMovedToTheRight * 50) + 90, LeftBox.TranslationY - (Box4.Y / 2) + 25 + 90, t2, Easing.SinInOut),
             MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX + (Box4.X / 2) + 25 - (PositionMovedToTheRight * 50) - 90, MiddleLeftBox.TranslationY - (Box4.Y / 2) + 25 + 90, t2, Easing.SinInOut),
             MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX - (Box4.X / 2) - 25 - (PositionMovedToTheRight * 50) + 90, MiddleRightBox.TranslationY + (Box4.Y / 2) - 25 - 90, t2, Easing.SinInOut),
             RightBox.TranslateTo(RightBox.TranslationX + (Box4.X / 2) - (PositionMovedToTheRight * 50) - 75 - 90, RightBox.TranslationY + (Box4.Y / 2) - 25 - 90, t2, Easing.SinInOut)
            );
        }

        public void StoreNames()
        {
            LeftBox = this.FindByName<BoxView>(NameLeft);
            MiddleLeftBox = this.FindByName<BoxView>(NameMiddleLeft);
            MiddleRightBox = this.FindByName<BoxView>(NameMiddleRight);
            RightBox = this.FindByName<BoxView>(NameRight);
        }

        public async Task FadeBoxesToZero(uint t)
        {
            await Task.WhenAll(
                  Box1.FadeTo(0, t),
                  Box2.FadeTo(0, t),
                  Box3.FadeTo(0, t),
                  Box4.FadeTo(0, t)
                );
        }

        public async Task FadeBoxesToOne(uint t)
        {
            await Task.WhenAll(
                  Box1.FadeTo(1, t),
                  Box2.FadeTo(1, t),
                  Box3.FadeTo(1, t),
                  Box4.FadeTo(1, t)
                );
        }

        public void DrawBoxRed(int i)
        {
            if (i == 1)
            {
                Box1.Color = System.Drawing.Color.Red;
            }
            if (i == 2)
            {
                Box2.Color = System.Drawing.Color.Red;
            }
            if (i == 3)
            {
                Box3.Color = System.Drawing.Color.Red;
            }
            if (i == 4)
            {
                Box4.Color = System.Drawing.Color.Red;
            }
        }

        public void DrawBoxesWhite()
        {

            Box1.Color = System.Drawing.Color.White;
            Box2.Color = System.Drawing.Color.White;
            Box3.Color = System.Drawing.Color.White;
            Box4.Color = System.Drawing.Color.White;

        }

    }
}