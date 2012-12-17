using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MaRin.Tools.UnicodeText
{
	public partial class MainForm : Form
	{
		private readonly Button[] mButtons;

		[DllImport("getuname.dll", SetLastError = true)]
		private static extern int GetUName(UInt16 wCharCode, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpbuf);

		private void ShowChar(char c)
		{
			ch.Text = c.ToString(CultureInfo.InvariantCulture);
			ushort val = c;
			dec.Text = string.Format("{0} Dec", val);
			hex.Text = string.Format("{0:x} Hex", val);
			uni.Text = string.Format("U+{0:X4} Unicode", val);
			html.Text = string.Format("&#{0}; HTML", val);
			htmlHex.Text = string.Format("&#x{0:X}; HTML-HEX", val);

			string charName = GetUnicodeCharPointName(val);
			selInfo.Text = selInfo.Text + ", Char Name: " + charName;
		}

		private static string GetUnicodeCharPointName(ushort charCode)
		{
			// Use big enough buffer
			var sb = new StringBuilder(1024);
			GetUName(charCode, sb);
			return sb.ToString();
		}

		public MainForm()
		{
			InitializeComponent();
			ShowChar((char) 0);
			mButtons = new Button[] {dec, hex, uni, html, htmlHex};

			tbIn.SelectAll();

			// doesn't work yet
			Font font = tbIn.Font;
			fontProps.SelectedObject = font;
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && !e.Alt && !e.Shift)
			{
				int index = e.KeyValue - (short) '1';
				if (index >= 0 && index < mButtons.Length)
				{
					mButtons[index].PerformClick();
					e.Handled = true;
				}
			}
		}

		private void copy_Click(object sender, EventArgs e)
		{
			string text = ((Button) sender).Text;
			int index = text.LastIndexOf(' ');
			if (index != -1)
			{
				text = text.Substring(0, index);
				Clipboard.SetText(text);
			}
		}

		private void tbIn_Update(object sender, EventArgs e)
		{
			int index = tbIn.SelectionStart + tbIn.SelectionLength;
			selInfo.Text = string.Format("Selection: Start: {0}, Length: {1}, End: {2}", tbIn.SelectionStart,
			                             tbIn.SelectionLength, index);
			string text = tbIn.Text;
			if (index < 0 || index >= text.Length)
				ShowChar((char) 0);
			else
				ShowChar(text[index]);
		}
	}
}