namespace Foodprep.cs
{
    partial class DaftarForm
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
            btnLogin = new Button();
            lblTanya = new Label();
            tbPassword = new TextBox();
            tbEmail = new TextBox();
            tbUsername = new TextBox();
            btnDaftar = new Button();
            lblPassword = new Label();
            lblEmail = new Label();
            lblUsername = new Label();
            label1 = new Label();
            lblRegister = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(lblTanya);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(btnDaftar);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblRegister);
            panel1.Location = new Point(620, 197);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 590);
            panel1.TabIndex = 11;
            // 
            // btnLogin
            // 
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(431, 481);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(104, 41);
            btnLogin.TabIndex = 21;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // lblTanya
            // 
            lblTanya.AutoSize = true;
            lblTanya.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTanya.Location = new Point(138, 490);
            lblTanya.Name = "lblTanya";
            lblTanya.Size = new Size(287, 32);
            lblTanya.TabIndex = 20;
            lblTanya.Text = "Already have an account?\r\n";
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(245, 345);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(316, 39);
            tbPassword.TabIndex = 19;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(245, 291);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(316, 39);
            tbEmail.TabIndex = 18;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(245, 233);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(316, 39);
            tbUsername.TabIndex = 17;
            // 
            // btnDaftar
            // 
            btnDaftar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDaftar.Location = new Point(245, 405);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(316, 44);
            btnDaftar.TabIndex = 16;
            btnDaftar.Text = "Register";
            btnDaftar.UseVisualStyleBackColor = true;
            btnDaftar.Click += btnDaftar_Click_1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(94, 348);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(111, 32);
            lblPassword.TabIndex = 15;
            lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(94, 294);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(71, 32);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Email";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(94, 233);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(121, 32);
            lblUsername.TabIndex = 13;
            lblUsername.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 123);
            label1.Name = "label1";
            label1.Size = new Size(269, 38);
            label1.TabIndex = 12;
            label1.Text = "Create Your Account";
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegister.Location = new Point(223, 39);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(246, 65);
            lblRegister.TabIndex = 11;
            lblRegister.Text = "REGISTER";
            // 
            // DaftarForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1397, 799);
            Controls.Add(panel1);
            Name = "DaftarForm";
            Text = "Daftar";
            WindowState = FormWindowState.Maximized;
            Load += DaftarForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnLogin;
        private Label lblTanya;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private TextBox tbUsername;
        private Button btnDaftar;
        private Label lblPassword;
        private Label lblEmail;
        private Label lblUsername;
        private Label label1;
        private Label lblRegister;
    }
}