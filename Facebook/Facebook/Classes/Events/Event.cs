using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
	public class Event
	{

		public string Title;
		public string Description;
		public DateTime Date;
		public DateTime TimeLength;
		public string Adress;
		public Photo Image;
		public Category.CategoryValues CategoryType;
		public bool IsPublic;

		public int GoingCount
		{
			get
			{
				int count = 0;
				foreach (Status.StatusValues status in Statuses.Values)
				{
					if (status == Status.StatusValues.Going)
					{
						count++;
					}
				}
				return count;
			}
		}

		public int InterestedCount
		{
			get
			{
				int count = 0;
				foreach (Status.StatusValues status in Statuses.Values)
				{
					if (status == Status.StatusValues.Interested)
					{
						count++;
					}
				}
				return count;
			}
		}

		public Post CreateEventPost(User user, Status.StatusValues status)
		{
			StringBuilder message = new StringBuilder(user.ToString() + " is ");
			string messageStatus = (status == Status.StatusValues.Going) ? "going to" : "interested in";
			message.Append(messageStatus + " this event.");
			Post post = new Post(user, Title, text: message.ToString(), Image, Acces.AccesValues.Friends_Only, Date);
			return post;
		}

		public List<User> JoinedUsers = new List<User>();
		public Dictionary<User, Status.StatusValues> Statuses = new Dictionary<User, Status.StatusValues>();
	}
}
