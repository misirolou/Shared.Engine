using Android.App;
using Android.Widget;
using Android.OS;
using Engine.Android;
using Game.Shared;
using Game.Shared.Base;

namespace App1
{
    // label = name for the Application, Mainlaunher to start,  can add other attributes to start
    [Activity(Label = "Game", MainLauncher = true, Theme = "@style/MainTheme", Icon = "@drawable/dance")]
    public class MainActivity : GameActivity
    {
        public MainActivity() : base(new GLGame())
        {

        }
    }
}

