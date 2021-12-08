using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.Classes.Posts
{
	public class Comment
	{
		public User Writer;
		public bool IsFirstLevel;
		public string Text;
		public Uri Image;
		public Uri Sticker;
		public int LikeCount = 0;
		public int LoveCount = 0;
		public int SadCount = 0;
		public int AngryCount = 0;

		public Comment(User writer, bool isFirstLevel, string text, Uri Image = null)
		{
			Writer = writer;
			IsFirstLevel = isFirstLevel;
			Text = text;
		}

		public Comment(User writer, bool isFirstLevel, Uri sticker)
		{
			Writer = writer;
			IsFirstLevel = isFirstLevel;
			Sticker = sticker;
		}
	}
}
