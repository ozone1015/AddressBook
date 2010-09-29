using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;
namespace AddressBook
{
	public class PersonRepository
	{
		private readonly static string AddressBookUrl = "http://paddressbook.heroku.com/people.json";
		
		private static PersonRepository _instance;
		public static PersonRepository Instance
		{
			get
			{
				if(_instance == null)
					_instance = new PersonRepository();
				
				return _instance;
			}
		}
		
		// Singleton
		private PersonRepository ()
		{
			
		}
		
		public List<Person> LoadPersonListTest()
		{
			Person contact1 = new Person("Chase McCarthy", "843 Main St.", "(318)748-7832", "chase@chase.com");
			Person contact2 = new Person("Micah Woods", "843 Main St.", "(318)748-7832", "chase@chase.com");                               
			List<Person> persons = new List<Person>();
			persons.Add(contact1);
			persons.Add(contact2);
			return persons;
		}
		
		public List<Person> LoadPersonList()
		{
			HttpWebRequest webRequest = GetWebRequest(AddressBookUrl);
			HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
			DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(PersonWrapper[]));
			PersonWrapper[] personsWrapped =  (PersonWrapper[])ser.ReadObject(response.GetResponseStream());
			                              
			List<Person> persons = new List<Person>();
			
			for(int i = 0; i < personsWrapped.Length; i++)
			{
				persons.Add(personsWrapped[i].Contact);
			}
			return persons;
		}
		
		private static HttpWebRequest GetWebRequest(string url)
		{
			Uri serviceUri = new Uri(url, UriKind.Absolute);
			return (HttpWebRequest)System.Net.WebRequest.Create(serviceUri);
		}
	}
}

