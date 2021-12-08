using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
	public class User : IComparable<User>
	{
		public string FirstName;
		public string LastName;
		public string Password;
		public string Email;

		public Uri ProfileImage = new Uri("pack://application:,,,/Facebook;component/Assets/Users/default.jpg");
		public Uri ProfileBanner;

		public List<User> Friends = new List<User>();

		public override string ToString()
		{
			return FirstName + " " + LastName;
		}

		public int CompareTo(User anotherUser)
		{
			int result = this.FirstName.CompareTo(anotherUser.FirstName);

			return (result != 0) ? result : this.LastName.CompareTo(anotherUser.LastName);
		}
	}
}
