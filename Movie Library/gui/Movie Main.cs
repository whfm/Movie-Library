using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsCast;
using WinFormsMovies;
using Login;
using Login_Data;
using Login_Handler;
using Movie_Library.gui;
using About_Box;

using MessageBox = System.Windows.Forms.MessageBox;

namespace Movie_Library
{
    public partial class MovieLibraryMain : Form
    {
        public static int index;
        public static bool close;
        public bool logout;
        public static string userlogged;

        public static List<Movies> listOfMovies = new List<Movies>();
        public static List<Cast> listOfCast = new List<Cast>();
        public static List<LoginData> listOfUser = new List<LoginData>();

        public static bool addSuccess = false;

        bool selected = false;
              
        public MovieLibraryMain()
        {
            InitializeComponent();
                       
        }

        public void DisplayListView(List<Movies> listOfMovies)
        {
            listMovies.Items.Clear();
            foreach (Movies element in listOfMovies)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(element.Title));
                item.SubItems.Add(element.Genre);
                item.SubItems.Add(element.Director);
                item.SubItems.Add(element.Country);
                item.SubItems.Add(Convert.ToString(element.Time));
                item.SubItems.Add(Convert.ToString(element.Year));
                listMovies.Items.Add(item);
            }
        }
        public void DisplayListViewBin(List<Movies> listOfMovies, ListView listMovies)
        {
            listMovies.Items.Clear();

            foreach (Movies element in listOfMovies)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(element.Title));
                item.SubItems.Add(element.Genre);
                item.SubItems.Add(element.Director);
                item.SubItems.Add(element.Country);
                item.SubItems.Add(Convert.ToString(element.Time));
                item.SubItems.Add(Convert.ToString(element.Year));
                listMovies.Items.Add(item);
            }
        }

        private void MovieLibraryMain_Load(object sender, EventArgs e)
        {
            listOfUser = new List<LoginData>();
            listOfUser = LoginHandler.ReadUsers();
            DisplayListViewBin(listOfMovies, listMovies);
            MovieLibraryMain myMainForm = new MovieLibraryMain();

            Form Login = new LoginForm();
            Login.ShowDialog();


            if (close == true) { this.Close(); }
            else
            {
                this.Text = "Movie Library - Welcome " + userlogged + "!";
                listMovies.Items.Clear();
                listMovies.View = View.Details;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listOfCast.Clear();
            MovieLibraryMain myMainForm = new MovieLibraryMain();
                        
            Form Add = new Add();
            Add.ShowDialog();

            DisplayListView(listOfMovies);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selected == true)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item ?",
                                     "Confirm Delete!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    listOfMovies.RemoveAt(index);
                    this.listMovies.Items.RemoveAt(index);
                    selected = false;
                    MessageBox.Show("The item was deleted.");
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

        private void listMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = true;
            
            if (listMovies.SelectedItems.Count > 0)
            {
                index = listMovies.SelectedIndices[0];
            }
        }
  
        private void btnSave_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Would you like to save the database to the file?\nIt will overwrite the previous database.",
                                     "Confirm Save!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                FileHandler.FileHandler.WriteToBinary(listOfMovies);

            }
            else
            {
                MessageBox.Show("The data wasn't saved!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Would you like to close the application?",
                                     "Confirm Close!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("The application wont be closed.");
            }
        }

        private void btnListMovies_Click(object sender, EventArgs e)
        {
            if (listOfMovies.Count == 0)
            {
                MessageBox.Show("The database is empity or wasn't loaded from the file.");
            }
            DisplayListView(listOfMovies);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listMovies.Items.Clear();
        }

        private void btLoadData_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Would you like to load the database from the file?\nIt will wipe any unsaved entered data.",
                                     "Confirm load!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                listOfMovies = new List<Movies>();
                listOfMovies = FileHandler.FileHandler.ReadFromBinary();
                DisplayListViewBin(listOfMovies, listMovies);
            }
                  
            else
            {
                MessageBox.Show("The database file wasn't loaded.");
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (selected == true)
            {
                MovieLibraryMain myMainForm = new MovieLibraryMain();

                Form MovieInfo = new MovieInfo();
                MovieInfo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a movie from the database in order to display its details.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            listOfCast.Clear();
            MovieLibraryMain myMainForm = new MovieLibraryMain();

            Form Edit = new Edit();
            Edit.ShowDialog();
            DisplayListView(listOfMovies);
        }

        private void listMovies_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (selected == true)
            {
                MovieLibraryMain myMainForm = new MovieLibraryMain();

                Form MovieInfo = new MovieInfo();
                MovieInfo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a movie from the database in order to display its details.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MovieLibraryMain myMainForm = new MovieLibraryMain();

            Form Search = new Search();
            Search.ShowDialog();
        }

        private void HLPBtnClick(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MovieLibraryMain myMainForm = new MovieLibraryMain();

            Form About = new About_Box.AboutBox();
            About.ShowDialog();
        }

        private void HLPRqst(object sender, HelpEventArgs hlpevent)
        {
            MovieLibraryMain myMainForm = new MovieLibraryMain();

            Form About = new About_Box.AboutBox();
            About.ShowDialog();
        }
    }
}