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

        //Instance of Renderer
        private static Renderer _Instance;

        //Singleton of Renderer
        public static Renderer Instance => _Instance ?? (_Instance = new Renderer());

        //Dimensions of Target Display
        public Vector2 TargetDimensions => _v2TargetDimension;

        //Constuctor
        private Renderer()
        {

        }

        //Create the renderer
        // <params> name=targetDimensions
        internal void Init(Vector2 targetDimensions)
        {
            _v2TargetDimension = targetDimensions;
        }

        //This will draw all objects of our game
        internal void Draw()
        {
            GL.ClearColor(0f, 0.4f, 0f, 0f);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
        }

    }
}
