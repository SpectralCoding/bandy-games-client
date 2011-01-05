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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BandyClient {
	/// <summary>
	/// Interaction logic for LoginWindow.xaml
	/// </summary>
	public partial class LoginWindow : Window {
		public LoginWindow() {
			InitializeComponent();
			// Allow dragging anywhere on the window.
			//MouseLeftButtonDown += delegate { DragMove(); };
		}

		private void ForgotPasswordLbl_MouseUp(object sender, MouseButtonEventArgs e) {
			throw new NotImplementedException();
		}

		private void CreateAccountLbl_MouseUp(object sender, MouseButtonEventArgs e) {
			throw new NotImplementedException();
		}

		private void CloseBtn_Click(object sender, RoutedEventArgs e) {
			Close();
		}

		private void LoginCmd_Click(object sender, RoutedEventArgs e) {
			throw new NotImplementedException();
		}
	}
}
