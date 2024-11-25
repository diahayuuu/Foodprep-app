namespace Foodprep.cs
{
    partial class Sayur
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
            label1 = new Label();
            label2 = new Label();
            txtVegetables = new TextBox();
            btnSearch = new Button();
            dataGridViewVegetables = new DataGridView();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVegetables).BeginInit();
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
            panel1.Size = new Size(266, 712);
            panel1.TabIndex = 18;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(51, 509);
            button2.Name = "button2";
            button2.Size = new Size(154, 56);
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
            btnDashboard.Location = new Point(51, 321);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(154, 58);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Logo_FoodPrep_removebg_preview;
            pictureBox3.Location = new Point(51, 50);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(154, 158);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(306, 66);
            label1.Name = "label1";
            label1.Size = new Size(307, 45);
            label1.TabIndex = 19;
            label1.Text = "Vegetables Storage";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(316, 131);
            label2.Name = "label2";
            label2.Size = new Size(643, 30);
            label2.TabIndex = 20;
            label2.Text = "Search for the name of the vegetable and find out how to store it";
            // 
            // txtVegetables
            // 
            txtVegetables.Location = new Point(316, 216);
            txtVegetables.Name = "txtVegetables";
            txtVegetables.Size = new Size(403, 31);
            txtVegetables.TabIndex = 21;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(769, 213);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridViewVegetables
            // 
            dataGridViewVegetables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVegetables.Location = new Point(316, 283);
            dataGridViewVegetables.Name = "dataGridViewVegetables";
            dataGridViewVegetables.RowHeadersWidth = 62;
            dataGridViewVegetables.Size = new Size(970, 306);
            dataGridViewVegetables.TabIndex = 23;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(316, 623);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.Yes;
            button3.Size = new Size(112, 37);
            button3.TabIndex = 24;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Sayur
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1362, 712);
            Controls.Add(button3);
            Controls.Add(dataGridViewVegetables);
            Controls.Add(btnSearch);
            Controls.Add(txtVegetables);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Sayur";
            Text = "Sayur";
            WindowState = FormWindowState.Maximized;
            Load += Sayur_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVegetables).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button btnDashboard;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private TextBox txtVegetables;
        private Button btnSearch;
        private DataGridView dataGridViewVegetables;
        private Button button3;
    }
}