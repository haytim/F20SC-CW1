using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace Coursework_1
{    internal class SearchCode
    {
        // creating Httpclient instance
        HttpClient client = new HttpClient();
        public string html { get; set; }
        public string webTitle { get; set; }
        public string webResponse { get; set; }
        public string currentSite { get; set; }
        public async Task GetSite(string url)
        {
            // storing currentSite for reloading
            currentSite = url;

            // resets values whenever called
            html = "";
            webTitle = "";
            webResponse = "";

            try
            {
                HttpResponseMessage response = await client.GetAsync(url); // storing url response
                html = await response.Content.ReadAsStringAsync(); // storing raw html

                Regex r = new Regex(@"<title>\s*(.*)\s*</title>"); // regex for filtering title from html
                MatchCollection m = r.Matches(html); // getting title match from html
                if (m.Count > 0)
                {
                    webTitle = m[0].Value.Replace("<title>", "").Replace("</title>", "").Trim(); // removing title tags & blank space from title
                }
                else
                {
                    webTitle = ""; // no title if title cannot be found
                }
                webResponse = Convert.ToString((int)response.StatusCode) + " " + Convert.ToString(response.ReasonPhrase); // storing status code
            }
            // exception handling
            catch (System.InvalidOperationException e) 
            {
                html = "Please enter valid URL";
                webTitle = "Invalid URL";
                webResponse = "Error!";
                Console.WriteLine(e.Message);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
