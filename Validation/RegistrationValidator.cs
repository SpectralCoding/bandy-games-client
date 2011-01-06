using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BandyLib;
using System.Text.RegularExpressions;

namespace BandyClient.Validation {
	static class RegistrationValidator {

		/// <summary>
		/// Verifys that Username contains only letters and numbers and is 5-20 characters long.
		/// </summary>
		/// <param name="Username">Username to validate</param>
		/// <returns>String containing error text (if any)</returns>
		public static String ValidateUsername(String Username) {
			String ReturnStr = String.Empty;
			if (!Functions.IsAlphaNumeric(Username)) {
				ReturnStr += "Usernames may only contain letters and numbers.\n";
			}
			if ((Username.Length < 5) || (Username.Length > 20)) {
				ReturnStr += "Usernames must be 5-20 characters long.\n";
			}
			return ReturnStr.TrimEnd("\n".ToCharArray());
		}

		/// <summary>
		/// Verifies that a password contains atleast one number, one letters, is 8-30 characters long, contains no spaces or characters that cannot be typed on a normal keyboard.
		/// </summary>
		/// <param name="Password">Password to validate</param>
		/// <returns>String containing error text (if any)</returns>
		public static String ValidatePassword(String Password) {
			String ReturnStr = String.Empty;
			if (Functions.HasNonKeyboardCharacters(Password)) {
				ReturnStr += "Passwords may only contain characters available on a US Keyboard.\n";
			}
			if (Password.Contains(' ')) {
				ReturnStr += "Passwords may not contain spaces.\n";
			}
			if ((Password.Length < 8) || (Password.Length > 30)) {
				ReturnStr += "Passwords must be 8-30 characters long.\n";
			}
			if (!Functions.ContainsAlpha(Password)) {
				ReturnStr += "Passwords must contain a minimum of one letter.\n";
			}
			if (!Functions.ContainsNumeric(Password)) {
				ReturnStr += "Passwords must contain a minimum of one number.\n";
			}
			return ReturnStr.TrimEnd("\n".ToCharArray());
		}

		/// <summary>
		/// Determines if a string is a properly formatted email address.
		/// </summary>
		/// <param name="Email">Email to validate</param>
		/// <returns>True if valid</returns>
		public static Boolean IsValidEmail(String Email) {
			return (new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")).IsMatch(Email);
		}

		/// <summary>
		/// Determines if a display name contains only characters available on a US keyboard, is 5-30 characters long, and contains atleast one letter.
		/// </summary>
		/// <param name="DisplayName">Display Name to validate</param>
		/// <returns>String containing error text (if any)</returns>
		public static String ValidateDisplayName(String DisplayName) {
			String ReturnStr = String.Empty;
			if (Functions.HasNonKeyboardCharacters(DisplayName)) {
				ReturnStr += "Display Names may only contain characters available on a US Keyboard.\n";
			}
			if ((DisplayName.Length < 5) || (DisplayName.Length > 30)) {
				ReturnStr += "Display Names must be 5-30 characters long.\n";
			}
			if (!Functions.ContainsAlpha(DisplayName)) {
				ReturnStr += "Display Names must contain a minimum of one letter.\n";
			}
			return ReturnStr.TrimEnd("\n".ToCharArray());
		}

	}
}
