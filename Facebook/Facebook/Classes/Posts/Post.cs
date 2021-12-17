using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
		public DateTime Date;
		public Acces.AccesValues Visibility;
		public string Caption;
		public string Text;
		public List<Photo> MediaContent = new List<Photo>();

		// Post visibility
		public List<User> Viewers = new List<User>();
		public List<User> FriendsExcept = new List<User>();
		public List<User> SpecificFriends = new List<User>();

		// Reactions
		public List<User> LikeUsers = new List<User>();
		public List<User> LoveUsers = new List<User>();
		public List<User> SadUsers = new List<User>();
		public List<User> AngryUsers = new List<User>();

		public string TimeSpan
		{
			get
			{
				DateTime zeroTime = new DateTime(1, 1, 1);
				DateTime curdate = DateTime.Now.ToLocalTime();

				TimeSpan span = curdate - Date;

				// because we start at year 1 for the Gregorian 
				// calendar, we must subtract a year here.

				int years = (zeroTime + span).Year - 1;
				int months = (zeroTime + span).Month - 1;
				int days = (zeroTime + span).Day;

				StringBuilder timeSpan = new StringBuilder();

				if (years > 0)
				{
					timeSpan.Append(years + "y ");
				}

				if (months > 0)
				{
					timeSpan.Append(months + "m ");
				}

				if (days > 0)
				{
					timeSpan.Append(days + "d");
				}

				return timeSpan.ToString().Trim();
			}
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
			ImageBrush userImage = new ImageBrush(new BitmapImage(Poster.ProfileImage));
			border.Background = userImage;

			// TextBlocks
			TextBlock username = new TextBlock();
			username.Text = Poster.ToString();
			username.Name = "Username";

			TextBlock timeSpan = new TextBlock();
			timeSpan.Text = TimeSpan;
			timeSpan.Name = "TimeSpan";

			TextBlock title = new TextBlock();
			title.Text = Caption;
			title.Name = "Caption";

			TextBlock date = new TextBlock();
			date.Text = Date.ToString("MMMM dd, yyyy \\a\\t H:mm");
			date.Name = "Date";

			TextBlock text = new TextBlock();
			text.Text = Text;
			text.Name = "Text";

			// Reactions
			WrapPanel wrapPanel = CreateReactionsXAML();

			// Image
			Image image = new Image();
			image.Source = new BitmapImage(MediaContent[0].Image);

			// Add all to grid
			grid.Children.Add(border);
			grid.Children.Add(username);
			grid.Children.Add(timeSpan);
			grid.Children.Add(image);
			grid.Children.Add(title);
			grid.Children.Add(date);
			grid.Children.Add(text);
			grid.Children.Add(wrapPanel);

			post.Content = grid;

			return post;
		}

		public WrapPanel CreateReactionsXAML()
		{
			WrapPanel wrapPanel = new WrapPanel();

			for (int i = 0; i < 4; i++)
			{
				ToggleButton reactionButton = new ToggleButton();
				WrapPanel buttonWrapPanel = new WrapPanel();

				Image image = new Image();

				TextBlock count = new TextBlock();
				count.Text = "0";

				switch (i)
				{
					case 0:
						image.Source = new BitmapImage(new Uri(App.Current.PREFIX + "/Assets/Icons/like.png"));
						reactionButton.Name = "LikeButton";
						break;
					case 1:
						image.Source = new BitmapImage(new Uri(App.Current.PREFIX + "/Assets/Icons/love.png"));
						reactionButton.Name = "LoveButton";
						break;
					case 2:
						image.Source = new BitmapImage(new Uri(App.Current.PREFIX + "/Assets/Icons/sad.png"));
						reactionButton.Name = "SadButton";
						break;
					case 3:
						image.Source = new BitmapImage(new Uri(App.Current.PREFIX + "/Assets/Icons/angry.png"));
						reactionButton.Name = "AngryButton";
						break;
				}
				buttonWrapPanel.Children.Add(image);
				buttonWrapPanel.Children.Add(count);
				reactionButton.Content = buttonWrapPanel;
				wrapPanel.Children.Add(reactionButton);
			}

			return wrapPanel;
		}
	}
}
