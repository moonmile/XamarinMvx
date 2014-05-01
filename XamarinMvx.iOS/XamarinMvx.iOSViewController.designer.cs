// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace XamarinMvx.iOS
{
	[Register ("XamarinMvx_iOSViewController")]
	partial class XamarinMvx_iOSViewController
	{
		[Outlet]
		MonoTouch.UIKit.UITextField editX { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField editY { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel textAns { get; set; }

		[Action ("clickCalc:")]
		partial void clickCalc (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (editX != null) {
				editX.Dispose ();
				editX = null;
			}

			if (editY != null) {
				editY.Dispose ();
				editY = null;
			}

			if (textAns != null) {
				textAns.Dispose ();
				textAns = null;
			}
		}
	}
}
