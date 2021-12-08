using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
	public class Group
	{
		public List<User> Admins;
		public List<User> Users;
		public string Name;
		public string Description;
		public Uri Image;

		public Group(User user, string name, string description)
		{
			Admins.Add(user);
			Users.Add(user);
			Name = name;
			Description = description;
		}
	}
}
