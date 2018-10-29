﻿using System;
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

            int counterPropertyChangedBox2 = 0;
            int counterPropertyChangedBox3 = 0;
            int counterPropertyChangedBox4 = 0;


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
             await MoveToCenter();
        }

        public async Task MoveToCenter()
        {

            
            await Box1.TranslateTo(Box4StartWidth / 2, Box4StartHeight / 2, 2000, Easing.Linear);
            await Box2.TranslateTo(-(Box4StartWidth / 2), Box4StartHeight / 2, 2000, Easing.Linear);
            await Box3.TranslateTo(Box4StartWidth / 2, -(Box4StartHeight / 2), 2000, Easing.Linear);
            await Box4.TranslateTo(-(Box4StartWidth / 2), -(Box4StartHeight / 2), 2000, Easing.Linear);
            await Box2.TranslateTo(Box2StartWidth - Box2Width, Box2StartHeight - Box2Height, 3000, Easing.Linear); // moves box 2 back in Start Position
            await Box3.TranslateTo(Box3StartWidth - Box3Width, Box3StartHeight - Box3Height, 3000, Easing.Linear);

        }
    }
}
