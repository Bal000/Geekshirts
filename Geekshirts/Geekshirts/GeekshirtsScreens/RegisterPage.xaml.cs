using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace GeekshirtsScreens
{
	public partial class RegisterPage : UserControl
	{
		public RegisterPage()
		{
			// Required to initialize variables
			InitializeComponent();
		}

		private void TxtFirstName_GotFocus(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			TxtFirstName.Text = "";
		}

		private void TxtFirstName_LostFocus(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(TxtFirstName.Text.Equals(""))
			{
			TxtFirstName.Text = "Firstname";
			}
		}

		private void TxtLastName_GotFocus(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			TxtLastName.Text = "";
		}

		private void TxtLastName_LostFocus(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(TxtLastName.Text.Equals(""))
			{
			TxtLastName.Text = "Lastname";
			}
		}

		private void TxtAdress_GotFocus(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			TxtAdress.Text = "";
		}

		private void TxtAdress_LostFocus(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(TxtAdress.Text.Equals(""))
			{
			TxtAdress.Text = "Adress";
			}
		}

		private void TxtTelephone_GotFocus(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			TxtTelephone.Text = "";
		}

		private void TxtTelephone_LostFocus(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(TxtTelephone.Text.Equals(""))
			{
			TxtTelephone.Text = "Telephone";
			}
		}

		private void TxtEmail_GotFocus(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			TxtEmail.Text = "";
		}

		private void TxtEmail_LostFocus(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(TxtEmail.Text.Equals(""))
			{
			TxtEmail.Text = "Email";
			}
		}

		private void TxtPassword1_GotFocus(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			TxtPassword1.Text = "";
		}

		private void TxtPassword1_LostFocus(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(TxtPassword1.Text.Equals(""))
			{
			TxtPassword1.Text = "Password";
			}
		}

		private void TxtPassword2_GotFocus(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			TxtPassword2.Text = "";
		}

		private void TxtPassword2_LostFocus(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(TxtPassword2.Text.Equals(""))
			{
			TxtPassword2.Text = "Retype Password";
			}
		}
	}
}