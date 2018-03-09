using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using WinFormsCast;
using WinFormsMovies;
using WinFormsValidation;

using MessageBox = System.Windows.Forms.MessageBox;
using Validation = WinFormsValidation.Validation;


namespace Movie_Library.gui
{
    public partial class Add : Form 
    {
        public bool validation;
        bool selected;

        List<Cast> addListOfCast = new List<Cast>();
        List<Movies> newMovie = new List<Movies>();
        string imgpath;

        int index;
        public string newCast;
        public string path;

        private bool IsValidData()
        {
            return
            Validation.IsPresent(txtCountry) && Validation.IsPresent(txtDirector) &&
            Validation.IsPresent(txtGenre) && Validation.IsPresent(txtTime) &&
            Validation.IsPresent(txtTitle) && Validation.IsPresent(txtYear) &&
            Validation.IsInt32(txtYear) && Validation.IsInt32(txtTime) &&
            Validation.IsntEmpty(listCast, textCast);
            

        }

        public Add()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            imgpath = @"..\..\data\sorry.png";
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.FilterIndex = 1;
            dlg.Multiselect = false;
            dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.bmp";
            dlg.ShowDialog();
            
            
            imgpath = dlg.FileName;
            
            if (imgpath.Length != 0)
            {
                picBox.Image = System.Drawing.Image.FromFile(imgpath);
                if (!File.Exists(@"..\..\data\" + Path.GetFileName(imgpath)))
                {
                    File.Copy(imgpath, @"..\..\data\" + Path.GetFileName(imgpath));
                }
            }
            else
            {
                MessageBox.Show("Please select a valid image format.\nYou can leave it in blank for no image display.");
            }
            

        }

        private void btnAddCast_Click(object sender, EventArgs e)
        {
            if (Validation.IsLetter(textCast))
            {
                Cast Cast = new Cast();
                Cast.Castmember = textCast.Text;

                this.addListOfCast.Add(Cast);

                listCast.Items.Add(Cast);

                textCast.Text = "";
            }
        }

        private void btnRemoveCast_Click(object sender, EventArgs e)
        {
            if (selected == true)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item ?",
                                     "Confirm Delete!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    this.addListOfCast.RemoveAt(index);
                    this.listCast.Items.RemoveAt(index);
                    selected = false;
                    textCast.Text = "";
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

        private void listCast_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = true;
            index = listCast.SelectedIndex;
            if (index != -1)
            {
                textCast.Text = addListOfCast[index].Castmember;
            }
        }

        private void btnEditCast_Click(object sender, EventArgs e)
        {
            index = listCast.SelectedIndex;
            addListOfCast[index].Castmember = textCast.Text;
            displayCast();
        }

        private void displayCast () {
            listCast.Items.Clear();
            if (this.addListOfCast.Capacity != 0)
            {
                foreach (Cast aCast in this.addListOfCast)
                {
                    this.listCast.Items.Add(aCast);
                    MovieLibraryMain.listOfCast.Add(aCast);
                    textCast.Text = "";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /* if ((Validation.IsNumeric(txtTime.Text)) && (Validation.IsNumeric(txtYear.Text)))
            {
                validation = true;                
            }
            else
            {
                MessageBox.Show("Check the data entered.\nYear and Time have to be numeric.");
            } */
            if (IsValidData())
            {
                string casting = "";
                Movies aMovie = new Movies();
                aMovie.Title = txtTitle.Text;
                aMovie.Genre = txtGenre.Text;
                aMovie.Director = txtDirector.Text;
                aMovie.Country = txtCountry.Text;
                aMovie.Time = Convert.ToInt32(txtTime.Text);
                aMovie.Year = Convert.ToInt32(txtYear.Text);
                foreach (Cast aCast in this.addListOfCast)
                {
                    casting += aCast + "*";
                }
                if (imgpath.Length != 0)
                {
                    aMovie.Imgpath = Path.GetFileName(imgpath);
                }
                else
                {
                    aMovie.Imgpath = @"..\..\data\sorry.png";
                }
                aMovie.Castmember = new Cast(casting);
                newMovie.Add(aMovie);

                MovieLibraryMain.listOfMovies.Add(aMovie);
                MovieLibraryMain.listOfCast = this.addListOfCast;

                MovieLibraryMain.addSuccess = true;
                this.Close();
            }
        }

        private void Add_Load(object sender, EventArgs e)
        {
            MovieLibraryMain.addSuccess = false;
            imgpath = "";
        }

        private void picBox_Click(object sender, EventArgs e)
        {

        }
    }
}
