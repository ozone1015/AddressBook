using System;
using System.Runtime.Serialization;
namespace AddressBook
{
	[Serializable]
	[DataContract (Name="person")]
	public class Person
	{
		[DataMember (Name="name", Order=1)]
		public string Name
		{
			get { return this._name; }
			set { this._name = value; }
		}
		protected string _name;
		
		[DataMember (Name="address", Order=2)]
		public string Address
		{
			get { return this._address; }
			set { this._address = value; }
		}
		protected string _address;
		
		[DataMember (Name="phone", Order=3)]
		public string Phone
		{
			get { return this._phone; }
			set { this._phone = value; }
		}
		protected string _phone;
		
		[DataMember (Name="email", Order=4)]
		public string Email
		{
			get { return this._email; }
			set { this._email = value; }
		}
		protected string _email;
		
		public Person ()
		{
			_name = "None";
			_address = "None";
			_phone = "None";
			_email = "None";
		}
		
		public Person (string name, string address, string phone, string email)
		{
			_name = name;
			_address = address;
			_phone = phone;
			_email = email;
		}
	}
}

