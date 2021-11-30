using System;
using System.Collections.Generic;
using System.ComponentModel;
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
	public partial class CreateUserWindow : Window
	{
		const int NAME_CHARS_MIN = 3;
		const int NAME_CHARS_MAX = 16;
		public CreateUserWindow()
		{
			InitializeComponent();
			FirstNameTextBox.MaxLength = NAME_CHARS_MAX;
			LastNameTextBox.MaxLength = NAME_CHARS_MAX;
		}

		private void CreateUserButtonClick(object sender, RoutedEventArgs e)
		{
			bool isValidUserForm = true;
			bool isUniqueEmail = true;
			string firstName = FirstNameTextBox.Text.Trim();
			string lastName = LastNameTextBox.Text.Trim();
			string email = EmailTextBox.Text.Trim();
			string password = PasswordBox.Password.Trim();

			// Check if both names have enough chars
			if (firstName.Length < NAME_CHARS_MIN || lastName.Length < NAME_CHARS_MIN)
			{
				isValidUserForm = false;
				bool firstNameIsWrong = (firstName.Length < NAME_CHARS_MIN) ? true : false;
				string labelName = (firstNameIsWrong) ? "prénom" : "nom";
				MessageBox.Show("Votre " + labelName + " est trop court, il doit y avoir au moins " + NAME_CHARS_MIN + " caractères.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
				bool temp = (firstNameIsWrong) ? FirstNameTextBox.Focus() : LastNameTextBox.Focus();
			}
			// Check for valid email
			else if (!IsValidEmail(email))
			{
				isValidUserForm = false;
				MessageBox.Show("L'adresse courriel fournie n'est pas valide.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
				EmailTextBox.Focus();
			}
			// Check if email is unique
			else if (IsValidEmail(email))
			{
				foreach (User user in App.Current.Users.Values)
				{
					if (email == user.Email)
					{
						isUniqueEmail = false;
						break;
					}
				}

				if (!isUniqueEmail)
				{
					isValidUserForm = false;
					MessageBox.Show("L'adresse courriel fournie est déjà utilisée sous un autre compte utilisateur.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
					EmailTextBox.Focus();
				}
			}
			// Check if password has enough chars
			if (password.Length == 0 && isValidUserForm)
			{
				MessageBox.Show("Veuillez taper votre mot de passe.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
				PasswordBox.Focus();
			}

			if (isValidUserForm)
			{
				App.Current.Users.Add(email, new User() { FirstName = firstName, LastName = lastName, Password = password, Email = email });
				MessageBox.Show("Inscription completée - l'utilisateur \"" + firstName + " " + lastName + "\" a été créé avec succès.", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
				this.Close();
			}

		}

		protected override void OnClosing(CancelEventArgs e)
		{
			LoginWindow lw = new LoginWindow();
			lw.Show();
		}

		// Source : https://stackoverflow.com/questions/1365407/c-sharp-code-to-validate-email-address
		private bool IsValidEmail(string email)
		{
			if (email.EndsWith("."))
			{
				return false;
			}
			try
			{
				var addr = new System.Net.Mail.MailAddress(email);
				return addr.Address == email;
			}
			catch
			{
				return false;
			}
		}
	}
}
