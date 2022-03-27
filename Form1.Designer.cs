namespace Air_line_Managment_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.slidepanel = new System.Windows.Forms.Panel();
            this.Airlines = new System.Windows.Forms.Button();
            this.Booking = new System.Windows.Forms.Button();
            this.Offers = new System.Windows.Forms.Button();
            this.Contact = new System.Windows.Forms.Button();
            this.Home2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.employee1 = new Air_line_Managment_System.Employee();
            this.contactus1 = new Air_line_Managment_System.Contactus();
            this.booking1 = new Air_line_Managment_System.Booking();
            this.offers1 = new Air_line_Managment_System.Offers();
            this.home1 = new Air_line_Managment_System.Home();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mini = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.twitter = new System.Windows.Forms.Button();
            this.fb = new System.Windows.Forms.Button();
            this.inta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Panel1.Controls.Add(this.slidepanel);
            this.Panel1.Controls.Add(this.Airlines);
            this.Panel1.Controls.Add(this.Booking);
            this.Panel1.Controls.Add(this.Offers);
            this.Panel1.Controls.Add(this.Contact);
            this.Panel1.Controls.Add(this.Home2);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(183, 598);
            this.Panel1.TabIndex = 0;
            // 
            // slidepanel
            // 
            this.slidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.slidepanel.Location = new System.Drawing.Point(0, 145);
            this.slidepanel.Name = "slidepanel";
            this.slidepanel.Size = new System.Drawing.Size(10, 59);
            this.slidepanel.TabIndex = 3;
            // 
            // Airlines
            // 
            this.Airlines.FlatAppearance.BorderSize = 0;
            this.Airlines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Airlines.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Airlines.ForeColor = System.Drawing.Color.White;
            this.Airlines.Image = ((System.Drawing.Image)(resources.GetObject("Airlines.Image")));
            this.Airlines.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Airlines.Location = new System.Drawing.Point(12, 340);
            this.Airlines.Name = "Airlines";
            this.Airlines.Size = new System.Drawing.Size(171, 59);
            this.Airlines.TabIndex = 7;
            this.Airlines.Text = "      Employee";
            this.Airlines.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Airlines.UseVisualStyleBackColor = true;
            this.Airlines.Click += new System.EventHandler(this.Airlines_Click);
            // 
            // Booking
            // 
            this.Booking.FlatAppearance.BorderSize = 0;
            this.Booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Booking.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booking.ForeColor = System.Drawing.Color.White;
            this.Booking.Image = ((System.Drawing.Image)(resources.GetObject("Booking.Image")));
            this.Booking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Booking.Location = new System.Drawing.Point(12, 275);
            this.Booking.Name = "Booking";
            this.Booking.Size = new System.Drawing.Size(171, 59);
            this.Booking.TabIndex = 6;
            this.Booking.Text = "      Booking";
            this.Booking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Booking.UseVisualStyleBackColor = true;
            this.Booking.Click += new System.EventHandler(this.Booking_Click);
            // 
            // Offers
            // 
            this.Offers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.Offers.FlatAppearance.BorderSize = 0;
            this.Offers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Offers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Offers.ForeColor = System.Drawing.Color.White;
            this.Offers.Image = ((System.Drawing.Image)(resources.GetObject("Offers.Image")));
            this.Offers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Offers.Location = new System.Drawing.Point(12, 210);
            this.Offers.Name = "Offers";
            this.Offers.Size = new System.Drawing.Size(171, 59);
            this.Offers.TabIndex = 4;
            this.Offers.Text = "      Offers";
            this.Offers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Offers.UseVisualStyleBackColor = true;
            this.Offers.Click += new System.EventHandler(this.Offers_Click);
            // 
            // Contact
            // 
            this.Contact.FlatAppearance.BorderSize = 0;
            this.Contact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Contact.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.ForeColor = System.Drawing.Color.White;
            this.Contact.Image = ((System.Drawing.Image)(resources.GetObject("Contact.Image")));
            this.Contact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Contact.Location = new System.Drawing.Point(12, 405);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(171, 59);
            this.Contact.TabIndex = 5;
            this.Contact.Text = "      Contact Us";
            this.Contact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Contact.UseVisualStyleBackColor = true;
            this.Contact.Click += new System.EventHandler(this.Contact_Click);
            // 
            // Home2
            // 
            this.Home2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.Home2.FlatAppearance.BorderSize = 0;
            this.Home2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home2.ForeColor = System.Drawing.Color.White;
            this.Home2.Image = ((System.Drawing.Image)(resources.GetObject("Home2.Image")));
            this.Home2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home2.Location = new System.Drawing.Point(12, 145);
            this.Home2.Name = "Home2";
            this.Home2.Size = new System.Drawing.Size(171, 59);
            this.Home2.TabIndex = 3;
            this.Home2.Text = "      Home";
            this.Home2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home2.UseVisualStyleBackColor = true;
            this.Home2.Click += new System.EventHandler(this.Home2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(183, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 10);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Have A Safe Journey";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.employee1);
            this.panel3.Controls.Add(this.contactus1);
            this.panel3.Controls.Add(this.booking1);
            this.panel3.Controls.Add(this.offers1);
            this.panel3.Controls.Add(this.home1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(183, 166);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(854, 432);
            this.panel3.TabIndex = 9;
            // 
            // employee1
            // 
            this.employee1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee1.Location = new System.Drawing.Point(0, 5);
            this.employee1.Margin = new System.Windows.Forms.Padding(5);
            this.employee1.Name = "employee1";
            this.employee1.Size = new System.Drawing.Size(854, 432);
            this.employee1.TabIndex = 4;
            // 
            // contactus1
            // 
            this.contactus1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactus1.Location = new System.Drawing.Point(-5, -6);
            this.contactus1.Margin = new System.Windows.Forms.Padding(5);
            this.contactus1.Name = "contactus1";
            this.contactus1.Size = new System.Drawing.Size(854, 432);
            this.contactus1.TabIndex = 3;
            // 
            // booking1
            // 
            this.booking1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booking1.Location = new System.Drawing.Point(0, 0);
            this.booking1.Margin = new System.Windows.Forms.Padding(5);
            this.booking1.Name = "booking1";
            this.booking1.Size = new System.Drawing.Size(854, 432);
            this.booking1.TabIndex = 2;
            // 
            // offers1
            // 
            this.offers1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offers1.Location = new System.Drawing.Point(0, 0);
            this.offers1.Name = "offers1";
            this.offers1.Size = new System.Drawing.Size(854, 432);
            this.offers1.TabIndex = 1;
            // 
            // home1
            // 
            this.home1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(854, 432);
            this.home1.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // mini
            // 
            this.mini.FlatAppearance.BorderSize = 0;
            this.mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mini.Image = ((System.Drawing.Image)(resources.GetObject("mini.Image")));
            this.mini.Location = new System.Drawing.Point(956, 26);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(27, 27);
            this.mini.TabIndex = 7;
            this.mini.UseVisualStyleBackColor = true;
            this.mini.Click += new System.EventHandler(this.mini_Click);
            // 
            // exit
            // 
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(989, 26);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(30, 27);
            this.exit.TabIndex = 6;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // twitter
            // 
            this.twitter.FlatAppearance.BorderSize = 0;
            this.twitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twitter.Image = ((System.Drawing.Image)(resources.GetObject("twitter.Image")));
            this.twitter.Location = new System.Drawing.Point(386, 125);
            this.twitter.Name = "twitter";
            this.twitter.Size = new System.Drawing.Size(28, 27);
            this.twitter.TabIndex = 5;
            this.twitter.UseVisualStyleBackColor = true;
            this.twitter.Click += new System.EventHandler(this.twitter_Click);
            // 
            // fb
            // 
            this.fb.FlatAppearance.BorderSize = 0;
            this.fb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fb.Image = ((System.Drawing.Image)(resources.GetObject("fb.Image")));
            this.fb.Location = new System.Drawing.Point(386, 59);
            this.fb.Name = "fb";
            this.fb.Size = new System.Drawing.Size(28, 27);
            this.fb.TabIndex = 4;
            this.fb.UseVisualStyleBackColor = true;
            this.fb.Click += new System.EventHandler(this.fb_Click);
            // 
            // inta
            // 
            this.inta.FlatAppearance.BorderSize = 0;
            this.inta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inta.Image = ((System.Drawing.Image)(resources.GetObject("inta.Image")));
            this.inta.Location = new System.Drawing.Point(386, 92);
            this.inta.Name = "inta";
            this.inta.Size = new System.Drawing.Size(28, 27);
            this.inta.TabIndex = 3;
            this.inta.UseVisualStyleBackColor = true;
            this.inta.Click += new System.EventHandler(this.inta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(239, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1037, 598);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mini);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.twitter);
            this.Controls.Add(this.fb);
            this.Controls.Add(this.inta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel slidepanel;
        private System.Windows.Forms.Button Booking;
        private System.Windows.Forms.Button Offers;
        private System.Windows.Forms.Button Contact;
        private System.Windows.Forms.Button Home2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button inta;
        private System.Windows.Forms.Button fb;
        private System.Windows.Forms.Button twitter;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button mini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Home home1;
        private Contactus contactus1;
        private Booking booking1;
        private Offers offers1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Airlines;
        private Employee employee1;

    }
}

