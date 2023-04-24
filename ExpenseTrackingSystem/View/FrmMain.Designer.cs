namespace ExpenseTrackingSystem.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.PagePanel = new System.Windows.Forms.Panel();
            this.brdForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.SidePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlExpense = new System.Windows.Forms.Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.expensesPageBtn = new System.Windows.Forms.Button();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.dashboardPageBtn = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pageLogoutBtn = new System.Windows.Forms.Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.SidePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PagePanel.Location = new System.Drawing.Point(62, 81);
            this.PagePanel.Name = "PagePanel";
            this.PagePanel.Padding = new System.Windows.Forms.Padding(2);
            this.PagePanel.Size = new System.Drawing.Size(1016, 545);
            this.PagePanel.TabIndex = 3;
            // 
            // brdForm
            // 
            this.brdForm.AnimateWindow = true;
            this.brdForm.ContainerControl = this;
            this.brdForm.DockIndicatorTransparencyValue = 0.6D;
            this.brdForm.TransparentWhileDrag = true;
            // 
            // SidePanel
            // 
            this.SidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SidePanel.BackColor = System.Drawing.Color.Transparent;
            this.SidePanel.BorderRadius = 1;
            this.SidePanel.Controls.Add(this.panel1);
            this.SidePanel.Controls.Add(this.MenuPanel);
            this.SidePanel.FillColor = System.Drawing.Color.Transparent;
            this.SidePanel.Location = new System.Drawing.Point(1084, 230);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(207, 396);
            this.SidePanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.guna2Separator3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 126);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlExpense);
            this.panel3.Controls.Add(this.guna2Separator1);
            this.panel3.Controls.Add(this.expensesPageBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 57);
            this.panel3.TabIndex = 14;
            // 
            // pnlExpense
            // 
            this.pnlExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(246)))), ((int)(((byte)(198)))));
            this.pnlExpense.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlExpense.Location = new System.Drawing.Point(0, 0);
            this.pnlExpense.Name = "pnlExpense";
            this.pnlExpense.Size = new System.Drawing.Size(10, 57);
            this.pnlExpense.TabIndex = 12;
            this.pnlExpense.Visible = false;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(246)))), ((int)(((byte)(198)))));
            this.guna2Separator1.Location = new System.Drawing.Point(2, 51);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(204, 10);
            this.guna2Separator1.TabIndex = 0;
            // 
            // expensesPageBtn
            // 
            this.expensesPageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expensesPageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expensesPageBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(246)))), ((int)(((byte)(198)))));
            this.expensesPageBtn.FlatAppearance.BorderSize = 0;
            this.expensesPageBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(69)))));
            this.expensesPageBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(69)))));
            this.expensesPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expensesPageBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expensesPageBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(246)))), ((int)(((byte)(198)))));
            this.expensesPageBtn.Image = global::ExpenseTrackingSystem.Properties.Resources.icons8_money_32;
            this.expensesPageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expensesPageBtn.Location = new System.Drawing.Point(0, 0);
            this.expensesPageBtn.Name = "expensesPageBtn";
            this.expensesPageBtn.Padding = new System.Windows.Forms.Padding(12, 0, 18, 0);
            this.expensesPageBtn.Size = new System.Drawing.Size(204, 61);
            this.expensesPageBtn.TabIndex = 11;
            this.expensesPageBtn.Text = "Expenses";
            this.expensesPageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.expensesPageBtn.UseVisualStyleBackColor = true;
            this.expensesPageBtn.Click += new System.EventHandler(this.ExpensesPageBtn_Click);
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(246)))), ((int)(((byte)(198)))));
            this.guna2Separator3.Location = new System.Drawing.Point(0, 57);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(207, 10);
            this.guna2Separator3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlDashboard);
            this.panel2.Controls.Add(this.dashboardPageBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 57);
            this.panel2.TabIndex = 0;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(246)))), ((int)(((byte)(198)))));
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(10, 57);
            this.pnlDashboard.TabIndex = 7;
            this.pnlDashboard.Visible = false;
            // 
            // dashboardPageBtn
            // 
            this.dashboardPageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboardPageBtn.BackColor = System.Drawing.Color.Black;
            this.dashboardPageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardPageBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(246)))), ((int)(((byte)(198)))));
            this.dashboardPageBtn.FlatAppearance.BorderSize = 0;
            this.dashboardPageBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(69)))));
            this.dashboardPageBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(69)))));
            this.dashboardPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardPageBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardPageBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(246)))), ((int)(((byte)(198)))));
            this.dashboardPageBtn.Image = global::ExpenseTrackingSystem.Properties.Resources.icons8_combo_chart_32;
            this.dashboardPageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardPageBtn.Location = new System.Drawing.Point(0, 0);
            this.dashboardPageBtn.Name = "dashboardPageBtn";
            this.dashboardPageBtn.Padding = new System.Windows.Forms.Padding(12, 0, 18, 0);
            this.dashboardPageBtn.Size = new System.Drawing.Size(204, 57);
            this.dashboardPageBtn.TabIndex = 10;
            this.dashboardPageBtn.Text = "Dashboard";
            this.dashboardPageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dashboardPageBtn.UseVisualStyleBackColor = false;
            this.dashboardPageBtn.Click += new System.EventHandler(this.DashboardPageBtn_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.MenuPanel.Controls.Add(this.guna2Separator4);
            this.MenuPanel.Controls.Add(this.panel6);
            this.MenuPanel.Location = new System.Drawing.Point(0, 127);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(204, 262);
            this.MenuPanel.TabIndex = 5;
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Separator4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(246)))), ((int)(((byte)(198)))));
            this.guna2Separator4.Location = new System.Drawing.Point(0, 195);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(204, 10);
            this.guna2Separator4.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pageLogoutBtn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 205);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(204, 57);
            this.panel6.TabIndex = 15;
            // 
            // pageLogoutBtn
            // 
            this.pageLogoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageLogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pageLogoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pageLogoutBtn.FlatAppearance.BorderSize = 0;
            this.pageLogoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(69)))));
            this.pageLogoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(69)))));
            this.pageLogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageLogoutBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageLogoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(246)))), ((int)(((byte)(198)))));
            this.pageLogoutBtn.Image = global::ExpenseTrackingSystem.Properties.Resources.icons8_logout_rounded_left_32;
            this.pageLogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pageLogoutBtn.Location = new System.Drawing.Point(0, 1);
            this.pageLogoutBtn.Name = "pageLogoutBtn";
            this.pageLogoutBtn.Padding = new System.Windows.Forms.Padding(12, 0, 18, 0);
            this.pageLogoutBtn.Size = new System.Drawing.Size(204, 63);
            this.pageLogoutBtn.TabIndex = 7;
            this.pageLogoutBtn.Text = "Logout";
            this.pageLogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pageLogoutBtn.UseVisualStyleBackColor = true;
            this.pageLogoutBtn.Click += new System.EventHandler(this.PageLogoutBtn_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.Controls.Add(this.guna2Panel1);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel2.Location = new System.Drawing.Point(1084, 94);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(207, 130);
            this.guna2Panel2.TabIndex = 8;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 18;
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.FillColor = System.Drawing.Color.Black;
            this.guna2Panel1.Location = new System.Drawing.Point(8, 35);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(191, 59);
            this.guna2Panel1.TabIndex = 7;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(246)))), ((int)(((byte)(198)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(87, 18);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(123, 32);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Username";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CirclePictureBox1.Image = global::ExpenseTrackingSystem.Properties.Resources.icons8_male_user_64;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(12, 11);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(50, 37);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(246)))), ((int)(((byte)(198)))));
            this.guna2Separator2.Location = new System.Drawing.Point(1081, 230);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(207, 10);
            this.guna2Separator2.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1251, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 31);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1295, 653);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.PagePanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.SidePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PagePanel;
        private Guna.UI2.WinForms.Guna2BorderlessForm brdForm;
        private Guna.UI2.WinForms.Guna2Panel SidePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Button dashboardPageBtn;
        private System.Windows.Forms.Panel MenuPanel;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button expensesPageBtn;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button pageLogoutBtn;
        private System.Windows.Forms.Panel pnlExpense;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}