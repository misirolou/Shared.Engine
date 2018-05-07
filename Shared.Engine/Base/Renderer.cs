using OpenTK;
using OpenTK.Graphics.ES30;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Engine.Base
{
    public class Renderer
    {
        // target dimensions of the display
        private Vector2 _v2TargetDimension;
        // Offset for Viewport
        private Vector2 _v2ViewOffset;
        // Help scale up/down according to viewport dimensions
        private Vector2 _v2ScaleDimensions;

        //Instance of Renderer
        private static Renderer _Instance;

        //Singleton of Renderer
        public static Renderer Instance => _Instance ?? (_Instance = new Renderer());

        //Dimensions of Target Display
        public Vector2 TargetDimensions => _v2TargetDimension;

        // Scale of the Dimensions
        public Vector2 ScreenScale { get; private set; }

        //Constuctor
        private Renderer()
        {

        }

        //Create the renderer
        // <params> name=targetDimensions
        internal void Init(Vector2 targetDimensions, Vector2 deviceDimensions, Vector2 viewPortOffeset)
        {
            _v2TargetDimension = targetDimensions;
            _v2ScaleDimensions = deviceDimensions;
            _v2ViewOffset = viewPortOffeset;
            //Determines screen scale needed to change
            ScreenScale = new Vector2(targetDimensions.X / deviceDimensions.X, targetDimensions.Y / deviceDimensions.Y);
        }

        //This will draw all objects of our game
        internal void Draw()
        {
            GL.Viewport((Int32)_v2ViewOffset.X, (Int32)_v2ViewOffset.Y, (Int32)_v2ScaleDimensions.X, (Int32)_v2ScaleDimensions.Y);
            GL.ClearColor(0f, 0.4f, 0f, 0f);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

        }

    }
}
