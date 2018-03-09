using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsValidation
{
    [Serializable]
    public static partial class Validation
    {
        private static string message = "Entry Error";
        public static string Message
        {
            get { return message; }
            set { message = value; }
        }

        public static bool IsLetter(TextBox textBox)
        {
            if (Regex.IsMatch(textBox.Text ?? "", @"^[a-zA-Z\s]+$", RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be letters only and not empity.", Message);
                textBox.Clear();
                textBox.Focus();
                return false;
            }

        }

        public static bool IsInt32(TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", Message);
                textBox.Clear();
                textBox.Focus();
                return false;
            }
        }
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required field and can not be left blank.", Message);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsntEmpty(ListBox listBox, TextBox txtBox)
        {
            if (listBox.Items.Count <= 0)
            {
                MessageBox.Show(listBox.Tag + " is a required field and can not be left blank.", Message);
                txtBox.Focus();
                return false;
            }
            return true;
        }
    }
}
