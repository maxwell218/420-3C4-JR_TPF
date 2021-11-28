using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
	public class User
	{
		public string FirstName;
		public string LastName;
		public string Password;
		public string Email;

		public Uri ProfileImage;
		public Uri ProfileBanner;

		public List<User> Friends = new List<User>();
	}
}
