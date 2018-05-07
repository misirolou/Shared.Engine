using Android.App;
using Android.Widget;
using Android.OS;
using Engine.Android;
using Game.Shared;
using Game.Shared.Base;
using Android.Content.PM;

namespace App1
{
    // label = name for the Application, Mainlaunher to start,  can add other attributes to start
    // ScreenOrientation = forces orientation of screen
    [Activity(Label = "Game", MainLauncher = true, Theme = "@style/MainTheme", Icon = "@drawable/dance", ScreenOrientation = ScreenOrientation.Landscape)]
    public class MainActivity : GameActivity
    {
        public MainActivity() : base(new GLGame())
        {

        }
    }
}

