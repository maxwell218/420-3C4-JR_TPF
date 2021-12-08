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
		private string USER_IMAGE_FOLDER_PATH = "/Assets/Users/";
		private string PREFIX = "pack://application:,,,/Facebook;component";
		public static new App Current { get { return Application.Current as App; } }

		public T GetWindow<T>() { return Windows.OfType<T>().First(); }
		public Dictionary<string, User> Users { get => _users; }
		private Dictionary<string, User> _users = new Dictionary<string, User>();


		public App()
		{
			_users = new Dictionary<string, User>() {
				{ "trichards@hotmail.com", new User() { FirstName = "Tom", LastName = "Richards", Password = "trichards", Email = "trichards@hotmail.com", ProfileImage = new Uri(PREFIX + USER_IMAGE_FOLDER_PATH + "user1.jpg") } },
				{ "ehart@hotmail.com", new User() { FirstName = "Elliot", LastName = "Hart", Password = "ehart", Email = "ehart@hotmail.com", ProfileImage = new Uri(PREFIX + USER_IMAGE_FOLDER_PATH + "user2.jpg") } },
				{ "pburnham@hotmail.com", new User() { FirstName = "Paul", LastName = "Burnham", Password = "pburnham", Email = "pburnham@hotmail.com", ProfileImage = new Uri(PREFIX + USER_IMAGE_FOLDER_PATH + "user3.jpg") } },
				{ "mleblanc@hotmail.com", new User() { FirstName = "Myriam", LastName = "Leblanc", Password = "mleblanc", Email = "mleblanc@hotmail.com", ProfileImage = new Uri(PREFIX + USER_IMAGE_FOLDER_PATH + "user4.jpg") } },
				{ "rchapman@hotmail.com", new User() { FirstName = "Rachel", LastName = "Chapman", Password = "rchapman", Email = "rchapman@hotmail.com", ProfileImage = new Uri(PREFIX + USER_IMAGE_FOLDER_PATH + "user5.jpg") } }
			};
			_users["trichards@hotmail.com"].Friends.Add(_users["ehart@hotmail.com"]);
			_users["trichards@hotmail.com"].Friends.Add(_users["rchapman@hotmail.com"]);
			_users["trichards@hotmail.com"].Friends.Add(_users["mleblanc@hotmail.com"]);

			_users["mleblanc@hotmail.com"].Friends.Add(_users["trichards@hotmail.com"]);
			_users["mleblanc@hotmail.com"].Friends.Add(_users["rchapman@hotmail.com"]);

			_users["ehart@hotmail.com"].Friends.Add(_users["trichards@hotmail.com"]);
			_users["ehart@hotmail.com"].Friends.Add(_users["rchapman@hotmail.com"]);

			_users["rchapman@hotmail.com"].Friends.Add(_users["trichards@hotmail.com"]);
			_users["rchapman@hotmail.com"].Friends.Add(_users["mleblanc@hotmail.com"]);
			_users["rchapman@hotmail.com"].Friends.Add(_users["ehart@hotmail.com"]);
		}
	}
}
