using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
	public class Post
	{
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
	}
}
