using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Payment : UserControl
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            Air_line_Managment_System.Seats.count = 0;
            Air_line_Managment_System.Seats.payment = 0;
            Hide();
        }

        private void button74_Click(object sender, EventArgs e)
        {
            Accountname.Text = Air_line_Managment_System.Joinus.Email;
            totalseeatsbox.Text = Air_line_Managment_System.Seats.count.ToString();
            totalamount.Text = Air_line_Managment_System.Seats.payment.ToString();
            panel1.Show();
        }
    }
}
