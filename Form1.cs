using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;
using System.Security.Policy;

namespace Coursework_1
{
    public partial class Browser : Form
    {
        // instantiating code classes
        SearchCode searchCode = new SearchCode();   
        SetCode setCode = new SetCode();
        FavCode favCode = new FavCode();
        HisCode hisCode = new HisCode();
        
        public Browser()
        {
            InitializeComponent();
            setCode.LoadHome(); // loading home page on startup
            LoadSite(setCode.homeURL); // searching home page
            searchBox.AutoSize = true;
            // connecting form references to this form
            favUI1.f1 = this;
            hisUI1.f1 = this;
            downUI1.f1 = this;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            // loads the home page file fresh (incase of change) and searches it
            setCode.LoadHome(); 
            LoadSite(setCode.homeURL);
        }        
        private void hisButton_Click(object sender, EventArgs e)
        {
            // hides/shows user interfaces accordingly
            searchUI1.Hide();
            setUI1.Hide();
            favUI1.Hide();
            hisUI1.Show();
            downUI1.Hide();

            // re-displaying history
            hisUI1.DisplayHistory();
        }

        private void favButton_Click(object sender, EventArgs e)
        {
            // hides/shows user interfaces accordingly
            searchUI1.Hide();
            setUI1.Hide();
            favUI1.Show();
            hisUI1.Hide();
            downUI1.Hide();
        }
        private void downButton_Click(object sender, EventArgs e)
        {
            // hides/shows user interfaces accordingly
            searchUI1.Hide();
            setUI1.Hide();
            favUI1.Hide();
            hisUI1.Hide();
            downUI1.Show();
        }
        
        // method used to display search UI 
        public void DisplaySearchUI()
        {
            searchUI1.Show();
            setUI1.Hide();
            favUI1.Hide();
            hisUI1.Hide();
            downUI1.Hide();
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            // hides/shows user interfaces accordingly
            searchUI1.Hide();
            setUI1.Show();
            favUI1.Hide();
            hisUI1.Hide();
            downUI1.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // only loads previous site if there exists a site previous to the current site
            if (hisCode.history.Count() > 1)
            {
                searchUI1.Display.Text = "Loading..."; // lets the user know the previous site is loading
                LoadSiteWithoutClear(hisCode.GetBackwards()); // loads the previous site
                searchBox.Text = ""; // resets the search box to avoid confusion
            }
        }

        private void forButton_Click(object sender, EventArgs e)
        {
            // only loads forwards site if stack is not empty
            if (hisCode.future.Count() > 0)
            {
                searchUI1.Display.Text = "Loading..."; // lets the user know the next site is loading
                LoadSiteWithoutClear(hisCode.GetForwards()); // loads the next site
                searchBox.Text = ""; // resets the search box to avoid confusion
            }
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            searchUI1.Display.Text = "Reloading...";
            LoadSiteWithoutClear(searchCode.currentSite);
        }

        public async void LoadSite(string url)
        {
            // hides/shows user interfaces accordingly
            DisplaySearchUI();

            await searchCode.GetSite(url); // gettign site
            searchUI1.Display.Text = searchCode.html; // displaying raw html
            searchUI1.httpResponse.Text = searchCode.webResponse; // displaying web response
            searchUI1.httpTitle.Text = searchCode.webTitle; // displaying web title
            hisCode.AddHis(url); // adding the searched page to the history
            // clears the future stack to serve the functionality of overwriting the future sites
            hisCode.future.Clear();
        }

        public async void LoadSiteWithoutClear(string url)
        {
            // hides/shows user interfaces accordingly
            DisplaySearchUI();

            await searchCode.GetSite(url); // gettign site
            searchUI1.Display.Text = searchCode.html; // displaying raw html
            searchUI1.httpResponse.Text = searchCode.webResponse; // displaying web response
            searchUI1.httpTitle.Text = searchCode.webTitle; // displaying web title
            hisCode.AddHis(url); // adding the searched page to the history
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            LoadSite(searchBox.Text); // searches site based on searchbox text
        }

        private void Browser_Load(object sender, EventArgs e)
        {

        }
    }
}
