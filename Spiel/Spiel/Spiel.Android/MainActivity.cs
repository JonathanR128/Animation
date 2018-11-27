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
        public override bool OnKeyUp(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.DpadRight)
            {               
                return true;
            }
            if (keyCode == Keycode.DpadLeft)
            {
                return true;
            }
            if (keyCode == Keycode.Enter)
            {
                return true;
            }
            if (keyCode == Keycode.Back)
            {
                return true;
            }
            return base.OnKeyUp(keyCode, e);
        }

        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.DpadRight)
            {
                App.Current.MainPage = new RundeEins();
                return true;
            }
            if (keyCode == Keycode.DpadLeft)
            {
                App.Current.MainPage = new RundeEins();
                return true;
            }
            if (keyCode == Keycode.Enter)
            {
                App.Current.MainPage = new RundeEins();
                return true;
            }
            if (keyCode == Keycode.Back)
            {
                App.Current.MainPage = new MainPage();
            }
            if (keyCode == Keycode.DpadUp)
            {
                App.Current.MainPage = new RundeEins();
                return true;
            }

            return base.OnKeyDown(keyCode, e);
        }



        public override bool OnTouchEvent(MotionEvent e)
        {
            
            return base.OnTouchEvent(e);
        }

        //public override bool OnTouchEvent(MotionEvent e)
        //{


        //    App.Current.MainPage = new RundeEins();

        //    return true;
        //}

    }
}