namespace Foodprep.cs
{
    partial class Ikan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ikan));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button3 = new Button();
            panel1 = new Panel();
            button1 = new Button();
            btnDashboard = new Button();
            pictureBox3 = new PictureBox();
            buttonSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(280, 45);
            label1.Name = "label1";
            label1.Size = new Size(259, 38);
            label1.TabIndex = 5;
            label1.Text = "How to store Fish?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(280, 95);
            label2.Name = "label2";
            label2.Size = new Size(172, 30);
            label2.TabIndex = 6;
            label2.Text = "1. Clean the fish ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(303, 163);
            label3.Name = "label3";
            label3.Size = new Size(1003, 196);
            label3.TabIndex = 7;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(280, 379);
            label4.Name = "label4";
            label4.Size = new Size(215, 30);
            label4.TabIndex = 8;
            label4.Text = "2. Store fish properly\r\n";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(303, 135);
            label5.Name = "label5";
            label5.Size = new Size(654, 28);
            label5.TabIndex = 9;
            label5.Text = "Prepare tools such as, a spoon or knife with a blunt blade, sharp fillet knife";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(303, 417);
            label6.Name = "label6";
            label6.Size = new Size(1016, 84);
            label6.TabIndex = 10;
            label6.Text = resources.GetString("label6.Text");
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(313, 631);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.Yes;
            button3.Size = new Size(112, 37);
            button3.TabIndex = 27;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 773);
            panel1.TabIndex = 28;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(60, 505);
            button1.Name = "button1";
            button1.Size = new Size(151, 53);
            button1.TabIndex = 4;
            button1.Text = "Profile";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Orange;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.ActiveCaptionText;
            btnDashboard.Location = new Point(60, 301);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(151, 58);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Logo_FoodPrep_removebg_preview;
            pictureBox3.Location = new Point(44, 39);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(160, 158);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSave.Location = new Point(1239, 631);
            buttonSave.Name = "buttonSave";
            buttonSave.RightToLeft = RightToLeft.Yes;
            buttonSave.Size = new Size(112, 37);
            buttonSave.TabIndex = 29;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // Ikan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1486, 773);
            Controls.Add(buttonSave);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ikan";
            Text = "Ikan";
            WindowState = FormWindowState.Maximized;
            Load += Ikan_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button3;
        private Panel panel1;
        private Button button1;
        private Button btnDashboard;
        private PictureBox pictureBox3;
        private Button buttonSave;
    }
}