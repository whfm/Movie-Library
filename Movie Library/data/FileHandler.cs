using System.Collections.Generic;
using System.IO;
using WinFormsMovies;
using System.Runtime.Serialization.Formatters.Binary;
using Movie_Library;


namespace FileHandler
{
    public class FileHandler
    {
        public static string binPath = @"..\..\data\" + MovieLibraryMain.userlogged + "-BIN.ser";
        public static void WriteToBinary(List<Movies> listOfMovies)
        {
            FileStream fs = new FileStream(binPath, FileMode.Create, FileAccess.Write);
            BinaryFormatter bin = new BinaryFormatter();
            foreach (Movies item in listOfMovies)
            {
                bin.Serialize(fs, item);
            }
            fs.Close();
        }

        public static List<Movies> ReadFromBinary()
        {
            List<Movies> list = new List<Movies>();
            if (File.Exists(binPath))
            {
                FileStream fs = new FileStream(binPath, FileMode.Open, FileAccess.Read);
                BinaryFormatter bin = new BinaryFormatter();
                while (fs.Position < fs.Length)
                {
                    Movies unMovie = new Movies();
                    unMovie = (Movies)bin.Deserialize(fs);
                    list.Add(unMovie);
                }
                fs.Close();
            }
            return list;
        }
    }
}
