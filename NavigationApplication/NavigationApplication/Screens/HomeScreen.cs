
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace NavigationApplication
{
	public partial class HomeScreen : UIViewController
	{

		private HelloWorldScreen _helloWorldScreen;
		private HelloUniverseScreen _helloUniverseScreen;


		public HomeScreen () : base ("HomeScreen", null)
		{
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}


		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
			this.NavigationController.SetNavigationBarHidden (true, animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			this.NavigationController.SetNavigationBarHidden (false, animated);
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			configureHandlers ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		private void configureHandlers()
		{
			//adding handlers of the clicks 
			this.btnHelloWorld.TouchUpInside += (object sender, EventArgs e) => 
			{
				if (this._helloWorldScreen == null)
				{
					this._helloWorldScreen = new HelloWorldScreen();
				}
				
				this.NavigationController.PushViewController(this._helloWorldScreen, true);
			};
			
			this.btnHelloUniverse.TouchUpInside += (object sender, EventArgs e) => 
			{
				if (this._helloUniverseScreen == null)
				{
					this._helloUniverseScreen = new HelloUniverseScreen();
				}
				
				this.NavigationController.PushViewController(this._helloUniverseScreen, true);
			};
			
		}
	}
}

