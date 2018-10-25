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
            AbsoluteLayoutExplorationCode();
        }

        public void AbsoluteLayoutExplorationCode()
        {
            Title = "Absolute Layout Exploration - Code";
            var layout = new AbsoluteLayout();

            var UpperLeftBox = new BoxView { Color = Color.Blue };
            AbsoluteLayout.SetLayoutBounds(UpperLeftBox, new Rectangle(0, 0, 30, 30));
            AbsoluteLayout.SetLayoutFlags(UpperLeftBox, AbsoluteLayoutFlags.PositionProportional);

            var UpperRightBox = new BoxView { Color = Color.Red };
            AbsoluteLayout.SetLayoutBounds(UpperRightBox, new Rectangle(1, 0, 30, 30));
            AbsoluteLayout.SetLayoutFlags(UpperRightBox, AbsoluteLayoutFlags.PositionProportional);

            var LowerLeftBox = new BoxView { Color = Color.Blue };
            AbsoluteLayout.SetLayoutBounds(LowerLeftBox, new Rectangle(0, 1, 30, 30));
            AbsoluteLayout.SetLayoutFlags(LowerLeftBox, AbsoluteLayoutFlags.PositionProportional);

            var LowerRightBox = new BoxView { Color = Color.Blue };
            AbsoluteLayout.SetLayoutBounds(LowerRightBox, new Rectangle(1, 1, 30, 30));
            AbsoluteLayout.SetLayoutFlags(LowerRightBox, AbsoluteLayoutFlags.PositionProportional);

            layout.Children.Add(UpperLeftBox);
            layout.Children.Add(UpperRightBox);
            layout.Children.Add(LowerLeftBox);
            layout.Children.Add(LowerRightBox);

            Content = layout;
        }



    }
}
