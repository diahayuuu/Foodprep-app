namespace Foodprep.cs
{
    partial class Resep
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
            label1 = new Label();
            label2 = new Label();
            txtBahan = new TextBox();
            button3 = new Button();
            listBoxResep = new ListBox();
            panel1 = new Panel();
            button2 = new Button();
            btnDashboard = new Button();
            pictureBox3 = new PictureBox();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(316, 71);
            label1.Name = "label1";
            label1.Size = new Size(130, 48);
            label1.TabIndex = 5;
            label1.Text = "Recipe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(316, 132);
            label2.Name = "label2";
            label2.Size = new Size(456, 32);
            label2.TabIndex = 6;
            label2.Text = "Find recipes by entering food ingredients";
            // 
            // txtBahan
            // 
            txtBahan.Location = new Point(316, 209);
            txtBahan.Name = "txtBahan";
            txtBahan.Size = new Size(750, 31);
            txtBahan.TabIndex = 7;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(1101, 203);
            button3.Name = "button3";
            button3.Size = new Size(103, 41);
            button3.TabIndex = 8;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBoxResep
            // 
            listBoxResep.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxResep.FormattingEnabled = true;
            listBoxResep.ItemHeight = 30;
            listBoxResep.Location = new Point(316, 281);
            listBoxResep.Name = "listBoxResep";
            listBoxResep.Size = new Size(888, 334);
            listBoxResep.TabIndex = 9;
            listBoxResep.SelectedIndexChanged += listBoxResep_SelectedIndexChanged_1;
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
            panel1.Size = new Size(266, 724);
            panel1.TabIndex = 10;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(53, 510);
            button2.Name = "button2";
            button2.Size = new Size(144, 57);
            button2.TabIndex = 3;
            button2.Text = "Profile";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Orange;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.ActiveCaptionText;
            btnDashboard.Location = new Point(53, 315);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(144, 60);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Logo_FoodPrep_removebg_preview;
            pictureBox3.Location = new Point(53, 52);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(154, 158);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(316, 662);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.Yes;
            button4.Size = new Size(112, 37);
            button4.TabIndex = 36;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Resep
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1282, 724);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(listBoxResep);
            Controls.Add(button3);
            Controls.Add(txtBahan);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Resep";
            Text = "Recipe";
            WindowState = FormWindowState.Maximized;
            Load += Resep_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox txtBahan;
        private Button button3;
        private ListBox listBoxResep;
        private Panel panel1;
        private Button button2;
        private Button btnDashboard;
        private PictureBox pictureBox3;
        private Button button4;
    }
}