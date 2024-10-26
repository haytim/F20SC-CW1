using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework_1
{
    public class HisCode
    {
        // creating stacks for history & future sites
        public Stack<string> history = new Stack<string>();
        public Stack<string> future = new Stack<string>();

        public void LoadHis()
        {
            history.Clear(); // clearing history stack before adding everything
            if (File.Exists("history.txt")) // only reads from history file if it exists
            {
                string line; // temporary string used for storing each line of history
                StreamReader sr = new StreamReader("history.txt"); // reading history.txt

                while ((line = sr.ReadLine()) != null) // reads till end of file
                {
                    history.Push(line); // pushes line to the stack
                }
                sr.Close(); // closing history.txt
            }
        }

        // method for adding history to the file & stack
        public void AddHis(string url)
        {
            WriteHis(url); // writes given url to file
            history.Push(url); // pushes given url to stack
        }

        public void WriteHis(string url)
        {
            StreamWriter sw = new StreamWriter("history.txt", true); // opening history.txt
            sw.WriteLine(url); // writing given url on new line
            sw.Close(); // closing history.txt
        }

        //method of deleting history
        public void ClearHis()
        {
            System.IO.File.Delete("history.txt"); // deletes history file
            history.Clear(); // clears the stack
        }

        // method for getting previous page
        public string GetBackwards()
        {
            future.Push(history.Pop()); // pushes current page to the future stack
            return history.Pop(); // returns previous page
        }

        // method for getting future page
        public string GetForwards()
        {
            return future.Pop(); // returns future page
        }
    }
}
