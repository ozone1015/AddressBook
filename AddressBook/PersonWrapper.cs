using System;
using System.Runtime.Serialization;
namespace AddressBook
{
	[Serializable]
	[DataContract (Name="personwrapper")]
	public class PersonWrapper
	{
		[DataMember (Name="person", Order=1)]
		public Person Contact
		{
			get { return this._person; }
			set { this._person = value;}
		}
		private Person _person;
		
		public PersonWrapper (Person person)
		{
			Contact = person;
		}
	}
}

