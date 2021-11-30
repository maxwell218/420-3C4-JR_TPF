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
	/// Interaction logic for LoginWindow.xaml
	/// </summary>
	public partial class LoginWindow : Window
	{
		public LoginWindow()
		{
			InitializeComponent();
		}

		private void LoginButtonClick(object sender, RoutedEventArgs e)
		{
			bool isValidLogin = false;
			string email = EmailTextBox.Text.Trim();
			string password = PasswordBox.Password;

			// Check if fields are empty
			if (email.Length == 0 || password.Length == 0)
			{
				bool EmailIsEmpty = (email.Length == 0) ? true : false;
				string labelName = (EmailIsEmpty) ? "adresse courriel" : "mot de passe";
				MessageBox.Show("Veuillez fournir votre " + labelName + ".", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
				bool temp = (EmailIsEmpty) ? EmailTextBox.Focus() : PasswordBox.Focus();
				return;
			}

			// Check if email exists
			foreach (User user in App.Current.Users.Values)
			{
				if (email == user.Email)
				{
					// Check if passwords don't match
					if (password != user.Password)
					{
						MessageBox.Show("Le mot de passe est erroné.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
						PasswordBox.Focus();
						return;
					}
					else
					{
						isValidLogin = true;
					}
				}
			}

			if (isValidLogin)
			{
				// Todo - MainWindow implementation
			}
			// Email doesn't exist users list
			else
			{
				MessageBox.Show("L'adresse courriel fournie n'est pas associée à un compte existant.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
				EmailTextBox.Focus();
			}
		}

		private void CreateUserButtonClick(object sender, RoutedEventArgs e)
		{
			CreateUserWindow cw = new CreateUserWindow();
			cw.Show();
			this.Close();
		}
	}
}
