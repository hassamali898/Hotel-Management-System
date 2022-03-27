using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
namespace Air_line_Managment_System
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread trdd = new Thread(new ThreadStart(frmRun));
            trdd.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            trdd.Abort();
            //this.SetStyle(ControlStyles.ResizeRedraw, true);
            slidepanel.Height = Home2.Height;
            slidepanel.Top = Home2.Top;
            home1.BringToFront();
        }
        private void frmRun()
        {
            Application.Run(new Startup());
        }
        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        private void Home2_Click(object sender, EventArgs e)
        {
            slidepanel.Height = Home2.Height;
            slidepanel.Top = Home2.Top;
            home1.BringToFront();
        }

        private void Offers_Click(object sender, EventArgs e)
        {
            slidepanel.Height = Offers.Height;
            slidepanel.Top = Offers.Top;
            offers1.BringToFront();
        }

        private void Booking_Click(object sender, EventArgs e)
        {
            slidepanel.Height = Booking.Height;
            slidepanel.Top = Booking.Top;
            booking1.BringToFront();
        }

        private void Airlines_Click(object sender, EventArgs e)
        {
            slidepanel.Height = Airlines.Height;
            slidepanel.Top = Airlines.Top;
            employee1.BringToFront();
        }

        private void Contact_Click(object sender, EventArgs e)
        {
            slidepanel.Height = Contact.Height;
            slidepanel.Top = Contact.Top;
            contactus1.BringToFront();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void home1_Load(object sender, EventArgs e)
        {

        }

        private void fb_Click(object sender, EventArgs e)
        {
            Process.Start("www.facebook.com");
        }

        private void inta_Click(object sender, EventArgs e)
        {
            Process.Start("www.instagram.com");
        }

        private void twitter_Click(object sender, EventArgs e)
        {
            Process.Start("www.twitter.com");
        }

    }
}
