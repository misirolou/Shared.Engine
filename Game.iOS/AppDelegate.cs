using Engine.iOS;
using Game.Shared.Base;
using Foundation;
using UIKit;
using Shared.Engine.Base;

namespace Game.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : BaseAppDelegate
    {
        private BaseGame _GameInstance;

        public override BaseGame GameInstance => _GameInstance ?? (_GameInstance = new GLGame());
    }
}


