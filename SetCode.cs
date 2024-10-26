using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework_1
{
    internal class SetCode
    {
        public string homeURL { get; set; }
        public void LoadHome()
        {
            if (File.Exists("home.txt"))
            {
                StreamReader sr = new StreamReader("home.txt");
                homeURL = sr.ReadLine();
                sr.Close();
            }
            else
            {
                homeURL = "https://www.hw.ac.uk/";
            }
        }

        public void WriteHome(string url)
        {
            StreamWriter sw = new StreamWriter("home.txt");
            sw.Write(url);
            sw.Close();
        }

        public void ResetHome()
        {
            if (System.IO.File.Exists("home.txt"))
            {
                System.IO.File.Delete("home.txt");
            }
            homeURL = "https://www.hw.ac.uk/";
        }
    }
}
