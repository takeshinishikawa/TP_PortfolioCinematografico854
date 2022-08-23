namespace Portfolio.Presentation
{
    partial class FrmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearch));
            this.btnPortfolio = new System.Windows.Forms.Button();
            this.pnlMenuPanel = new System.Windows.Forms.Panel();
            this.pnlSubMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnMyAccount = new System.Windows.Forms.Button();
            this.btnLogo = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlMenuPanel.SuspendLayout();
            this.pnlSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPortfolio
            // 
            this.btnPortfolio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.btnPortfolio.FlatAppearance.BorderSize = 0;
            this.btnPortfolio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPortfolio.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPortfolio.ForeColor = System.Drawing.Color.Snow;
            this.btnPortfolio.Location = new System.Drawing.Point(757, 17);
            this.btnPortfolio.Name = "btnPortfolio";
            this.btnPortfolio.Size = new System.Drawing.Size(150, 45);
            this.btnPortfolio.TabIndex = 4;
            this.btnPortfolio.Text = "Portfólio";
            this.btnPortfolio.UseVisualStyleBackColor = false;
            this.btnPortfolio.Click += new System.EventHandler(this.btnPortfolio_Click);
            // 
            // pnlMenuPanel
            // 
            this.pnlMenuPanel.AutoScroll = true;
            this.pnlMenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenuPanel.Controls.Add(this.pnlSubMenu);
            this.pnlMenuPanel.Controls.Add(this.btnLogo);
            this.pnlMenuPanel.Location = new System.Drawing.Point(914, 12);
            this.pnlMenuPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlMenuPanel.Name = "pnlMenuPanel";
            this.pnlMenuPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlMenuPanel.Size = new System.Drawing.Size(135, 229);
            this.pnlMenuPanel.TabIndex = 3;
            // 
            // pnlSubMenu
            // 
            this.pnlSubMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlSubMenu.Controls.Add(this.btnExit);
            this.pnlSubMenu.Controls.Add(this.btnAbout);
            this.pnlSubMenu.Controls.Add(this.btnLogOut);
            this.pnlSubMenu.Controls.Add(this.btnMyAccount);
            this.pnlSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenu.Location = new System.Drawing.Point(0, 45);
            this.pnlSubMenu.Name = "pnlSubMenu";
            this.pnlSubMenu.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.pnlSubMenu.Size = new System.Drawing.Size(135, 157);
            this.pnlSubMenu.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnExit.Location = new System.Drawing.Point(0, 112);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(135, 33);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Sair";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAbout.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAbout.Location = new System.Drawing.Point(0, 79);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(135, 33);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "Sobre";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnLogOut.Location = new System.Drawing.Point(0, 46);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(135, 33);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Desconectar";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnMyAccount
            // 
            this.btnMyAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyAccount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMyAccount.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnMyAccount.Location = new System.Drawing.Point(0, 13);
            this.btnMyAccount.Name = "btnMyAccount";
            this.btnMyAccount.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMyAccount.Size = new System.Drawing.Size(135, 33);
            this.btnMyAccount.TabIndex = 0;
            this.btnMyAccount.Text = "Minha Conta";
            this.btnMyAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyAccount.UseVisualStyleBackColor = true;
            this.btnMyAccount.Click += new System.EventHandler(this.btnMyAccount_Click);
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.Transparent;
            this.btnLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogo.BackgroundImage")));
            this.btnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Location = new System.Drawing.Point(0, 10);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(135, 35);
            this.btnLogo.TabIndex = 1;
            this.btnLogo.UseVisualStyleBackColor = false;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.Snow;
            this.btnHome.Location = new System.Drawing.Point(601, 17);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(150, 45);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnPortfolio);
            this.Controls.Add(this.pnlMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSearch";
            this.Text = "FrmSearch";
            this.pnlMenuPanel.ResumeLayout(false);
            this.pnlSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnPortfolio;
        private Panel pnlMenuPanel;
        private Panel pnlSubMenu;
        private Button btnExit;
        private Button btnAbout;
        private Button btnLogOut;
        private Button btnMyAccount;
        private Button btnLogo;
        private Button btnHome;
    }
}