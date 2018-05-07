using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using Shared.Engine.Base;
using UIKit;

namespace Engine.iOS
{
    public partial class GLViewController : UIViewController
    {
        // <summary> Instance of game
        protected readonly BaseGame _GameInstance;

        public GLViewController(BaseGame gameInstance) : base()
        {
            _GameInstance = gameInstance;
        }

        // <summary> Load & Creates our view and sets the game insance
        public override void LoadView()
        {
            View = new GameView(UIScreen.MainScreen.Bounds);
            ((GameView)View).SetGameInstance(_GameInstance);
        }

        // <summary> called when the view is loaded
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            ((GameView)View).Run(60f);
        }
    }
}