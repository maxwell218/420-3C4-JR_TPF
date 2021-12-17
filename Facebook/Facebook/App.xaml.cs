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
		private string POST_IMAGE_FOLDER_PATH = "/Assets/Posts/";
		public string PREFIX = "pack://application:,,,/Facebook;component";
		public static new App Current { get { return Application.Current as App; } }

		public T GetWindow<T>() { return Windows.OfType<T>().First(); }
		public Dictionary<string, User> Users { get => _users; }
		private Dictionary<string, User> _users = new Dictionary<string, User>();

		public List<Post> Posts { get => _posts; }
		private List<Post> _posts = new List<Post>();

		public App()
		{
			// User Data
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

			// Post Data
			_posts = new List<Post>()
			{
				new Post() {
					Poster = _users["trichards@hotmail.com"],
					Caption = "Nice snack with a book",
					Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras id consectetur quam. Nam rutrum non dui et feugiat. Morbi a mattis leo. Phasellus efficitur nulla dignissim ipsum commodo, in maximus leo dignissim. Donec venenatis posuere justo quis pulvinar. Etiam eu neque nibh. Vivamus egestas sollicitudin dictum. Nunc tempus orci vel enim facilisis, sit amet rhoncus mi bibendum. Donec vel venenatis orci. Fusce ultricies libero id nulla dignissim, non molestie nunc placerat. Vestibulum hendrerit mi aliquet ante feugiat, a semper augue volutpat. Aenean leo est, sagittis non enim quis, aliquam vestibulum odio. Sed et suscipit orci.",
					MediaContent = new List<Photo> { new Photo() { Image = new Uri(PREFIX + POST_IMAGE_FOLDER_PATH + "post1.jpg") } },
					Date = new DateTime(2021, 11, 20, 7, 0, 0),
					Visibility = Acces.AccesValues.Public
				},
				new Post() {
					Poster = _users["ehart@hotmail.com"],
					Caption = "Relaxing night at the beach",
					Text = "Aenean vehicula ligula id nisl dapibus auctor. Aliquam ornare, libero eu pulvinar aliquam, sem lorem fermentum nisl, sed convallis lacus sem ut nulla. Suspendisse potenti. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer at rutrum dui. Ut at dolor leo. Maecenas id fringilla diam. Curabitur aliquet efficitur diam sed iaculis. Sed vulputate faucibus facilisis. Quisque tincidunt libero sit amet est dignissim, vitae egestas dui rutrum. Etiam non nisi quis elit consequat pretium non quis ante. Phasellus nec leo est. Vestibulum porttitor ac mauris sit amet tincidunt.",
					MediaContent = new List<Photo> { new Photo() { Image = new Uri(PREFIX + POST_IMAGE_FOLDER_PATH + "post2.jpg") } },
					Date = new DateTime(2021, 11, 21, 10, 30, 0),
					Visibility = Acces.AccesValues.Public,
					LikeUsers = new List<User> { _users["trichards@hotmail.com"] }
				},
				new Post() {
					Poster = _users["rchapman@hotmail.com"],
					Caption = "Trekking in the woods",
					Text = "Fusce tincidunt lorem mauris, id cursus nunc bibendum quis. Etiam sed malesuada arcu, ut tempus ligula. Ut quis erat non augue molestie scelerisque vel eu lectus. Sed et sapien blandit, iaculis tortor id, cursus nisl. Quisque facilisis congue iaculis. Ut bibendum, orci in posuere efficitur, augue diam posuere massa, quis ultrices augue nibh non est. Donec orci est, egestas a eros non, rutrum luctus neque. Nulla finibus erat in dictum laoreet. Nulla nec enim vitae nisl pulvinar maximus.",
					MediaContent = new List<Photo> { new Photo() { Image = new Uri(PREFIX + POST_IMAGE_FOLDER_PATH + "post3.jpg") } },
					Date = new DateTime(2021, 11, 22, 16, 30, 0),
					Visibility = Acces.AccesValues.Public,
					LoveUsers = new List<User> { _users["trichards@hotmail.com"] }
				},
				new Post() {
					Poster = _users["mleblanc@hotmail.com"],
					Caption = "King of the world!",
					Text = "Phasellus viverra sed ante et egestas. Ut rhoncus ac enim id iaculis. Pellentesque elementum elit orci, nec molestie tellus ornare et. Nam pulvinar laoreet lobortis. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Integer gravida odio id tortor posuere laoreet. Cras mattis tortor vitae orci semper porttitor. Proin luctus purus ut quam rhoncus volutpat. Proin ac suscipit velit. Cras quis erat varius, lacinia ligula ac, tristique dui.",
					MediaContent = new List<Photo> { new Photo() { Image = new Uri(PREFIX + POST_IMAGE_FOLDER_PATH + "post4.jpg") } },
					Date = new DateTime(2021, 11, 23, 21, 0, 0),
					Visibility = Acces.AccesValues.Public,
					SadUsers = new List<User> { _users["trichards@hotmail.com"] },
					AngryUsers = new List<User> { _users["ehart@hotmail.com"] }
				},
				new Post() {
					Poster = _users["pburnham@hotmail.com"],
					Caption = "After work",
					Text = "Nulla tincidunt eros eros, eget pulvinar massa suscipit eu. In eu leo enim. Aliquam sed feugiat magna. Nunc aliquet mauris dapibus, eleifend sapien quis, lobortis lectus. In hac habitasse platea dictumst. Mauris nec fermentum mauris. Maecenas eleifend tincidunt tortor ut mattis. Nulla feugiat sollicitudin quam in sagittis. Quisque in nisi eu purus fringilla pretium sit amet eget turpis. Vivamus sagittis elit non erat pulvinar tristique. Vivamus hendrerit porta purus id convallis. Praesent efficitur lectus lacus, eu pulvinar velit scelerisque sit amet. Duis vestibulum mattis leo, non viverra arcu mollis ac. Morbi a auctor quam.",
					MediaContent = new List<Photo> { new Photo() { Image = new Uri(PREFIX + POST_IMAGE_FOLDER_PATH + "post5.jpg") } },
					Date = new DateTime(2021, 11, 25, 12, 0, 0),
					Visibility = Acces.AccesValues.Friends_Only,
					LoveUsers = new List<User> { _users["ehart@hotmail.com"] }
				}
			};
		}
	}
}
