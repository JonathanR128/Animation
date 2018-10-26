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

            var layout = new AbsoluteLayout();

            var UpperLeftBox = new BoxView { Color = Color.Blue };
            AbsoluteLayout.SetLayoutBounds(UpperLeftBox, new Rectangle(0, 0, 30, 30));
            AbsoluteLayout.SetLayoutFlags(UpperLeftBox, AbsoluteLayoutFlags.PositionProportional);


            Layout = new AbsoluteLayout();
            


            //double LayoutWidth = 689.5;
            //double LayoutHeight = 386.3;
            //double UpperRightBoxHeight = 0;


            //layout.SizeChanged += (sender, e) =>
            //{
            //    UpperRightBoxHeight = UpperRightBox.Y;
            //};


            //  UpperLeftBox.TranslateTo(LayoutWidth/2 - 50, LayoutHeigth/2, 3000, Easing.Linear);

        }
        public Layout Layout { get; set; }

        //public async Task MoveRectanglesAsync()
        //{
        //    UpperRightBox.TranslateTo(-200, 80 - UpperRightBoxHeight, 5000, Easing.Linear);  
        //}

        public class Rectangle : BoxView
        {
             BoxView UpperLeftBox = new BoxView { Color = Color.Blue };
             
            
        }

        //AbsoluteLayout.SetLayoutBounds(LowerRightBox, new Rectangle(1, 1, 30, 30));
        //    AbsoluteLayout.SetLayoutFlags(LowerRightBox, AbsoluteLayoutFlags.PositionProportional);
        public void Bounds(BindableObject BoxName, double xProportional, double yProportional, int xSize, int ySize)
        {
            AbsoluteLayout.SetLayoutBounds(BoxName, new Rectangle(xProportional, yProportional, xSize, ySize));
            AbsoluteLayout.SetLayoutFlags(BoxName, AbsoluteLayoutFlags.PositionProportional);
        }


    }
}
