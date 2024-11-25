namespace Foodprep.cs
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnDaftar = new Button();
            label4 = new Label();
            btnLogin = new Button();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnDaftar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(525, 184);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 575);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_FoodPrep_removebg_preview;
            pictureBox1.Location = new Point(64, 219);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 239);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // btnDaftar
            // 
            btnDaftar.FlatAppearance.BorderSize = 0;
            btnDaftar.FlatStyle = FlatStyle.Flat;
            btnDaftar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDaftar.Location = new Point(698, 444);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(118, 49);
            btnDaftar.TabIndex = 16;
            btnDaftar.Text = "Register";
            btnDaftar.UseVisualStyleBackColor = true;
            btnDaftar.Click += btnDaftar_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(386, 452);
            label4.Name = "label4";
            label4.Size = new Size(306, 32);
            label4.TabIndex = 15;
            label4.Text = "Don't have an account yet?";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(512, 363);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(327, 43);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(512, 292);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(327, 39);
            tbPassword.TabIndex = 13;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(512, 219);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(327, 39);
            tbUsername.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(362, 295);
            label3.Name = "label3";
            label3.Size = new Size(122, 32);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(362, 222);
            label2.Name = "label2";
            label2.Size = new Size(128, 32);
            label2.TabIndex = 10;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Beige;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(235, 62);
            label1.Name = "label1";
            label1.Size = new Size(448, 48);
            label1.TabIndex = 9;
            label1.Text = "WELCOME TO FOODPREP";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1547, 838);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnDaftar;
        private Label label4;
        private Button btnLogin;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
