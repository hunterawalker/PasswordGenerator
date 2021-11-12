using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passwordManagerbeta
{

	public partial class PasswordManager : Form
	{
		int currentPasswordLength = 0;
		Random character = new Random();


		private void passwordGenerator(int passwordLength)
		{
			String allCharacters = "QWERTYTUYIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnmm1234567890!$*";
			String randomPassword = "";
			for(int i=0; i< passwordLength; i++)
			{
				int randomNum = character.Next(0, allCharacters.Length);
				randomPassword += allCharacters[randomNum];
			}
			Password.Text = randomPassword; 
		}


		public PasswordManager()
		{
			InitializeComponent();
			PasswordLength.Minimum = 5;
			PasswordLength.Maximum = 20;
			passwordGenerator(5);
		}


		private void CopyPassword_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(Password.Text);
		}


		private void PasswordLength_Scroll(object sender, EventArgs e)
		{
			PasswordLengthLabel.Text = "Password Length: " + PasswordLength.Value.ToString();
			currentPasswordLength = PasswordLength.Value;
			passwordGenerator(currentPasswordLength);
		}
	}
}
