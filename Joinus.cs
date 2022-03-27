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
    public partial class Joinus : UserControl
    {
        public Joinus()
        {
            InitializeComponent();
            aeroplan_system1.Hide();
        }
        public static string Email;
        public static bool IsAllLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }
        public static bool emailcheck(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c) && c != '@')
                    return false;
            }
            return true;
        }
        public static bool IsAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        public static bool IsAllDigitsanddash(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c) && c != '-')
                    return false;
            }
            return true;
        }
        public static bool IsAllLettersOrDigits(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetterOrDigit(c))
                    return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Firstnamebox.Text = "";
            Lastnamebox.Text = "";
            CNICbox.Text = "";
            Phonebox.Text = "";
            Emailbox.Text = "";
            Passwordbox.Text = "Password";
            pictureBox1.Image = Properties.Resources.upload;
            Male.Checked = false;
            Female.Checked = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void Upload_Click(object sender, EventArgs e)
        {
            string imagelocation = "System.Drawing.Bitmap";
            try
            {
                OpenFileDialog Dialog = new OpenFileDialog();
                Dialog.Filter = "jpg files(*.jpg) |*.jpg| PNG files(*.jpg) |*.png| ALL files(*.*) |*.*";
                if(Dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagelocation = Dialog.FileName;
                    pictureBox1.ImageLocation = imagelocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Joinus_Load(object sender, EventArgs e)
        {
           
        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {
            Passwordbox.isPassword = true;
            Passwordbox.LineIdleColor = Color.FromArgb(41, 39, 40);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Passwordbox.isPassword == true)
                Passwordbox.isPassword = false;
            else
                Passwordbox.isPassword = true;

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.passeye2;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.passeye;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            string Firstname = Firstnamebox.Text;
            string Lastname = Lastnamebox.Text;
            string CNIC = CNICbox.Text;
            string Phone = Phonebox.Text;
            Email = Emailbox.Text;
            string Password = Passwordbox.Text;
            char Gender;
            if(Male.Checked == true)
                 Gender = 'M';
            else
                Gender = 'F';
            int count = 0;
            if(!IsAllLetters(Firstname) || string.IsNullOrEmpty(Firstname))
            {
                Firstnamebox.LineIdleColor = Color.Red;
                count++;
            }
            if (!IsAllLetters(Lastname) || string.IsNullOrEmpty(Lastname))
            {
                Lastnamebox.LineIdleColor = Color.Red;
                count++;
            }
            if (!IsAllDigitsanddash(CNIC) || string.IsNullOrEmpty(CNIC))
            {
                CNICbox.LineIdleColor = Color.Red;
                count++;
            }
            if (!IsAllDigits(Phone) || string.IsNullOrEmpty(Phone))
            {
                Phonebox.LineIdleColor = Color.Red;
                count++;
            }
            if (!emailcheck(Email) || string.IsNullOrEmpty(Email))
            {
                Emailbox.LineIdleColor = Color.Red;
                count++;
            }
            if (!IsAllLettersOrDigits(Password) || string.IsNullOrEmpty(Password))
            {
                Passwordbox.LineIdleColor = Color.Red;
                count++;
            }
            else 
            {
                aeroplan_system1.Show();
            }
            
        }

        private void Firstnamebox_OnValueChanged(object sender, EventArgs e)
        {
            Firstnamebox.LineIdleColor = Color.FromArgb(41,39,40);
        }

        private void Lastnamebox_OnValueChanged(object sender, EventArgs e)
        {
            Lastnamebox.LineIdleColor = Color.FromArgb(41, 39, 40);
        }

        private void CNICbox_OnValueChanged(object sender, EventArgs e)
        {
            CNICbox.LineIdleColor = Color.FromArgb(41, 39, 40);
        }

        private void Phonebox_OnValueChanged(object sender, EventArgs e)
        {
            Phonebox.LineIdleColor = Color.FromArgb(41, 39, 40);
        }

        private void Emailbox_OnValueChanged(object sender, EventArgs e)
        {
            Emailbox.LineIdleColor = Color.FromArgb(41, 39, 40);
        }
    }
}
