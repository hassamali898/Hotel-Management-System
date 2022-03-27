using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_line_Managment_System
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            joinus1.Hide();
        }
        private void Join_Click(object sender, EventArgs e)
        {
            joinus1.Show();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

    }
}
