using System;
using System.Windows.Forms;
using Login;
using Login_Data;
using Movie_Library;

namespace Add_User
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            txtHint.Text = "Hint";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == txtPassChk.Text)
            {
                LoginForm.username = this.txtUser.Text;
                LoginForm.pass1 = this.txtPass.Text;
                LoginForm.pass2 = this.txtPassChk.Text;
                LoginForm.addsuccess = true;
                LoginForm.save = false;
                LoginData aUser = new LoginData();
                aUser.Password = txtPass.Text;
                aUser.Username = txtUser.Text;
                aUser.PasswordHint = txtHint.Text;
                MovieLibraryMain.listOfUser.Add(aUser);
                MessageBox.Show("New user successfully added.");
                this.Close();

            }            
            else
            {
                MessageBox.Show("Passwords doesn't match.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
