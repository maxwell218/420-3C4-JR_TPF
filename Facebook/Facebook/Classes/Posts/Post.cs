using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Facebook
{
	public class Post
	{
		private const int POST_ROWS = 7;
		public User Poster;
		public int Score = 0;
		public DateTime? Date;
		public Acces.AccesValues Visibility;
		public string Caption;
		public string Text;
		public List<Media> MediaContent = new List<Media>();
		public List<User> Viewers = new List<User>();

		// Reactions
		public List<User> LikeUsers = new List<User>();
		public List<User> LoveUsers = new List<User>();
		public List<User> SadUsers = new List<User>();
		public List<User> AngryUsers = new List<User>();

		public Post(User user, string caption, string text, Media media, Acces.AccesValues visibility = Acces.AccesValues.Public, DateTime? date = null)
		{
			Poster = user;
			Caption = caption;
			Text = text;
			Visibility = visibility;
			Date = (date == null) ? DateTime.Now : date;
			MediaContent.Add(media);
		}

		public Post(User user, string caption, string text, List<Media> media, Acces.AccesValues visibility = Acces.AccesValues.Public, DateTime? date = null)
		{
			Poster = user;
			Caption = caption;
			Text = text;
			Visibility = visibility;
			Date = (date == null) ? DateTime.Now : date;
			MediaContent = media;
		}

		public ListViewItem CreatePostXAML()
        {
			ListViewItem post = new ListViewItem();

			// Grid that formats all the content of the post
			Grid grid = new Grid();
			grid.ColumnDefinitions.Add(new ColumnDefinition());
			grid.ColumnDefinitions.Add(new ColumnDefinition());
			grid.ColumnDefinitions[0].Width = GridLength.Auto;
			grid.ColumnDefinitions[1].Width = new GridLength(1, GridUnitType.Star);

			for (int i = 0; i < POST_ROWS; i++)
            {
				grid.RowDefinitions.Add(new RowDefinition());
            }

			// User image
			Border border = new Border();
			border.Style = (Style) App.Current.Resources["PostUserImageStyle"];
			ImageBrush userImage = new ImageBrush(new BitmapImage(Poster.ProfileImage));
			border.Background = userImage;

			return post;
        }
	}
}
