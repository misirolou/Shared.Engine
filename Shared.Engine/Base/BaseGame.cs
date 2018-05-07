using OpenTK;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Engine.Base
{
    public abstract class BaseGame
    {
        // Target solution for the game
        public abstract Vector2 _IntialResoltion { get;  }
        // target the solution for the game
        protected BaseGame()
        {

        }

        // Initializes the game
        public virtual void Init(Vector2 displayDimensions)
        {
            //Helps to figure the right height of view
            Single newHeight = ((_IntialResoltion.X / displayDimensions.X) * displayDimensions.Y);
            Vector2 resolution = new Vector2(_IntialResoltion.X, newHeight);
            Renderer.Instance.Init(resolution, displayDimensions, CalculateExtraOffset(newHeight - _IntialResoltion.Y));
        }

        // Helps to Calculate offset based on height diffence
        protected abstract Vector2 CalculateExtraOffset(Single heightDiffernce);

        // Draws our objects // this is internal to this class only in case there are issues Drawing objects
        internal void Draw()
        {
            Renderer.Instance.Draw();
        }

    }
}
