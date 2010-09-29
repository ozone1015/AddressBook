
using System;
using System.Collections.Generic;
using System.IO;
using System.Json;
using System.Linq;
using System.Runtime.Serialization.Json;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Text;

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
		
		public Person Contact
		{
			get { return this._person; }
			set 
			{ 
				this._person = value; 
				name.Text = _person.Name;
				address.Text = _person.Address;
				phone.Text = _person.Phone;
				email.Text = _person.Email;
			}
		}
		protected Person _person;

		void Initialize ()
		{
		}
		
		#endregion
	}
}

