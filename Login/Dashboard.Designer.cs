namespace Foodprep.cs
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            button2 = new Button();
            btnDashboard = new Button();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btnPenyimpanan = new Button();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            btnResep = new Button();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel1.Size = new Size(298, 709);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(79, 529);
            button2.Name = "button2";
            button2.Size = new Size(138, 55);
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
            btnDashboard.Location = new Point(79, 332);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(138, 58);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Logo_FoodPrep_removebg_preview;
            pictureBox3.Location = new Point(63, 49);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(154, 158);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(376, 83);
            label1.Name = "label1";
            label1.Size = new Size(318, 54);
            label1.TabIndex = 2;
            label1.Text = "Hello, Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(376, 162);
            label2.Name = "label2";
            label2.Size = new Size(849, 45);
            label2.TabIndex = 3;
            label2.Text = "Store food ingredients properly and cook more deliciously";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LemonChiffon;
            panel2.Controls.Add(btnPenyimpanan);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(392, 286);
            panel2.Name = "panel2";
            panel2.Size = new Size(277, 298);
            panel2.TabIndex = 4;
            // 
            // btnPenyimpanan
            // 
            btnPenyimpanan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPenyimpanan.Location = new Point(52, 217);
            btnPenyimpanan.Name = "btnPenyimpanan";
            btnPenyimpanan.Size = new Size(170, 45);
            btnPenyimpanan.TabIndex = 1;
            btnPenyimpanan.Text = "Storage";
            btnPenyimpanan.UseVisualStyleBackColor = true;
            btnPenyimpanan.Click += btnPenyimpanan_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.remove;
            pictureBox1.Location = new Point(34, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LemonChiffon;
            panel3.Controls.Add(btnResep);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(732, 286);
            panel3.Name = "panel3";
            panel3.Size = new Size(295, 298);
            panel3.TabIndex = 5;
            // 
            // btnResep
            // 
            btnResep.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResep.Location = new Point(82, 217);
            btnResep.Name = "btnResep";
            btnResep.Size = new Size(139, 45);
            btnResep.TabIndex = 1;
            btnResep.Text = "Recipe";
            btnResep.UseVisualStyleBackColor = true;
            btnResep.Click += btnResep_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(44, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(211, 167);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1323, 709);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "S";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button btnPenyimpanan;
        private Panel panel3;
        private Button btnResep;
        private PictureBox pictureBox2;
        private Button button2;
        private Button btnDashboard;
    }
}