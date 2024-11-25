namespace Foodprep.cs
{
    partial class DetailResep
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
            pictureBoxRecipe = new PictureBox();
            txtDescription = new TextBox();
            txtSteps = new TextBox();
            labelTitle = new Label();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRecipe).BeginInit();
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
            panel1.Size = new Size(286, 762);
            panel1.TabIndex = 20;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(63, 526);
            button2.Name = "button2";
            button2.Size = new Size(140, 58);
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
            btnDashboard.Location = new Point(63, 322);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(140, 62);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Logo_FoodPrep_removebg_preview;
            pictureBox3.Location = new Point(63, 38);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(154, 158);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBoxRecipe
            // 
            pictureBoxRecipe.Location = new Point(351, 119);
            pictureBoxRecipe.Name = "pictureBoxRecipe";
            pictureBoxRecipe.Size = new Size(265, 177);
            pictureBoxRecipe.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRecipe.TabIndex = 21;
            pictureBoxRecipe.TabStop = false;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.Beige;
            txtDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(351, 365);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(1005, 305);
            txtDescription.TabIndex = 22;
            // 
            // txtSteps
            // 
            txtSteps.BackColor = Color.Beige;
            txtSteps.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSteps.ForeColor = SystemColors.WindowText;
            txtSteps.Location = new Point(655, 162);
            txtSteps.Multiline = true;
            txtSteps.Name = "txtSteps";
            txtSteps.Size = new Size(701, 134);
            txtSteps.TabIndex = 23;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(340, 56);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(110, 45);
            labelTitle.TabIndex = 24;
            labelTitle.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(351, 322);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 25;
            label1.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(655, 119);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 26;
            label2.Text = "Steps";
            label2.Click += label2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(360, 713);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.Yes;
            button3.Size = new Size(112, 37);
            button3.TabIndex = 36;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // DetailResep
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1401, 762);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelTitle);
            Controls.Add(txtSteps);
            Controls.Add(txtDescription);
            Controls.Add(pictureBoxRecipe);
            Controls.Add(panel1);
            Name = "DetailResep";
            Text = "DetailResep";
            WindowState = FormWindowState.Maximized;
            Load += DetailResep_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRecipe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button btnDashboard;
        private PictureBox pictureBox3;
        private PictureBox pictureBoxRecipe;
        private TextBox txtDescription;
        private TextBox txtSteps;
        private Label labelTitle;
        private Label label1;
        private Label label2;
        private Button button3;
    }
}