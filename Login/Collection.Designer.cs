namespace Foodprep.cs
{
    partial class Collection
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
            button3 = new Button();
            button2 = new Button();
            btnDashboard = new Button();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 733);
            panel1.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = Color.Orange;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(69, 440);
            button3.Name = "button3";
            button3.Size = new Size(151, 59);
            button3.TabIndex = 5;
            button3.Text = "Collection";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(69, 601);
            button2.Name = "button2";
            button2.Size = new Size(151, 56);
            button2.TabIndex = 3;
            button2.Text = "Profile";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Beige;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.System;
            btnDashboard.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.ActiveCaptionText;
            btnDashboard.Location = new Point(69, 277);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(151, 56);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Logo_FoodPrep_removebg_preview;
            pictureBox3.Location = new Point(51, 39);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(169, 161);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(337, 123);
            button1.Name = "button1";
            button1.Size = new Size(411, 253);
            button1.TabIndex = 4;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 60);
            label1.Name = "label1";
            label1.Size = new Size(215, 38);
            label1.TabIndex = 6;
            label1.Text = "Your Collection";
            // 
            // Collection
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1419, 733);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Collection";
            Text = "Collection";
            WindowState = FormWindowState.Maximized;
            Load += Collection_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Button btnDashboard;
        private PictureBox pictureBox3;
        private Label label1;
        private Button button3;
    }
}