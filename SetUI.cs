using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Coursework_1
{
    public partial class SetUI : UserControl
    {
        SetCode setCode = new SetCode();
        public SetUI()
        {
            InitializeComponent();
        }

        private void SetSave_Click(object sender, EventArgs e)
        {
            setCode.WriteHome(setHomeBox.Text);
        }

        private void ResetHomeBox_Click(object sender, EventArgs e)
        {
            setCode.ResetHome();
        }
    }
}
