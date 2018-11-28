using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Spiel
{
    public partial class MainPage : ContentPage
    {
        public MainPage(int value)
        {
            InitializeComponent();       
            

            switch (a)
            {
                case 1:
                    Button1.BackgroundColor = System.Drawing.Color.Green;
                    break;
                case 2:
                    Button2.BackgroundColor = System.Drawing.Color.Green;
                    break;
                case 3:
                    Button3.BackgroundColor = System.Drawing.Color.Green;
                    break;
                case 4:
                    Button4.BackgroundColor = System.Drawing.Color.Green;
                    break;
                case 5:
                    Button5.BackgroundColor = System.Drawing.Color.Green;
                    break;
                case 6:
                    Button6.BackgroundColor = System.Drawing.Color.Green;
                    break;
                //case 7:
                //    value = 1;   so ändert das nicht value von MainActivity.. noch anders machen..
                //    break;
                default:
                    break;
            }       
            
        }

        public int a { get; set; }


        public async Task NeueSeite()
        {
            await Task.Delay(10);
            App.Current.MainPage = new RundeEins();
        }




        public void Button_Clicked_1(object sender, EventArgs e)
        {

            App.Current.MainPage = new RundeEins();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            App.Current.MainPage = new RundeZwei();
        }


        private void Button_Clicked_3(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {

        }
    }
}
