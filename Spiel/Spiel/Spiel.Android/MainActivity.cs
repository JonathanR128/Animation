using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Spiel.Droid
{
    [Activity(Label = "Spiel", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            this.Window.SetFlags(WindowManagerFlags.KeepScreenOn, WindowManagerFlags.KeepScreenOn);
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

           
            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }

        public int value { get; set; }
        public int enter { get; set; }

        public override bool OnKeyUp(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back)
            {
                return true;
            }
            if (keyCode == Keycode.DpadCenter)
            {
                return true;
            }


            return base.OnKeyUp(keyCode, e);
        }

        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (enter == 0)
            {

                if (keyCode == Keycode.Back)
                {
                    if (value == 6)
                    {
                        value = 0;
                    }
                    value += 1;
                    App.Current.MainPage = new MainPage(value, enter);
                    return true;

                }
               
            }
            if (keyCode == Keycode.DpadCenter)
            {
                
                if ((enter == 0) && (value != 0))                                             // if damit man mit wiederholtem Enter nicht das Spiel neu startet
                {
                    enter += 1;
                    App.Current.MainPage = new MainPage(value, enter);
                }

                return true;
            }

            return true;
        }
               

        public override bool OnTouchEvent(MotionEvent e)
        {
            
            return base.OnTouchEvent(e);
        }
    }
}