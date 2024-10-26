using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;
using System.Xml.Linq;

namespace Coursework_1
{
    internal class FavCode
    {
        // creating favourite structure to store both the name & title together
        public struct favouriteLine
        {
            public string name { get; set; }
            public string url { get; set; }  
        }
        // creating List of favourites
        public List<favouriteLine> lines = new List<favouriteLine>();
        string line = ""; // little string used for temporarily storing each line

        // saves the given new name & link to the file and sepearting using "¬" as it is rarely used
        public void SaveFav(string name, string url)
        {
            WriteFav(name, url);
            lines.Add(new favouriteLine { name = name, url = url });
        }

        // metohd for loading all the favourites from the file
        public void LoadFav()
        {
            if (File.Exists("favourites.txt")) // checks if the file exists
            { 
                StreamReader sr = new StreamReader("favourites.txt"); // opening file
                // reading every line until end of file
                while ((line = sr.ReadLine()) != null )
                {
                    var words = line.Split('¬'); // splitting word by ¬
                    if (words.Length == 2)
                    {
                        favouriteLine current = new favouriteLine(); // creating favourite struct to put in favourite list
                        // adding the name & title to the new favourite struct
                        current.name = words[0];
                        current.url = words[1];
                        lines.Add(current); // adding favourite struct to the list
                    }
                }
                sr.Close(); // closing the file
            }
            
        }

        // method for deleting a favourite
        public void DeleteFav(favouriteLine f)
        {
            lines.Remove(f); // removing the favourite from the list
            UpdateFav(); // updates the favourite file
        }

        public void UpdateFav()
        {
            if (System.IO.File.Exists("favourites.txt"))
            {
                System.IO.File.Delete("favourites.txt"); // deletes the file to start anew
            }
            // calling WriteFav on every favourite
            foreach (favouriteLine f in lines)
            {
                WriteFav(f.name, f.url);
            }
        }

        // method for writing a name url pair to the file
        public void WriteFav(string name, string url)
        {
            StreamWriter sw = new StreamWriter("favourites.txt", true); // opens file for writing
            sw.WriteLine(name + "¬" + url); // seperates name url pair by uncommon symbol
            sw.Close(); // closes file
        }
    }
}
