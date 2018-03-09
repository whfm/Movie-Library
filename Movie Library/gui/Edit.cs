using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WinFormsCast;
using WinFormsValidation;

namespace Movie_Library.gui
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }
        public static bool selected;
        public int indexCast;
        public static int index;
        public bool validation;

        string imgpath = @"..\..\data\" + Path.GetFileName(MovieLibraryMain.listOfMovies[index].Imgpath);
        List<Cast> addListOfCast = new List<Cast>();

        private void displayCast()
        {
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

        private bool IsValidData()
        {

            return
            Validation.IsPresent(txtCountry) && Validation.IsPresent(txtDirector) &&
            Validation.IsPresent(txtGenre) && Validation.IsPresent(txtTime) &&
            Validation.IsPresent(txtTitle) && Validation.IsPresent(txtYear) &&
            Validation.IsInt32(txtYear) && Validation.IsInt32(txtTime) &&
            Validation.IsntEmpty(listCast, textCast);

        }

        private void Edit_Load(object sender, EventArgs e)
        {

            index = MovieLibraryMain.index;

            this.txtTitle.Text = MovieLibraryMain.listOfMovies[index].Title;
            this.txtCountry.Text = MovieLibraryMain.listOfMovies[index].Country;
            this.txtGenre.Text = MovieLibraryMain.listOfMovies[index].Genre;
            this.txtDirector.Text = MovieLibraryMain.listOfMovies[index].Director;
            this.txtTime.Text = Convert.ToString(MovieLibraryMain.listOfMovies[index].Time);
            this.txtYear.Text = Convert.ToString(MovieLibraryMain.listOfMovies[index].Year);

            imgpath = MovieLibraryMain.listOfMovies[index].Imgpath;

            String[] cast = MovieLibraryMain.listOfMovies[index].Castmember.Castmember.Split('*');

            addListOfCast.Clear();

            for (int j = 0; j < cast.Count()-1; j++)
            {
                Cast Cast = new Cast();
                Cast.Castmember = cast[j];
                
                this.addListOfCast.Add(Cast);
            }
            displayCast();

            if (imgpath.Length != 0)
            {
                try
                {
                    this.picBox.Image = System.Drawing.Image.FromFile(@"..\..\data\" + Path.GetFileName(imgpath));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Verify the path to your file.\nIt shouldn't contain spaces or special characters.\n" + ex.Message);
                }
            }
            else
            {
                this.picBox.Image = System.Drawing.Image.FromFile(@"..\..\data\sorry.png");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string casting = "";
            /*if ((Validation.IsNumeric(txtTime.Text)) && (Validation.IsNumeric(txtYear.Text)))
            {
                validation = true;                
            }
            else
            {
                MessageBox.Show("Check the data entered.\nYear and Time have to be numeric.");
            } */
            if (IsValidData())
            {
                MovieLibraryMain.listOfMovies[index].Title = this.txtTitle.Text;
                MovieLibraryMain.listOfMovies[index].Genre = txtGenre.Text;
                MovieLibraryMain.listOfMovies[index].Director = txtDirector.Text;
                MovieLibraryMain.listOfMovies[index].Country = txtCountry.Text;
                MovieLibraryMain.listOfMovies[index].Time = Convert.ToInt32(txtTime.Text);
                MovieLibraryMain.listOfMovies[index].Year = Convert.ToInt32(txtYear.Text);

                foreach (Cast aCast in this.addListOfCast)
                {
                    casting += aCast + "*";
                }
                if (imgpath.Length != 0)
                {
                    if (!File.Exists(@"..\..\data\" + Path.GetFileName(imgpath)))
                    {
                        File.Copy(imgpath, @"..\..\data\" + Path.GetFileName(imgpath));
                    }
                    MovieLibraryMain.listOfMovies[index].Imgpath = imgpath;
                }
                else
                {
                    MovieLibraryMain.listOfMovies[index].Imgpath = @"..\..\data\sorry.png";
                }

                MovieLibraryMain.listOfMovies[index].Castmember = new Cast(casting);

                MovieLibraryMain.addSuccess = true;
                this.Close();
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
            indexCast = this.listCast.SelectedIndex;
            if (selected == true)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item ?",
                                     "Confirm Delete!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    this.addListOfCast.RemoveAt(indexCast);
                    this.listCast.Items.RemoveAt(indexCast);
                    
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

        private void btnEditCast_Click(object sender, EventArgs e)
        {
            indexCast = listCast.SelectedIndex;
            addListOfCast[indexCast].Castmember = textCast.Text;
            displayCast();
        }

        private void listCast_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = true;
            indexCast = this.listCast.SelectedIndex;
            if (indexCast != -1)
            {
                textCast.Text = addListOfCast[indexCast].Castmember;
            }
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            imgpath = @"..\..\data\sorry.png";
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.FilterIndex = 1;
            dlg.Multiselect = false;
            dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            dlg.ShowDialog();

            imgpath = dlg.FileName;

            if (imgpath.Length != 0)
            {
                //MessageBox.Show(imgpath);
                if (!File.Exists(@"..\..\data\" + Path.GetFileName(imgpath))) {
                    File.Copy(imgpath, @"..\..\data\" + Path.GetFileName(imgpath));
                }
                picBox.Image = System.Drawing.Image.FromFile(@"..\..\data\" + Path.GetFileName(imgpath));
            }
            else
            {
                MessageBox.Show("Please select a valid image format.\n You can leave it in blank for no image display.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
