using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WinFormsMovies;
using System.IO;

namespace Movie_Library.gui
{
    public partial class MovieInfo : Form
    {
        List<Movies> newMovie = new List<Movies>();

        public MovieInfo()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            int index = MovieLibraryMain.index;
            this.txtTitle.Text = MovieLibraryMain.listOfMovies[index].Title;
            this.txtCountry.Text = MovieLibraryMain.listOfMovies[index].Country;
            this.txtGenre.Text = MovieLibraryMain.listOfMovies[index].Genre;
            this.txtDirector.Text = MovieLibraryMain.listOfMovies[index].Director;
            this.txtTime.Text = Convert.ToString(MovieLibraryMain.listOfMovies[index].Time);
            this.txtYear.Text = Convert.ToString(MovieLibraryMain.listOfMovies[index].Year);

            string imgpath = @"..\..\data\" + Path.GetFileName(MovieLibraryMain.listOfMovies[index].Imgpath);

            String[] cast = MovieLibraryMain.listOfMovies[index].Castmember.Castmember.Split('*');

            for (int j = 0; j < cast.Count()-1; j++)
            {
                    this.listCast.Items.Add(cast[j]);
            }

            if (imgpath.Length != 0)
            {
                try
                {
                    this.picBox.Image = System.Drawing.Image.FromFile(imgpath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Verify the path to your file.\nIt shouldn't contain spaces or special characters.\n" + ex.Message);
                    this.picBox.Image = System.Drawing.Image.FromFile(@"..\..\data\sorry.png");
                }
            }
            else
            {
                this.picBox.Image = System.Drawing.Image.FromFile(@"..\..\data\sorry.png");
            }

        }
    }
}
