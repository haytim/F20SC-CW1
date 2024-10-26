using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Coursework_1
{
    internal class DownCode
    {
        // creating httpclient instance
        HttpClient client = new HttpClient();
        string line = ""; // temporary string used for storing lines from file

        // struct to easily collate relevant data
        public struct downloadData
        {
            public string webResponse { get; set; }
            public string webURL { get; set; }
            public int webBytes { get; set; }
        }
        // creating List of downloads
        public List<downloadData> downloadList = new List<downloadData>();

        // method for loading from file
        public async Task LoadBulk(string path)
        {
            downloadList.Clear(); // clearing download list
            if (path == "") { path = "bulk.txt"; } // setting path to default if input is left empty

            // only proceeding if file exists
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path); // openign file for reading
                // reads every line into the download list
                while ((line = sr.ReadLine()) != null) // reads till end of file
                {
                    downloadList.Add(await GetDown(line)); // adds line to list
                }
                // accounting for the empty file
                if (downloadList.Count == 0)
                {
                    downloadData dFail = new downloadData();
                    dFail.webResponse = "File Empty";
                    downloadList.Add(dFail);
                }
                sr.Close(); // closing the file reader
            }
            // notifying user if file does not exist
            else
            {
                downloadData dFail = new downloadData();
                dFail.webResponse = "Failed, please ensure filename exists";
                downloadList.Add(dFail);
            }
        }

        // method used for getting all the relevant download data using httpclient
        public async Task<downloadData> GetDown(string url)
        { 
            try
            {
                HttpResponseMessage response = await client.GetAsync(url); // storing url response

                downloadData dd = new downloadData(); // creaiting download object to store relevant data
                // storing relevant data
                dd.webResponse = Convert.ToString((int)response.StatusCode) + " " + Convert.ToString(response.ReasonPhrase); // printing status code
                dd.webURL = url;
                dd.webBytes = Convert.ToInt32(response.Content.Headers.ContentLength);

                return dd; // returns data
            }
            // catching invalid URLs and notifying the user
            catch (System.InvalidOperationException e)
            {
                downloadData dFail = new downloadData();
                dFail.webResponse = "Failed, file contains invalid URL";
                Console.WriteLine(e.Message);
                return dFail;
            }
        }
    }
}
