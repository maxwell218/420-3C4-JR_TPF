using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
	public class Video : Media
	{
		public Uri Playback;
		public List<User> Tags = new List<User>();
	}
}
