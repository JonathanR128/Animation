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
        public MainPage(int value, int enter)
        {
            InitializeComponent();       
            

            switch (value)
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
                default:
                    break;
            }   
            
            if (enter == 1)
            {
                LoadSpiel(value);
            } 
            
        }

        public int a { get; set; }


        public async Task LoadSpiel(int i)
        {
            await Task.Delay(10);
            switch (i)
            {
                case 1:
                    App.Current.MainPage = new RundeEins();
                    break;
                case 2:
                    App.Current.MainPage = new RundeZwei();
                    break;
                case 3:
                    App.Current.MainPage = new RundeDrei();
                    break;
                case 4:
                    App.Current.MainPage = new RundeVier();
                    break;
                case 5:
                    App.Current.MainPage = new RundeFuenf();
                    break;
                case 6:
                    App.Current.MainPage = new RundeSechs();
                    break;
            }
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
            App.Current.MainPage = new RundeDrei();
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            App.Current.MainPage = new RundeVier();
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            App.Current.MainPage = new RundeFuenf();
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            App.Current.MainPage = new RundeSechs();
        }
    }
}
