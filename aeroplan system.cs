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
    public partial class aeroplan_system : UserControl
    {
        public static string Booking;
        public static string from;
        public static string date;
        public aeroplan_system()
        {
            InitializeComponent();
            seats1.Hide();
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Join_Click(object sender, EventArgs e)
        {
            string ticketclass = Ticketclassbox.Text;
            Booking = Bookingbox.Text;
            from = frombox.Text;
            date = Datebox.Text;
            string Emails = Air_line_Managment_System.Joinus.Email;
            int count = 0;
            if (string.Compare(ticketclass, "Ticket Class") == 0)
            {
                Ticketclassbox.BackColor = Color.Red;
                count++;
            }
            if (string.Compare(Booking, "Booking") == 0)
            {
                Bookingbox.BackColor = Color.Red;
                count++;
            }
            if (string.Compare(from, "From") == 0)
            {
                frombox.BackColor = Color.Red;
                count++;
            }
            else
            {
                seats1.Show();
            }

            
        }

        private void Ticketclassbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
