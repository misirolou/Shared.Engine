using OpenTK;
using Shared.Engine.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Shared.Base
{
    public class GLGame : BaseGame
    {
        public override Vector2 _IntialResoltion => new Vector2(1920, 1080);

        //cosntructor
        public GLGame()
        {

        }
    }
}
