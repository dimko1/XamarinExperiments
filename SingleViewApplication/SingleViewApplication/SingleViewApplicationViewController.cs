using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace SingleViewApplication
{
	public partial class SingleViewApplicationViewController : UIViewController
	{
		private int clickCounter = 1;

		public SingleViewApplicationViewController () : base ("SingleViewApplicationViewController", null)
		{
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			/*this.btnTestClick.TouchUpInside += (object sender, EventArgs e) => {
				this.clickCounter++;
				this.lblTestLabel.Text = string.Format("Button clicked {0} times!", clickCounter.ToString()); 


			};*/
			
			// Perform any additional setup after loading the view, typically from a nib.
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}

		partial void testButtonClicked (NSObject sender)
		{
			clickCounter++;
			this.lblTestLabel.Text = string.Format("Button clicked {0} times!", this.clickCounter);
		}
	}
}

