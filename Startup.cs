using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_line_Managment_System
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }
        int Move = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Left += 2;
            if(panel2.Left > 247)
            {
                panel2.Left = 0;
            }
            if(panel2.Left<0)
            {
                Move = 2;
            }
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

    }
}
