using System;
using OpenTK.Platform.Android;
using OpenTK.Graphics;
using OpenTK;

using Shared.Engine.Base;
using Android.Content;

namespace Engine.Android
{
    public class CustomGLView : AndroidGameView
    {
        //Instance of the game
        protected readonly BaseGame _gameInstance;

        //Creating the View - Constuctor
        // <params> name = context
        public CustomGLView(Context context, BaseGame gameInstance) : base(context)
        {
            _gameInstance = gameInstance;
        }

        //Called when the view is loaded - it starts running the game
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Run(60);
        }

        // Overriding and Creating the frame buffer to certain version 
        protected override void CreateFrameBuffer()
        {
            try
            {
                GLContextVersion = GLContextVersion.Gles2_0;
                base.CreateFrameBuffer();
                return;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        // Called every frame to render all objects
        // <params> name = e
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            _gameInstance.Draw();
            SwapBuffers();
        }
    }
}