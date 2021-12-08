using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
	public class FriendRequest
	{
		public User Sender;
		public User Receiver;

		public FriendRequest(User sender, User receiver)
		{
			Sender = sender;
			Receiver = receiver;
		}
	}
}
