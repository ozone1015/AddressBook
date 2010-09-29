using System;

using MonoTouch.UIKit;

namespace AddressBook
{
	public class NavItem
	{
		public ContactView ViewController
		{
			get { return this._viewController; }
			set { this._viewController = value; }
		}
		protected ContactView _viewController;
		
		/// <summary>
		/// The Type of the UIViewController. Set this to the type and leave the Controller
		/// property empty to lazy-instantiate the ViewController when the nav item is 
		/// clicked.
		/// </summary>
		public Type ControllerType
		{
			get { return this._controllerType; }
			set { this._controllerType = value; }
		}
		protected Type _controllerType;

		/// <summary>
		/// a list of the constructor args (if neccesary) for the controller. use this in
		/// conjunction with ControllerType if lazy-creating controllers.
		/// </summary>
		public object[] ControllerConstructorArgs
		{
			get { return this._controllerConstructorArgs; }
			set
			{
				this._controllerConstructorArgs = value;
				this._controllerConstructorTypes = new Type[this._controllerConstructorArgs.Length];

				for (int i = 0; i < this._controllerConstructorArgs.Length; i++)
				{
					this._controllerConstructorTypes[i] = this._controllerConstructorArgs[i].GetType ();
				}
			}
		}

		protected object[] _controllerConstructorArgs = new object[] {
		};

		/// <summary>
		/// The types of constructor args.
		/// </summary>
		public Type[] ControllerConstructorTypes
		{
			get { return this._controllerConstructorTypes; }
		}
		protected Type[] _controllerConstructorTypes = Type.EmptyTypes;
	
		public Person Person
		{
			get { return this._person; }
			set { this._person = value; }
		}
		protected Person _person;

		public NavItem ()
		{
		}

		public NavItem (Person person) : this()
		{
			_person= person;
		}

		public NavItem (Person person, ContactView viewController) : this(person)		
		{
			_person = person;	
			_viewController = viewController;
		}		

		public NavItem (Person person, Type controllerType) : this(person)
		{
			this._controllerType = controllerType;
		}

		public NavItem (Person person, Type controllerType, object[] controllerConstructorArgs) : this(person, controllerType)
		{
			this.ControllerConstructorArgs = controllerConstructorArgs;
		}
	}
}