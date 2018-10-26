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

            //var UpperLeftBox = new BoxView { Color = Color.Blue };
            //AbsoluteLayout.SetLayoutBounds(UpperLeftBox, new Rectangle(0, 0, 30, 30));
            //AbsoluteLayout.SetLayoutFlags(UpperLeftBox, AbsoluteLayoutFlags.PositionProportional);

            layout = new AbsoluteLayout();

            var UpperLeftBox = new BoxView { Color = Color.Blue };
            BoundsOfBox(UpperLeftBox, 0, 0, 40, 40);

            //layout.Children.Add(UpperLeftBox);

            Content = layout;

        }
        public AbsoluteLayout layout { get; set; }

        //AbsoluteLayout.SetLayoutBounds(LowerRightBox, new Rectangle(1, 1, 30, 30));
        //    AbsoluteLayout.SetLayoutFlags(LowerRightBox, AbsoluteLayoutFlags.PositionProportional);
        public void BoundsOfBox (BindableObject BoxName, double xProportional, double yProportional, int xSize, int ySize)
        {
            AbsoluteLayout.SetLayoutBounds(BoxName, new Rectangle(xProportional, yProportional, xSize, ySize));
            AbsoluteLayout.SetLayoutFlags(BoxName, AbsoluteLayoutFlags.PositionProportional);
            View view = (View)BoxName;
            layout.Children.Add(view);
        }
    }
}
