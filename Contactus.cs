using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Air_line_Managment_System
{
    public partial class Contactus : UserControl
    {
        public Contactus()
        {
            InitializeComponent();
        }

        private void Contactus_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.wearelistening@airblue.com");
        }
    }
}
