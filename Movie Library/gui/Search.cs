using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WinFormsCast;
using WinFormsMovies;

namespace Movie_Library.gui
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        public int count;
        private string imgpath;
        private static string search;
        private static bool found;
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
                }
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            found = false;
            listViewSearch.Items.Clear();
            listViewSearch.View = View.Details;  
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            count = 0;
            search = this.txtSearch.Text;
            this.listViewSearch.Items.Clear();
            this.listCast.Items.Clear();
            picBox.Image = System.Drawing.Image.FromFile(@"..\..\data\sorry.png");

            foreach (Movies element in MovieLibraryMain.listOfMovies)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(element.Title));
                item.SubItems.Add(element.Genre);
                item.SubItems.Add(element.Director);
                item.SubItems.Add(element.Country);
                item.SubItems.Add(Convert.ToString(element.Time));
                item.SubItems.Add(Convert.ToString(element.Year));
                item.SubItems.Add(element.Castmember.Castmember);
                item.SubItems.Add(element.Imgpath);

                if ((element.Title == search) || (element.Genre == search) || (element.Director == search) ||
                    (element.Country == search) || (Convert.ToString(element.Year) == search) ||
                    (Convert.ToString(element.Time) == search))
                {
                    String[] cast = MovieLibraryMain.listOfMovies[count].Castmember.Castmember.Split('*');

                    addListOfCast.Clear();
                   
                    for (int j = 0; j < cast.Count() - 1; j++)
                    {
                        Cast Cast = new Cast();
                        Cast.Castmember = cast[j];

                        this.addListOfCast.Add(Cast);
                    }
                    displayCast();
                    try
                    {
                        this.picBox.Image = System.Drawing.Image.FromFile(@"..\..\data\" + Path.GetFileName(element.Imgpath));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Verify the path to your picture file.\nIt shouldn't contain spaces or special characters.\n" + ex.Message);
                    } 
                    found = true;
                    this.listViewSearch.Items.Add(item);
                    break;
                }
                count++;
            }
        }

        private void listViewSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
