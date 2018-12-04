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
	public partial class RundeEins : ContentPage
	{
		public RundeEins ()
		{
			InitializeComponent ();


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


        public int[,] Rotationsreihenfolge = new int[,]
        {
            { 20, 5, 17, 1, 13, 0, 0, 0, 0, 0, 0, 0 },
            { 22, 7, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 10, 19, 16, 2, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 6, 8, 3, 9, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 15, 6, 9, 13, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 7, 12, 11, 14, 1, 0, 0, 0, 0, 0, 0, 0},
            { 6, 3, 8, 21, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 5, 17, 1, 20, 13, 0, 0, 0, 0, 0, 0, 0 },
            { 7, 22, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 16, 19, 2, 10, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 3, 6, 8, 21, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 13, 6, 15, 9, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 7, 12, 11, 14, 1, 0, 0, 0, 0, 0, 0, 0},
            { 6, 3, 8, 21, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 20, 5, 17, 1, 13, 0, 0, 0, 0, 0, 0, 0 },
            { 7, 22, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 16, 10, 19, 2, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 6, 8, 3, 9, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 9, 6, 25, 13, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 7, 12, 1, 11, 14, 0, 0, 0, 0, 0, 0, 0}

        };

        public int[] RedBox = new int[] { 1, 4, 3, 4, 1, 2, 4, 1, 3, 2, 2, 2, 3, 4, 2, 3, 3, 2, 3, 4 };

        public async Task RotationRandom(int i)
        {
            switch (i)
            {
                case 1:
                    await RotateOne();
                    break;
                case 2:
                    await RotateTwo();
                    break;
                case 3:
                    await RotateThree();
                    break;
                case 4:
                    await RotateFour();
                    break;
                case 5:
                    await RotateFive();
                    break;
                case 6:
                    await RotateSix();
                    break;
                case 7:
                    await RotateSeven();
                    break;
                case 8:
                    await RotateEight();
                    break;
                case 9:
                    await RotateNine();
                    break;
                case 10:
                    await RotateTen();
                    break;
                case 11:
                    await RotateEleven();
                    break;
                case 12:
                    await RotateTwelve();
                    break;
                case 13:
                    await RotateThirteen();
                    break;
                case 14:
                    await RotateThreePointOne();
                    break;
                case 15:
                    await RotateFourPointOne();
                    break;
                case 16:
                    await RotateSixPointOne();
                    break;
                case 17:
                    await RotateSixPointTwo();
                    break;
                case 18:
                    await RotateEightPointOne();
                    break;
                case 19:
                    await RotateEightPointTwo();
                    break;
                case 20:
                    await RotateElevenPointOne();
                    break;
                case 21:
                    await RotateElevenPointTwo();
                    break;
                case 22:
                    await RotateTwelvePointOne();
                    break;
                default:
                    break;

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

                await RotationRandom(Rotationsreihenfolge[i, 0]);
                await RotationRandom(Rotationsreihenfolge[i, 1]);
                await RotationRandom(Rotationsreihenfolge[i, 2]);
                await RotationRandom(Rotationsreihenfolge[i, 3]);
                await RotationRandom(Rotationsreihenfolge[i, 4]);
                await RotationRandom(Rotationsreihenfolge[i, 5]);
                await RotationRandom(Rotationsreihenfolge[i, 6]);
                await RotationRandom(Rotationsreihenfolge[i, 7]);
                await RotationRandom(Rotationsreihenfolge[i, 8]);
                await RotationRandom(Rotationsreihenfolge[i, 9]);
                await RotationRandom(Rotationsreihenfolge[i, 10]);
                await RotationRandom(Rotationsreihenfolge[i, 11]);

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

        public async Task MoveTester()
        {
            await Task.Delay(1200);
            Countdown10.FadeTo(0, 0);
            PositionMovedToTheRight = 0;
            DrawBoxesWhite();
            await MoveToCenterInRow();
            await FadeBoxesToOne(1000);
            await Task.Delay(1000);
            DrawPaintOnBoxes();
            await Task.Delay(1000);

            await RotateOne();



            await MoveBackInCorners();
            await Task.Delay(2750);
            await FadeBoxesToZero(1000);
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

        public async Task RotateFive(uint t = 750, uint t2 = 750)
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

        public async Task RotateNine(uint t = 500, uint t2 = 500, uint t3 = 500)
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


        //public async Task Grundgeruest()
        //{
        //    StoreNames();

        //    await Task.Delay(200);

        //    LeftBox.AnchorX = 0.5;
        //    MiddleLeftBox.AnchorX = 0.5;
        //    MiddleRightBox.AnchorX = 0.5;
        //    RightBox.AnchorX = 0.5;

        //    await Task.WhenAll(
        //        LeftBox.RotateTo(),
        //        MiddleLeftBox.RotateTo(),
        //        MiddleRightBox.RotateTo(),
        //        RightBox.RotateTo(),

        //        LeftBox.TranslateTo(LeftBox.TranslationX, LeftBox.TranslationY, 750),
        //        MiddleLeftBox.TranslateTo(MiddleLeftBox.TranslationX, MiddleLeftBox.TranslationY, 750),
        //        MiddleRightBox.TranslateTo(MiddleRightBox.TranslationX, MiddleRightBox.TranslationY, 750),
        //        RightBox.TranslateTo(RightBox.TranslationX, RightBox.TranslationY, 750)
        //        );

        //    // Set Anchor to normal and compensate the translation
        //    LeftBox.AnchorX = 0.5;
        //    MiddleLeftBox.AnchorX = 0.5;
        //    MiddleRightBox.AnchorX = 0.5;
        //    RightBox.AnchorX = 0.5;


        //    LeftBox.TranslationX += 0;
        //    MiddleLeftBox.TranslationX += 0;
        //    MiddleRightBox.TranslationX += 0;
        //    RightBox.TranslationX += 0;

        //    LeftBox.Rotation = 0;
        //    MiddleLeftBox.Rotation = 0;
        //    MiddleRightBox.Rotation = 0;
        //    RightBox.Rotation = 0;
        //    // irgendwie Namechanging allgemein?
        //    //NameChanger = NameMiddleLeft;
        //    //NameMiddleLeft = NameRight;
        //    //NameRight = NameChanger;

        //}


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

        public void DrawPaintOnBoxes()
        {

            Box1.Color = System.Drawing.Color.Black;
            Box2.Color = System.Drawing.Color.Blue;
            Box3.Color = System.Drawing.Color.LawnGreen;
            Box4.Color = System.Drawing.Color.DeepPink;

        }

        public void DrawBoxesWhite()
        {

            Box1.Color = System.Drawing.Color.White;
            Box2.Color = System.Drawing.Color.White;
            Box3.Color = System.Drawing.Color.White;
            Box4.Color = System.Drawing.Color.White;

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