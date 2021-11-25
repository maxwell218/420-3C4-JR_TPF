using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.Classes
{
	class User
	{
		private string _firstName;
		private string _lastName;
		private string _password;
		private string _email;

		private Uri _profileImage;
		private Uri _profileBanner;

		private List<User> _addedFriends = new List<User>();
	}
}
