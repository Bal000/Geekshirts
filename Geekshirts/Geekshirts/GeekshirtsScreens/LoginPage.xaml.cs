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
	public partial class LoginPage : UserControl
	{
		public LoginPage()
		{
			// Required to initialize variables
			InitializeComponent();
		}

		private void TxtEmailAdress_GotFocus(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			TxtEmailAdress.Text = "";
		}

		private void TxtEmailAdress_LostFocus(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(TxtEmailAdress.Text.Equals(""))
			{
			TxtEmailAdress.Text = "Your Email Adress";
			}
		}

		private void TxtPassword_GotFocus(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			TxtPassword.Text = "";
		}

		private void TxtPassword_LostFocus(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if(TxtPassword.Text.Equals(""))
			{
			TxtPassword.Text = "Your Password";
			}
		}
	}
}