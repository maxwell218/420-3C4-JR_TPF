using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.Classes.Posts
{
	public class Share
	{
		public User Sharer;
		public User OriginalPoster;
		public Post OriginalPost;

		public Share(User sharer, Post originalPost)
		{
			Sharer = sharer;
			OriginalPost = originalPost;
			OriginalPoster = OriginalPost.Poster;
		}
	}
}
