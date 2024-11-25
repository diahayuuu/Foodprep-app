namespace Foodprep.cs
{
    partial class Buah
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
            txtFruits = new TextBox();
            btnSearch = new Button();
            dataGridViewFruits = new DataGridView();
            panel1 = new Panel();
            button2 = new Button();
            btnDashboard = new Button();
            pictureBox3 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFruits).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(376, 69);
            label1.Name = "label1";
            label1.Size = new Size(215, 45);
            label1.TabIndex = 10;
            label1.Text = "Fruit Storage";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(376, 131);
            label2.Name = "label2";
            label2.Size = new Size(654, 32);
            label2.TabIndex = 11;
            label2.Text = "Search for the name of the fruit and find out how to store it";
            // 
            // txtFruits
            // 
            txtFruits.Location = new Point(376, 210);
            txtFruits.Name = "txtFruits";
            txtFruits.Size = new Size(403, 31);
            txtFruits.TabIndex = 13;
            txtFruits.TextChanged += txtFruits_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(830, 201);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(116, 47);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridViewFruits
            // 
            dataGridViewFruits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFruits.Location = new Point(376, 276);
            dataGridViewFruits.Name = "dataGridViewFruits";
            dataGridViewFruits.RowHeadersWidth = 62;
            dataGridViewFruits.Size = new Size(970, 306);
            dataGridViewFruits.TabIndex = 16;
            dataGridViewFruits.CellContentClick += dataGridViewFruits_CellContentClick;
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
            panel1.Size = new Size(295, 727);
            panel1.TabIndex = 17;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(72, 523);
            button2.Name = "button2";
            button2.Size = new Size(143, 59);
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
            btnDashboard.Location = new Point(72, 316);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(143, 63);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Logo_FoodPrep_removebg_preview;
            pictureBox3.Location = new Point(72, 40);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(154, 158);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(376, 616);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.Yes;
            button3.Size = new Size(112, 37);
            button3.TabIndex = 25;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Buah
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1365, 727);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(dataGridViewFruits);
            Controls.Add(btnSearch);
            Controls.Add(txtFruits);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Buah";
            Text = "Buah";
            WindowState = FormWindowState.Maximized;
            Load += Buah_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFruits).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox txtFruits;
        private ListBox listBoxFruits;
        private Button btnSearch;
        private DataGridView dataGridViewFruits;
        private Panel panel1;
        private Button button2;
        private Button btnDashboard;
        private PictureBox pictureBox3;
        private Button button3;
    }
}