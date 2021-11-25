using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.Classes
{
	class FriendRequest
	{
		private User _sender;
		private User _receiver;

		public FriendRequest(User sender, User receiver)
		{
			_sender = sender;
			_receiver = receiver;
		}
	}
}
