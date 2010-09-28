
using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace AddressBook
{
	public partial class ContactView : UIViewController
	{
		#region Constructors

		// The IntPtr and initWithCoder constructors are required for items that need 
		// to be able to be created from a xib rather than from managed code

		public ContactView (IntPtr handle) : base(handle)
		{
			Initialize ();
		}

		[Export("initWithCoder:")]
		public ContactView (NSCoder coder) : base(coder)
		{
			Initialize ();
		}

		public ContactView () : base("ContactView", null)
		{
			Initialize ();
		}

		void Initialize ()
		{
		}
		
		#endregion
	}
}

