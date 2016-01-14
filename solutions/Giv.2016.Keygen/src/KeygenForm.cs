using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Giv.Keygen
{
	public partial class KeygenForm : Form
	{
		public KeygenForm()
		{
			InitializeComponent();
		}

		private void KeygenButton_Click(object sender, EventArgs e)
		{
			String text = string.Empty;
			int num = this.NameTextBox.Text.Length - 1;
			for (Int32 i = 0; i <= num; i++)
			{
				text += (Strings.Asc(Conversions.ToString(i)) ^ 82).ToString();
			}

			this.SecretTextBox.Text = text;
		}
	}
}
