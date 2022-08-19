namespace Portfolio.Presentation
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.pnlMenuPanel = new System.Windows.Forms.Panel();
            this.pnlSubMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnMyAccount = new System.Windows.Forms.Button();
            this.btnLogo = new System.Windows.Forms.Button();
            this.btnPortfolio = new System.Windows.Forms.Button();
            this.btnNewSearch = new System.Windows.Forms.Button();
            this.lblNameOrUsername = new System.Windows.Forms.Label();
            this.pnlPerson = new System.Windows.Forms.Panel();
            this.lblResume = new System.Windows.Forms.Label();
            this.pnlPortfolioMin = new System.Windows.Forms.Panel();
            this.lvwPortfolio = new System.Windows.Forms.ListView();
            this.clnTitle = new System.Windows.Forms.ColumnHeader("(none)");
            this.clnYear = new System.Windows.Forms.ColumnHeader();
            this.clnScore = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMenuPanel.SuspendLayout();
            this.pnlSubMenu.SuspendLayout();
            this.pnlPerson.SuspendLayout();
            this.pnlPortfolioMin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuPanel
            // 
            this.pnlMenuPanel.AutoScroll = true;
            this.pnlMenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenuPanel.Controls.Add(this.pnlSubMenu);
            this.pnlMenuPanel.Controls.Add(this.btnLogo);
            this.pnlMenuPanel.Location = new System.Drawing.Point(1207, 7);
            this.pnlMenuPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlMenuPanel.Name = "pnlMenuPanel";
            this.pnlMenuPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlMenuPanel.Size = new System.Drawing.Size(135, 229);
            this.pnlMenuPanel.TabIndex = 0;
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
            // btnPortfolio
            // 
            this.btnPortfolio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.btnPortfolio.FlatAppearance.BorderSize = 0;
            this.btnPortfolio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPortfolio.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPortfolio.ForeColor = System.Drawing.Color.Snow;
            this.btnPortfolio.Location = new System.Drawing.Point(1051, 7);
            this.btnPortfolio.Name = "btnPortfolio";
            this.btnPortfolio.Size = new System.Drawing.Size(150, 45);
            this.btnPortfolio.TabIndex = 1;
            this.btnPortfolio.Text = "Portfólio";
            this.btnPortfolio.UseVisualStyleBackColor = false;
            this.btnPortfolio.Click += new System.EventHandler(this.btnPortfolio_Click);
            // 
            // btnNewSearch
            // 
            this.btnNewSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.btnNewSearch.FlatAppearance.BorderSize = 0;
            this.btnNewSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSearch.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewSearch.ForeColor = System.Drawing.Color.Snow;
            this.btnNewSearch.Location = new System.Drawing.Point(895, 7);
            this.btnNewSearch.Name = "btnNewSearch";
            this.btnNewSearch.Size = new System.Drawing.Size(150, 45);
            this.btnNewSearch.TabIndex = 2;
            this.btnNewSearch.Text = "Buscar";
            this.btnNewSearch.UseVisualStyleBackColor = false;
            this.btnNewSearch.Click += new System.EventHandler(this.btnNewSearch_Click);
            // 
            // lblNameOrUsername
            // 
            this.lblNameOrUsername.AutoSize = true;
            this.lblNameOrUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblNameOrUsername.Font = new System.Drawing.Font("Georgia", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameOrUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.lblNameOrUsername.Location = new System.Drawing.Point(3, 6);
            this.lblNameOrUsername.Name = "lblNameOrUsername";
            this.lblNameOrUsername.Size = new System.Drawing.Size(268, 48);
            this.lblNameOrUsername.TabIndex = 3;
            this.lblNameOrUsername.Text = "Teatrologa,";
            // 
            // pnlPerson
            // 
            this.pnlPerson.BackColor = System.Drawing.Color.Transparent;
            this.pnlPerson.Controls.Add(this.lblResume);
            this.pnlPerson.Controls.Add(this.lblNameOrUsername);
            this.pnlPerson.Location = new System.Drawing.Point(166, 131);
            this.pnlPerson.Name = "pnlPerson";
            this.pnlPerson.Size = new System.Drawing.Size(1035, 194);
            this.pnlPerson.TabIndex = 5;
            // 
            // lblResume
            // 
            this.lblResume.BackColor = System.Drawing.Color.Transparent;
            this.lblResume.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblResume.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.lblResume.Location = new System.Drawing.Point(3, 73);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(985, 104);
            this.lblResume.TabIndex = 4;
            this.lblResume.Text = resources.GetString("lblResume.Text");
            this.lblResume.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlPortfolioMin
            // 
            this.pnlPortfolioMin.BackColor = System.Drawing.Color.White;
            this.pnlPortfolioMin.Controls.Add(this.lvwPortfolio);
            this.pnlPortfolioMin.Controls.Add(this.label1);
            this.pnlPortfolioMin.Location = new System.Drawing.Point(166, 349);
            this.pnlPortfolioMin.Name = "pnlPortfolioMin";
            this.pnlPortfolioMin.Size = new System.Drawing.Size(1035, 318);
            this.pnlPortfolioMin.TabIndex = 6;
            // 
            // lvwPortfolio
            // 
            this.lvwPortfolio.BackColor = System.Drawing.Color.White;
            this.lvwPortfolio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwPortfolio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnTitle,
            this.clnYear,
            this.clnScore});
            this.lvwPortfolio.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvwPortfolio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.lvwPortfolio.Location = new System.Drawing.Point(82, 117);
            this.lvwPortfolio.Name = "lvwPortfolio";
            this.lvwPortfolio.Size = new System.Drawing.Size(870, 180);
            this.lvwPortfolio.TabIndex = 5;
            this.lvwPortfolio.UseCompatibleStateImageBehavior = false;
            this.lvwPortfolio.View = System.Windows.Forms.View.Details;
            // 
            // clnTitle
            // 
            this.clnTitle.Text = "Título";
            this.clnTitle.Width = 450;
            // 
            // clnYear
            // 
            this.clnYear.Text = "Ano de Lançamento";
            this.clnYear.Width = 220;
            // 
            // clnScore
            // 
            this.clnScore.Text = "Avaliação";
            this.clnScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clnScore.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.label1.Location = new System.Drawing.Point(300, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Top 5 | Melhores Scores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1368, 724);
            this.Controls.Add(this.pnlPortfolioMin);
            this.Controls.Add(this.btnNewSearch);
            this.Controls.Add(this.btnPortfolio);
            this.Controls.Add(this.pnlMenuPanel);
            this.Controls.Add(this.pnlPerson);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmHome";
            this.Text = "FrmHome";
            this.pnlMenuPanel.ResumeLayout(false);
            this.pnlSubMenu.ResumeLayout(false);
            this.pnlPerson.ResumeLayout(false);
            this.pnlPerson.PerformLayout();
            this.pnlPortfolioMin.ResumeLayout(false);
            this.pnlPortfolioMin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlMenuPanel;
        private Panel pnlSubMenu;
        private Button btnMyAccount;
        private Button btnLogo;
        private Button btnLogOut;
        private Button btnExit;
        private Button btnAbout;
        private Button btnPortfolio;
        private Button btnNewSearch;
        private Label lblNameOrUsername;
        private Panel pnlPerson;
        private Panel pnlPortfolioMin;
        private Label lblResume;
        private Label label1;
        private ListView lvwPortfolio;
        private ColumnHeader clnTitle;
        private ColumnHeader clnYear;
        private ColumnHeader clnScore;
    }
}