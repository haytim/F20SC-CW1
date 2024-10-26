using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_1
{
    public partial class HisUI : UserControl
    {
        public HisCode hc = new HisCode(); // creating HisCode instance
        public Browser f1 { get; set; } // referring to form1
        public HisUI()
        {
            InitializeComponent();
            DisplayHistory(); // displays on startup
        }

        // method for displaying history
        public void DisplayHistory()
        {
            hisFlowPanel.Controls.Clear(); // clearing the flowpanel
            hc.LoadHis(); // loads history fresh from the file
            foreach (string h in hc.history)
            {
                // creating a button displaying the history link
                Button historyButton = new Button
                {
                    Size = new Size(300, 26),
                    Text = h
                };

                // adding the functionality of loading the site when clicked
                historyButton.Click += (sender, e) =>
                {
                    f1.LoadSite(h);
                };
                hisFlowPanel.Controls.Add(historyButton); // adds button to the flowpanel
            }
            //hisFlowPanel.Refresh();
        }

        // method for clearing history
        private void ClearHistory_Click(object sender, EventArgs e)
        {
            hc.ClearHis();
            DisplayHistory(); // refreshes display once cleared
        }
    }
}
