using System;
namespace AddressBook
{
	public class Contact
	{
		public string Name
		{
			get { return this._name; }
			set { this._name = value; }
		}
		protected string _name;
		
		public string Address
		{
			get { return this._address; }
			set { this._address = value; }
		}
		protected string _address;
		
		public string Phone
		{
			get { return this._phone; }
			set { this._phone = value; }
		}
		protected string _phone;
		
		public string Email
		{
			get { return this._email; }
			set { this._email = value; }
		}
		protected string _email;
		
		public Contact ()
		{
			_name = "None";
			_address = "None";
			_phone = "None";
			_email = "None";
		}
		
		public Contact (string name, string address, string phone, string email)
		{
			_name = name;
			_address = address;
			_phone = phone;
			_email = email;
		}
	}
}

