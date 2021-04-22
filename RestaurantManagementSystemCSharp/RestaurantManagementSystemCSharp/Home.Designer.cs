namespace RestaurantManagementSystemCSharp
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.reservationToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.itemsToolStripMenuItem.Text = "Items";
            this.itemsToolStripMenuItem.Click += new System.EventHandler(this.itemsToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.reservationToolStripMenuItem.Text = "Reservation";
            this.reservationToolStripMenuItem.Click += new System.EventHandler(this.reservationToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RestaurantManagementSystemCSharp.Properties.Resources.kashipara;
            this.pictureBox1.Location = new System.Drawing.Point(506, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}