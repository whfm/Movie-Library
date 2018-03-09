using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Movie_Library;
using Login_Data;
using Login_Handler;
using Add_User;
using About_Box;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Login
{
    public partial class LoginForm : Form
    {
        public int attempt;
        public bool deleted;
        public static bool addsuccess;
        public static bool save;
        public bool selected;
        public static string username;
        public static string pass1;
        public static string pass2;
        public int indexUser;

        public LoginForm()
        {
            InitializeComponent();
        }
        public void DisplayUsers(List<LoginData> listOfUsers)
        {
            listUser.Items.Clear();
            foreach (LoginData element in listOfUsers)
            {
                listUser.Items.Add(element.Username);
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            save = true;
            deleted = false;
            addsuccess = false;
            MovieLibraryMain.close = true;
            LoginHandler.ReadUsers();
            MovieLibraryMain.listOfUser = new List<LoginData>();
            MovieLibraryMain.listOfUser = LoginHandler.ReadUsers();
            DisplayUsers(MovieLibraryMain.listOfUser);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MovieLibraryMain.close = true;
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (selected)
            {
                if ((save == true) && (!deleted) && (!addsuccess))
                {
                    if (MovieLibraryMain.listOfUser[indexUser].Password == txtPass.Text)
                    {
                        MovieLibraryMain.close = false;
                        MovieLibraryMain.userlogged = MovieLibraryMain.listOfUser[indexUser].Username;
                        this.Close();
                    }
                    else
                    {
                        attempt++;
                        MessageBox.Show("Verify the password. Attempt " + attempt + " of 3.");
                        if (attempt == 3)
                        {
                            MovieLibraryMain.close = true;
                            MessageBox.Show("Invalid password entered multiple times. The application will shut down");
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please save your modifications before logging.");
                }
            }
            else
            {
                MessageBox.Show("Please select an user before trying to login.");
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            addsuccess = false;
            LoginForm myMainForm = new LoginForm();

            Form AddUser = new AddUser();
            AddUser.ShowDialog();
            if (addsuccess)
            {
                DisplayUsers(MovieLibraryMain.listOfUser);
            }

        }

        private void listUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = true;
            indexUser = this.listUser.SelectedIndex;
            if (indexUser != -1)
            {
                lblHint.Text = MovieLibraryMain.listOfUser[indexUser].PasswordHint;
            }
            txtPass.Clear();
        }

        private void FormClose(object sender, FormClosedEventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save = true;
            deleted = false;
            addsuccess = false;
            var confirmResult = MessageBox.Show("Would you like to save the database to the file?\nIt will overwrite the previous database.",
                                     "Confirm Save!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                LoginHandler.WriteUser(MovieLibraryMain.listOfUser);
            }
            else
            {
                MessageBox.Show("The data wasn't saved!");
            }
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (selected == true)
            {
                attempt = 0;
                deleted = true;
                var confirmResult = MessageBox.Show("Are you sure to delete this item ?",
                                     "Confirm Delete!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    if (MovieLibraryMain.listOfUser[indexUser].Password == txtPass.Text)
                    {
                        MovieLibraryMain.listOfUser.RemoveAt(indexUser);
                        this.listUser.Items.RemoveAt(indexUser);

                        selected = false;
                        save = false;
                        MessageBox.Show("The item was deleted.");
                    }
                    else
                    {
                        attempt++;
                        MessageBox.Show("Verify the password. Attempt " + attempt + " of 3.");
                        if (attempt == 3)
                        {
                            MovieLibraryMain.close = true;
                            MessageBox.Show("Invalid password entered multiple times. The application will shut down");
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The item was not deleted");
                }
            }
            else
            {
                MessageBox.Show("Please select an item to remove");
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            LoginForm myMainForm = new LoginForm();

            Form About = new AboutBox();
            //Form About = new About();
            About.ShowDialog();
        }
    }
}

