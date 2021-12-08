using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Facebook
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private User currentUser;
		public MainWindow(User user)
		{
			InitializeComponent();
			currentUser = user;

			UserNameTextBlock.Text = currentUser.ToString();

			ImageBrush userProfileImage = new ImageBrush(new BitmapImage(user.ProfileImage));
			UserProfileImage.Background = userProfileImage;

			// Initialize friend list if we have friends :(
			if (currentUser.Friends.Count > 0)
			{
				FriendsList.Items.Clear();
				currentUser.Friends.Sort();
				foreach (User friend in currentUser.Friends)
				{
					TextBlock name = new TextBlock();
					name.Text = friend.ToString();

					Border border = new Border();
					ImageBrush image = new ImageBrush(new BitmapImage(friend.ProfileImage));
					border.Background = image;

					WrapPanel wp = new WrapPanel();
					wp.Children.Add(border);
					wp.Children.Add(name);

					ListViewItem li = new ListViewItem();
					li.Content = wp;
					FriendsList.Items.Add(li);
				}
			}

		}
	}
}
