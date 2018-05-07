using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using OpenTK;
using Shared.Engine.Base;

namespace Engine.Android
{
    public abstract class GameActivity : Activity
    {
        // View used for our game
        protected CustomGLView _view;
        //Instance of the game
        protected BaseGame _gameInstance;

        //Creates the gameActivity
        // <param> name = gameInstance
        protected GameActivity(BaseGame gameInstance)
        {
            _gameInstance = gameInstance;
        }

        //Called when the activity is creted - it creates the view and the game
        // <param> name = bundle
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            _view = new CustomGLView(this, _gameInstance);
            //Helps to receive the info on the size of screen
            Point point = new Point();
            WindowManager.DefaultDisplay.GetRealSize(point);
            _gameInstance.Init(new Vector2(point.X, point.Y));
            //Decorate view to view full screen
            Window.DecorView.SystemUiVisibility |= (StatusBarVisibility)(Int32)
            (SystemUiFlags.HideNavigation
            | SystemUiFlags.Fullscreen
            | SystemUiFlags.LayoutFullscreen
            | SystemUiFlags.ImmersiveSticky
            | SystemUiFlags.LayoutStable);
            SetContentView(_view);
        }

        //Called  when the activity is paused - pauses the view
        protected override void OnPause()
        {
            base.OnPause();
            _view.Pause();
        }

        //Called when  the activity is resumed - resumes the view
        protected override void OnResume()
        {
            base.OnResume();
            _view.Resume();
        }
    }
}