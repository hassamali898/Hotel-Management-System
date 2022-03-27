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
    public partial class Booking : UserControl
    {
        public Booking()
        {
            InitializeComponent();
            aeroplan_system1.Hide();
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = true;
            pictureBox3.Image = Properties.Resources.lock2;
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.isPassword == true)
                bunifuMaterialTextbox2.isPassword = false;
            else
                bunifuMaterialTextbox2.isPassword = true;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.passeye2;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.passeye3;
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.id2;
           
        }

        private void login_Click(object sender, EventArgs e)
        {
            string Email = bunifuMaterialTextbox1.Text;
            string Password = bunifuMaterialTextbox2.Text;
            aeroplan_system1.Show();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

    }
}
