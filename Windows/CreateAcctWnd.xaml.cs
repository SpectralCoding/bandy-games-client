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
using BandyClient.Windows;
using BandyClient.Validation;

namespace BandyClient.Windows {
	/// <summary>
	/// Interaction logic for CreateAcctWnd.xaml
	/// </summary>
	public partial class CreateAcctWnd : Window {

		public CreateAcctWnd() {
			InitializeComponent();
		}

		private void CloseBtn_Click(object sender, RoutedEventArgs e) {
			Close();
		}

		private void UsernameTxt_LostFocus(object sender, RoutedEventArgs e) {
			String ErrorText = RegistrationValidator.ValidateUsername(UsernameTxt.Text);
			if (ErrorText == String.Empty) {
				UsernameValidImg.Style = (Style)FindResource("Img_ShieldCheck_16x16");
				UsernameValidImg.ToolTip = "";
			} else {
				UsernameValidImg.Style = (Style)FindResource("Img_ShieldX_16x16");
				UsernameValidImg.ToolTip = "Errors Found:\n" + ErrorText;
			}
		}

		private void PasswordTxt_LostFocus(object sender, RoutedEventArgs e) {
			String ErrorText = RegistrationValidator.ValidatePassword(PasswordTxt.Password);
			if (ErrorText == String.Empty) {
				PasswordValidImg.Style = (Style)FindResource("Img_ShieldCheck_16x16");
				PasswordValidImg.ToolTip = "";
			} else {
				PasswordValidImg.Style = (Style)FindResource("Img_ShieldX_16x16");
				PasswordValidImg.ToolTip = "Errors Found:\n" + ErrorText;
			}
		}

		private void ConfirmPasswordTxt_LostFocus(object sender, RoutedEventArgs e) {
			if (PasswordTxt.Password == ConfirmPasswordTxt.Password) {
				ConfirmPasswordValidImg.Style = (Style)FindResource("Img_ShieldCheck_16x16");
				ConfirmPasswordValidImg.ToolTip = "";
			} else {
				ConfirmPasswordValidImg.Style = (Style)FindResource("Img_ShieldX_16x16");
				ConfirmPasswordValidImg.ToolTip = "Errors Found:\nPassword and Confirm Password must match.";
			}
		}

		private void EmailTxt_LostFocus(object sender, RoutedEventArgs e) {
			if (RegistrationValidator.IsValidEmail(EmailTxt.Text)) {
				EmailValidImg.Style = (Style)FindResource("Img_ShieldCheck_16x16");
				EmailValidImg.ToolTip = "";
			} else {
				EmailValidImg.Style = (Style)FindResource("Img_ShieldX_16x16");
				EmailValidImg.ToolTip = "Errors Found:\nEmail address is not valid.";
			}
		}

		private void ConfirmEmailTxt_LostFocus(object sender, RoutedEventArgs e) {
			if (EmailTxt.Text == ConfirmEmailTxt.Text) {
				ConfirmEmailValidImg.Style = (Style)FindResource("Img_ShieldCheck_16x16");
				ConfirmEmailValidImg.ToolTip = "";
			} else {
				ConfirmEmailValidImg.Style = (Style)FindResource("Img_ShieldX_16x16");
				ConfirmEmailValidImg.ToolTip = "Errors Found:\nEmail and Confirm Email must match.";
			}
		}

		private void DisplayNameTxt_LostFocus(object sender, RoutedEventArgs e) {
			String ErrorText = RegistrationValidator.ValidateDisplayName(DisplayNameTxt.Text);
			if (ErrorText == String.Empty) {
				DisplayNameValidImg.Style = (Style)FindResource("Img_ShieldCheck_16x16");
				DisplayNameValidImg.ToolTip = "";
			} else {
				DisplayNameValidImg.Style = (Style)FindResource("Img_ShieldX_16x16");
				DisplayNameValidImg.ToolTip = "Errors Found:\n" + ErrorText;
			}
		}

		private void RegisterBtn_Click(object sender, RoutedEventArgs e) {
			if (RegistrationValidator.ValidateUsername(UsernameTxt.Text) != String.Empty) { UsernameTxt_LostFocus(null, null); return; }
			if (RegistrationValidator.ValidatePassword(PasswordTxt.Password) != String.Empty) { PasswordTxt_LostFocus(null, null); return; }
			if (PasswordTxt.Password != ConfirmPasswordTxt.Password) { ConfirmPasswordTxt_LostFocus(null, null); return; }
			if (!RegistrationValidator.IsValidEmail(EmailTxt.Text)) { EmailTxt_LostFocus(null, null); return; }
			if (EmailTxt.Text != ConfirmEmailTxt.Text) { ConfirmEmailTxt_LostFocus(null, null); return; }
			if (RegistrationValidator.ValidateDisplayName(DisplayNameTxt.Text) != String.Empty) { DisplayNameTxt_LostFocus(null, null); return; }
			throw new NotImplementedException();
		}

		private void TermsOfServiceChk_Checked(object sender, RoutedEventArgs e) {
			if (TermsOfServiceChk.IsChecked == true) {
				RegisterBtn.IsEnabled = true;
			} else {
				RegisterBtn.IsEnabled = false;
			}
		}

	}
}
