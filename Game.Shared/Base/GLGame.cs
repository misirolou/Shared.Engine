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

        //Initialize and start offset with zero
        protected override Vector2 CalculateExtraOffset(float heightDiffernce)
        {
            return new Vector2(0, 0);
        }
    }
}
