using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Login_Data;

namespace Login_Handler
{
    public class LoginHandler
    {
            public static string binPath = @"..\..\data\usersBIN.ser";
            public static void WriteUser(List<LoginData> listOfUsers)
            {
                FileStream fs = new FileStream(binPath, FileMode.Create, FileAccess.Write);
                BinaryFormatter bin = new BinaryFormatter();
                foreach (LoginData item in listOfUsers)
                {
                    bin.Serialize(fs, item);
                }
                fs.Close();
            }

            public static List<LoginData> ReadUsers()
            {
                List<LoginData> list = new List<LoginData>();
                if (File.Exists(binPath))
                {
                    FileStream fs = new FileStream(binPath, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bin = new BinaryFormatter();
                    while (fs.Position < fs.Length)
                    {
                        LoginData unUser = new LoginData();
                        unUser = (LoginData)bin.Deserialize(fs);
                        list.Add(unUser);
                    }
                    fs.Close();
                }
                return list;
            }
        }
    }

