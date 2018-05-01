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
        public virtual void Init()
        {
            Renderer.Instance.Init(_IntialResoltion);
        }

        // Draws our objects // this is internal to this class only in case there are issues Drawing objects
        internal void Draw()
        {
            Renderer.Instance.Draw();
        }

    }
}
