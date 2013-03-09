// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace SingleViewApplication
{
	[Register ("SingleViewApplicationViewController")]
	partial class SingleViewApplicationViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnTestClick { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblTestLabel { get; set; }

		[Action ("testButtonClicked:")]
		partial void testButtonClicked (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (btnTestClick != null) {
				btnTestClick.Dispose ();
				btnTestClick = null;
			}

			if (lblTestLabel != null) {
				lblTestLabel.Dispose ();
				lblTestLabel = null;
			}
		}
	}
}
