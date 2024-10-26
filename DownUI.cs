using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Coursework_1.DownCode;

namespace Coursework_1
{
    public partial class DownUI : UserControl
    {
        // creating downcode instance
        DownCode dc = new DownCode();
        public Browser f1 { get; set; } // linking to form1
        public DownUI()
        {
            InitializeComponent();
        }

        private async void Download_Click(object sender, EventArgs e)
        {
            f1.DisplaySearchUI(); // calling method to display only search UI
            f1.searchUI1.Display.Text = "Loading..."; // notifying the user of loading
            f1.searchUI1.httpTitle.Text = "Response Code | Bytes | URL"; // adding general format to the title to assist user
            f1.searchUI1.httpResponse.Text = ""; // response box not necessary so left empty
            await dc.LoadBulk(BulkInputBox.Text); // calling loadbulk asynchronously 
            f1.searchUI1.Display.Text = ""; // resetting searchUI's display box

            // displays downloaded data in the search UI
            foreach (downloadData d in dc.downloadList)
            { 
                f1.searchUI1.Display.AppendText(d.webResponse + " " + d.webBytes + " " + d.webURL);
                f1.searchUI1.Display.AppendText(Environment.NewLine);
            }
        }
    }
}
