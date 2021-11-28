using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Facebook
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		public static new App Current { get { return Application.Current as App; } }

		public T GetWindow<T>() { return Windows.OfType<T>().First(); }

		public Dictionary<string, User> Users { get => _users; }
		private Dictionary<string, User> _users = new Dictionary<string, User>()
		{
			{ "pberube@hotmail.com", new User() { FirstName = "Paul", LastName = "Berube", Password = "pberube", Email = "pberube@hotmail.com" } }
		};

	}
}
