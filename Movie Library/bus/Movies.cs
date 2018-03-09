using System;
using WinFormsCast;

namespace WinFormsMovies
{
    [Serializable]
    public partial class Movies
    {
        private string imgpath;

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string genre;

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        private string director;

        public string Director
        {
            get { return director; }
            set { director = value; }
        }
        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        private int time;

        public int Time
        {
            get { return time; }
            set { time = value; }
        }
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        private Cast castmember;
        public Cast Castmember
        {
            get { return castmember; }
            set { castmember = value; }
        }

        public string Imgpath
        {
            get { return imgpath; }
            set { imgpath = value; }
        }

        public override string ToString()
        {
            String state;
            state = this.title + "\t" + this.genre + "\t"  + this.director + "\t" + this.country + "\t" + this.time + "\t" + this.year;
            return state;
        }

        public Movies(string title, string genre, string director, string country, int time, int year, Cast castmember, string imgpath)
        {
            this.imgpath = imgpath;
            this.castmember = castmember;
            this.title = title;
            this.genre = genre;
            this.director = director;
            this.country = country;
            this.time = time;
            this.year = year;
        }

        public Movies()
        {
            this.imgpath = @"..\..\data\sorry.png";
            this.castmember = new Cast();
            this.title = "Title";
            this.genre = "Genre";
            this.director = "Director";
            this.country = "Country";
            this.time = 0;
            this.year = 0;
        }
    }
}
