using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObjCRuntime;

using Foundation;
using OpenTK.Platform.iPhoneOS;
using UIKit;
using Shared.Engine.Base;
using OpenGLES;
using CoreGraphics;
using CoreAnimation;
using OpenTK;

namespace Engine.iOS
{
    public class GameView : iPhoneOSGameView
    {
        // Instance of game
        private GameView _GameInstance;

        [Export("layerClass")]
        public static Class GetLayerClass()
        {
            return iPhoneOSGameView.GetLayerClass();
        }

        //Set Game Instance
        // <param> name = gameInstance
        public void SetGameInstance(BaseGame gameInstance)
        {
            _GameInstance = gameInstance;
        }

        [Export("initWithFrame:")]
        public GameView(CGRect frame) : base(frame)
        {
            LayerColorFormat = EAGLColorFormat.RGBA8;
            ContentScaleFactor = UIScreen.MainScreen.Scale;
        }

        protected override void CreateFrameBuffer()
        {
            try
            {
                ContextRenderingApi = EAGLRenderingAPI.OpenGLES3;
                base.CreateFrameBuffer();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        // <summary> Configure the layer by making it opaque contains other option
        // <param> name= "eagleLayer" 
        protected override void ConfigureLayer(CAEAGLLayer eaglLayer)
        {
            eaglLayer.Opaque = true;
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            _GameInstance.Draw();
            SwapBuffers();
        }

        public static implicit operator GameView(BaseGame v)
        {
            throw new NotImplementedException();
        }
    }
}