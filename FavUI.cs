using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_1
{
    public partial class FavUI : UserControl
    {
        FavCode fc = new FavCode();
        public Browser f1 { get; set; }
        public FavUI()
        {
            InitializeComponent();
            fc.LoadFav();
            DisplayFav();
        }

        private void AddFav_Click(object sender, EventArgs e)
        {
            fc.SaveFav(FavNameInputBox.Text, FavURLInputBox.Text);
            DisplayFav();
        }
        public void DisplayFav()
        {
            favFlowPanel.Controls.Clear();
            foreach (FavCode.favouriteLine fav in fc.lines)
            {
                Button nameButton = new Button
                {
                    Size = new Size(300, 26),
                    Text = fav.name,
                };

                nameButton.Click += (sender, e) =>
                {
                    f1.LoadSite(fav.url);
                };

                Button urlButton = new Button
                {
                    Size = new Size(300, 26),
                    Text = fav.url,
                };

                urlButton.Click += (sender, e) =>
                {
                    f1.LoadSite(fav.url);
                };

                Button delButton = new Button
                {
                    Size = new Size(113, 26),
                    Text = "Delete",
                };

                delButton.Click += (sender, e) =>
                {
                    fc.DeleteFav(fav);
                    DisplayFav();
                };

                TextBox nameInputBox = new TextBox
                {
                    Size = new Size(300, 26),
                    Text = fav.name,
                };

                TextBox urlInputBox = new TextBox
                {
                    Size = new Size(300, 26),
                    Text = fav.url,
                };

                Button updateButton = new Button
                {
                    Size = new Size(113, 26),
                    Text = "Update",
                };

                updateButton.Click += (sender, e) =>
                {
                    fc.DeleteFav(fav);
                    fc.SaveFav(nameInputBox.Text, urlInputBox.Text);
                    DisplayFav();
                };

                favFlowPanel.Controls.Add(nameButton);
                favFlowPanel.Controls.Add(urlButton);
                favFlowPanel.Controls.Add(delButton);
                favFlowPanel.Controls.Add(nameInputBox);
                favFlowPanel.Controls.Add(urlInputBox);
                favFlowPanel.Controls.Add(updateButton);


            }
        }

        private void FavUI_Load(object sender, EventArgs e)
        {

        }
    }
}
