namespace ExpenseTrackingSystem
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.tmrLoginAttempts = new System.Windows.Forms.Timer(this.components);
            this.brdForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbShowPassword = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cmdMinimise = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmdLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cmdRegister = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrLoginAttempts
            // 
            this.tmrLoginAttempts.Interval = 1000;
            // 
            // brdForm
            // 
            this.brdForm.AnimateWindow = true;
            this.brdForm.AnimationInterval = 400;
            this.brdForm.BorderRadius = 40;
            this.brdForm.ContainerControl = this;
            this.brdForm.DockIndicatorTransparencyValue = 0.6D;
            this.brdForm.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Aqua;
            this.guna2Panel1.BorderRadius = 25;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.cbShowPassword);
            this.guna2Panel1.Controls.Add(this.cmdMinimise);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.txtPassword);
            this.guna2Panel1.Controls.Add(this.txtUsername);
            this.guna2Panel1.Controls.Add(this.cmdLogin);
            this.guna2Panel1.Controls.Add(this.cmdRegister);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.btnExit);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1718, 940);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Guna2Panel1_Paint);
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.cbShowPassword.CheckedState.BorderRadius = 2;
            this.cbShowPassword.CheckedState.BorderThickness = 0;
            this.cbShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.cbShowPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowPassword.ForeColor = System.Drawing.Color.Aqua;
            this.cbShowPassword.Location = new System.Drawing.Point(651, 429);
            this.cbShowPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(188, 27);
            this.cbShowPassword.TabIndex = 14;
            this.cbShowPassword.Text = "Show Password";
            this.cbShowPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbShowPassword.UncheckedState.BorderRadius = 2;
            this.cbShowPassword.UncheckedState.BorderThickness = 0;
            this.cbShowPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbShowPassword.UseVisualStyleBackColor = true;
            // 
            // cmdMinimise
            // 
            this.cmdMinimise.BackColor = System.Drawing.Color.Transparent;
            this.cmdMinimise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdMinimise.FlatAppearance.BorderSize = 0;
            this.cmdMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMinimise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMinimise.ForeColor = System.Drawing.Color.Aqua;
            this.cmdMinimise.Location = new System.Drawing.Point(1599, 18);
            this.cmdMinimise.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdMinimise.Name = "cmdMinimise";
            this.cmdMinimise.Size = new System.Drawing.Size(45, 46);
            this.cmdMinimise.TabIndex = 19;
            this.cmdMinimise.Text = "➖";
            this.cmdMinimise.UseVisualStyleBackColor = false;
            this.cmdMinimise.Visible = false;
            this.cmdMinimise.Click += new System.EventHandler(this.CmdMinimise_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(629, 668);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 36);
            this.label3.TabIndex = 16;
            this.label3.Text = "Do not have an account?";
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderColor = System.Drawing.Color.Aqua;
            this.txtPassword.BorderRadius = 15;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.Transparent;
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPassword.FocusedState.ForeColor = System.Drawing.Color.Aqua;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.ForeColor = System.Drawing.Color.Aqua;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPassword.HoverState.ForeColor = System.Drawing.Color.Aqua;
            this.txtPassword.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPassword.Location = new System.Drawing.Point(634, 334);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Aqua;
            this.txtPassword.PlaceholderText = "Enter password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(448, 55);
            this.txtPassword.TabIndex = 13;
            // 
            // txtUsername
            // 
            this.txtUsername.Animated = true;
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderColor = System.Drawing.Color.Aqua;
            this.txtUsername.BorderRadius = 15;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FillColor = System.Drawing.Color.Transparent;
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUsername.FocusedState.ForeColor = System.Drawing.Color.Aqua;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.ForeColor = System.Drawing.Color.Aqua;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUsername.HoverState.ForeColor = System.Drawing.Color.Aqua;
            this.txtUsername.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUsername.Location = new System.Drawing.Point(634, 223);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.Aqua;
            this.txtUsername.PlaceholderText = "Enter username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(448, 55);
            this.txtUsername.TabIndex = 12;
            // 
            // cmdLogin
            // 
            this.cmdLogin.BorderRadius = 10;
            this.cmdLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdLogin.FillColor = System.Drawing.Color.Aqua;
            this.cmdLogin.FillColor2 = System.Drawing.Color.Aqua;
            this.cmdLogin.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.ForeColor = System.Drawing.Color.Black;
            this.cmdLogin.Location = new System.Drawing.Point(723, 535);
            this.cmdLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(270, 69);
            this.cmdLogin.TabIndex = 15;
            this.cmdLogin.Text = "Login";
            this.cmdLogin.Click += new System.EventHandler(this.CmdLogin_Click);
            // 
            // cmdRegister
            // 
            this.cmdRegister.BackColor = System.Drawing.Color.Transparent;
            this.cmdRegister.BorderColor = System.Drawing.Color.Transparent;
            this.cmdRegister.BorderRadius = 10;
            this.cmdRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRegister.FillColor = System.Drawing.Color.Black;
            this.cmdRegister.FillColor2 = System.Drawing.Color.Black;
            this.cmdRegister.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegister.ForeColor = System.Drawing.Color.Aqua;
            this.cmdRegister.Location = new System.Drawing.Point(944, 654);
            this.cmdRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdRegister.Name = "cmdRegister";
            this.cmdRegister.Size = new System.Drawing.Size(138, 69);
            this.cmdRegister.TabIndex = 17;
            this.cmdRegister.Text = "Register";
            this.cmdRegister.Click += new System.EventHandler(this.CmdRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(658, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 66);
            this.label1.TabIndex = 18;
            this.label1.Text = "ACCOUNT LOGIN";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Aqua;
            this.btnExit.Location = new System.Drawing.Point(1653, 18);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 46);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "✖";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1718, 940);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrLoginAttempts;
        private Guna.UI2.WinForms.Guna2BorderlessForm brdForm;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CheckBox cbShowPassword;
        private System.Windows.Forms.Button cmdMinimise;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2GradientButton cmdLogin;
        private Guna.UI2.WinForms.Guna2GradientButton cmdRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}

