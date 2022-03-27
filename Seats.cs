using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Air_line_Managment_System;

namespace Air_line_Managment_System
{
    
    public partial class Seats : UserControl
    {
        public static int count=0;
        public static float payment = 0;
        bool b = true;
        Cell[][] seat;
        int rowdim = 8;
        int coldim = 10;
        public Seats()
        {
            
            InitializeComponent();
            
            seat = new Cell[rowdim][];
            Seatsbox.Controls.Clear();
            for (int r = 0; r < rowdim; r++) 
            {
                seat[r] = new Cell[coldim];
            }
            
        }
        private void button75_Click(object sender, EventArgs e)
        {
            Hide();
            Seatsbox.Hide();
        }
        private void StartClicked(object sender, EventArgs e)
        {
            Cell Clicked = (Cell)sender;
            if(Clicked.booked == false)
            {
                Clicked.Image = Properties.Resources.seet2x;
                Clicked.booked = true;
            }
            else
            {
                Clicked.Image = Properties.Resources.seet3x;
                Clicked.booked = false;
            }
        }
        public void disableClicked()
        {
            string b;
            string cc;
            string d;
            b = aeroplan_system.Booking;
            cc = aeroplan_system.from;
            d = aeroplan_system.date;
        
            for (int r = 0; r < rowdim; r++)
            {
                for (int c = 0; c < coldim; c++)
                {
                    DataSet ds = new DataSet();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        seat[r][c].Enabled = false;
                        seat[r][c].booked = true;
                        seat[r][c].Image = Properties.Resources.seat4x;
                    }
                    else
                    {
                        seat[r][c].Enabled = true;
                        seat[r][c].booked = false;
                        seat[r][c].Image = Properties.Resources.seet3x;
                    }
                }
            }
        }

        private void button74_Click(object sender, EventArgs e)
        {
            count = 0;
            int pay = 80000;
           
            for (int r = 0; r < rowdim; r++)
            {
                for (int c = 0; c < coldim; c++)
                {
                    if (seat[r][c].booked == true && seat[r][c].Enabled == true)
                    {
                      
                        
                        if (true)
                        {
                            
                            seat[r][c].Enabled = false;
                            seat[r][c].booked = true;
                            seat[r][c].Image = Properties.Resources.seat4x;
                            
                        }
                        count++;
                        payment += pay;
                    }
                    else if(seat[r][c].Enabled == true && seat[r][c].booked == false)
                    {
                       
                    }
                }
            }
            payment1.Show();

        }

        private void edit_Click(object sender, EventArgs e)
        {
            for (int r = 0; r < rowdim; r++)
            {
                for (int c = 0; c < coldim; c++)
                {
                    
                    DataSet ds = new DataSet();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        seat[r][c].Enabled = true;
                        seat[r][c].booked = true;
                        seat[r][c].Image = Properties.Resources.seet2x;
                        
                    }
                }
            }

            
        }

        private void Seats_Load(object sender, EventArgs e)
        {
            
        }

        private void Showbutton_Click(object sender, EventArgs e)
        {
            if(b == true)
            {
                int seatindex = 1;
                for (int r = 0; r < rowdim; r++)
                {
                    for (int c = 0; c < coldim; c++)
                    {
                        seat[r][c] = new Cell();
                        seat[r][c].ri = r;
                        seat[r][c].ci = c;
                        seat[r][c].value = seatindex;
                        seat[r][c].FlatStyle = button74.FlatStyle;
                        seat[r][c].FlatAppearance.BorderSize = 0;
                        seat[r][c].Image = Properties.Resources.seet3x;
                        seat[r][c].Text = seatindex.ToString();
                        seat[r][c].Width = Seatsbox.Width / coldim - 8;
                        seat[r][c].Height = Seatsbox.Height / rowdim - 5;
                        Seatsbox.Controls.Add(seat[r][c]);
                        seat[r][c].Click += new EventHandler(StartClicked);
                        seatindex++;
                        seat[r][c].booked = false;
                    }
                }
            }
            
            disableClicked();
            b = false;
            Seatsbox.Show();
        }




        



       
    }
}
