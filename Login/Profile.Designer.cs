namespace Foodprep.cs
{
    partial class Profile
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
            panel1 = new Panel();
            button2 = new Button();
            btnDashboard = new Button();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            labelUsername = new Label();
            labelEmail = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 743);
            panel1.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.Orange;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(63, 543);
            button2.Name = "button2";
            button2.Size = new Size(167, 61);
            button2.TabIndex = 3;
            button2.Text = "Profile";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Orange;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.System;
            btnDashboard.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.ActiveCaptionText;
            btnDashboard.Location = new Point(63, 340);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(167, 65);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Logo_FoodPrep_removebg_preview;
            pictureBox3.Location = new Point(53, 57);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(177, 173);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Pngtree_avatar_icon_profile_icon_member_5247852;
            pictureBox1.Location = new Point(365, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(366, 291);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(415, 57);
            label1.Name = "label1";
            label1.Size = new Size(246, 48);
            label1.TabIndex = 7;
            label1.Text = "Your Account";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(415, 468);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(164, 38);
            labelUsername.TabIndex = 8;
            labelUsername.Text = "Username :";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(415, 532);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(113, 38);
            labelEmail.TabIndex = 9;
            labelEmail.Text = "Email : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(585, 468);
            label2.Name = "label2";
            label2.Size = new Size(96, 38);
            label2.TabIndex = 10;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(523, 532);
            label3.Name = "label3";
            label3.Size = new Size(96, 38);
            label3.TabIndex = 11;
            label3.Text = "label3";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1383, 743);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelEmail);
            Controls.Add(labelUsername);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Profile";
            Text = "Profile";
            WindowState = FormWindowState.Maximized;
            Load += Profile_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button btnDashboard;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label labelUsername;
        private Label labelEmail;
        private Label label2;
        private Label label3;
    }
}