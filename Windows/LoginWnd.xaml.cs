using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BandyClient.Windows {
	/// <summary>
	/// Interaction logic for LoginWnd.xaml
	/// </summary>
	public partial class LoginWnd : Window {
		public LoginWnd() {
			InitializeComponent();
		}

		private void ForgotPasswordLbl_MouseUp(object sender, MouseButtonEventArgs e) {
			throw new NotImplementedException();
		}

		private void CreateAccountLbl_MouseUp(object sender, MouseButtonEventArgs e) {
			CreateAcctWnd CreateAcctWnd = new CreateAcctWnd();
			CreateAcctWnd.Show();
		}

		private void CloseBtn_Click(object sender, RoutedEventArgs e) {
			Close();
		}

		private void LoginCmd_Click(object sender, RoutedEventArgs e) {
			throw new NotImplementedException();
		}

	}
}
