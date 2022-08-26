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
            this.lklSearchFilter = new System.Windows.Forms.LinkLabel();
            this.lblStandartResume = new System.Windows.Forms.Label();
            this.lblTitleMinPort = new System.Windows.Forms.Label();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.lvwPortfolioTop = new System.Windows.Forms.ListView();
            this.cnTitle = new System.Windows.Forms.ColumnHeader();
            this.cnScore = new System.Windows.Forms.ColumnHeader();
            this.lblPercentResume = new System.Windows.Forms.Label();
            this.lblSpacer = new System.Windows.Forms.Label();
            this.pnlEmptyUser = new System.Windows.Forms.Panel();
            this.lklLinkToReview = new System.Windows.Forms.LinkLabel();
            this.lblEmptyUsername = new System.Windows.Forms.Label();
            this.lblEmptyResume = new System.Windows.Forms.Label();
            this.pnlMenuPanel.SuspendLayout();
            this.pnlSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.pnlHome.SuspendLayout();
            this.pnlEmptyUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuPanel
            // 
            this.pnlMenuPanel.AutoScroll = true;
            this.pnlMenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenuPanel.Controls.Add(this.pnlSubMenu);
            this.pnlMenuPanel.Controls.Add(this.btnLogo);
            this.pnlMenuPanel.Location = new System.Drawing.Point(917, 3);
            this.pnlMenuPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlMenuPanel.Name = "pnlMenuPanel";
            this.pnlMenuPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlMenuPanel.Size = new System.Drawing.Size(135, 229);
            this.pnlMenuPanel.TabIndex = 2;
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
            this.pnlSubMenu.TabIndex = 1;
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
            this.btnExit.TabIndex = 3;
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
            this.btnAbout.TabIndex = 2;
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
            this.btnLogOut.TabIndex = 1;
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
            this.btnLogo.TabIndex = 0;
            this.btnLogo.UseVisualStyleBackColor = false;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // btnPortfolio
            // 
            this.btnPortfolio.BackColor = System.Drawing.Color.Transparent;
            this.btnPortfolio.FlatAppearance.BorderSize = 0;
            this.btnPortfolio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPortfolio.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPortfolio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.btnPortfolio.Location = new System.Drawing.Point(757, 8);
            this.btnPortfolio.Name = "btnPortfolio";
            this.btnPortfolio.Size = new System.Drawing.Size(150, 45);
            this.btnPortfolio.TabIndex = 1;
            this.btnPortfolio.Text = "Portfólio";
            this.btnPortfolio.UseVisualStyleBackColor = false;
            this.btnPortfolio.Click += new System.EventHandler(this.btnPortfolio_Click);
            // 
            // btnNewSearch
            // 
            this.btnNewSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnNewSearch.FlatAppearance.BorderSize = 0;
            this.btnNewSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSearch.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.btnNewSearch.Location = new System.Drawing.Point(618, 8);
            this.btnNewSearch.Name = "btnNewSearch";
            this.btnNewSearch.Size = new System.Drawing.Size(133, 45);
            this.btnNewSearch.TabIndex = 0;
            this.btnNewSearch.Text = "Buscar";
            this.btnNewSearch.UseVisualStyleBackColor = false;
            this.btnNewSearch.Click += new System.EventHandler(this.btnNewSearch_Click);
            // 
            // lblNameOrUsername
            // 
            this.lblNameOrUsername.AutoSize = true;
            this.lblNameOrUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblNameOrUsername.Font = new System.Drawing.Font("Georgia", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameOrUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.lblNameOrUsername.Location = new System.Drawing.Point(34, 20);
            this.lblNameOrUsername.Name = "lblNameOrUsername";
            this.lblNameOrUsername.Size = new System.Drawing.Size(192, 35);
            this.lblNameOrUsername.TabIndex = 0;
            this.lblNameOrUsername.Text = "Teatrologa,";
            this.lblNameOrUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lklSearchFilter
            // 
            this.lklSearchFilter.AutoSize = true;
            this.lklSearchFilter.DisabledLinkColor = System.Drawing.Color.OrangeRed;
            this.lklSearchFilter.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lklSearchFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(183)))), ((int)(((byte)(125)))));
            this.lklSearchFilter.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(129)))), ((int)(((byte)(134)))));
            this.lklSearchFilter.Location = new System.Drawing.Point(34, 217);
            this.lklSearchFilter.Name = "lklSearchFilter";
            this.lklSearchFilter.Size = new System.Drawing.Size(478, 16);
            this.lklSearchFilter.TabIndex = 3;
            this.lklSearchFilter.TabStop = true;
            this.lklSearchFilter.Text = "Vamos começar? Descubra quais filmes estão disponíveis clicando aqui.";
            this.lklSearchFilter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklSearchFilter_LinkClicked);
            // 
            // lblStandartResume
            // 
            this.lblStandartResume.AutoSize = true;
            this.lblStandartResume.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStandartResume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.lblStandartResume.Location = new System.Drawing.Point(34, 70);
            this.lblStandartResume.MaximumSize = new System.Drawing.Size(685, 60);
            this.lblStandartResume.Name = "lblStandartResume";
            this.lblStandartResume.Size = new System.Drawing.Size(121, 18);
            this.lblStandartResume.TabIndex = 1;
            this.lblStandartResume.Text = "ResumoPadrao";
            // 
            // lblTitleMinPort
            // 
            this.lblTitleMinPort.AutoSize = true;
            this.lblTitleMinPort.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleMinPort.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleMinPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.lblTitleMinPort.Location = new System.Drawing.Point(34, 262);
            this.lblTitleMinPort.Name = "lblTitleMinPort";
            this.lblTitleMinPort.Size = new System.Drawing.Size(245, 29);
            this.lblTitleMinPort.TabIndex = 4;
            this.lblTitleMinPort.Text = "Ultimas Avaliações";
            // 
            // ptbLogo
            // 
            this.ptbLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbLogo.Image = global::Portfolio.Presentation.Properties.Resources.logotipo_do_filme_10250_3708_1_;
            this.ptbLogo.Location = new System.Drawing.Point(12, 8);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(52, 45);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo.TabIndex = 7;
            this.ptbLogo.TabStop = false;
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.Transparent;
            this.pnlHome.Controls.Add(this.lvwPortfolioTop);
            this.pnlHome.Controls.Add(this.lblPercentResume);
            this.pnlHome.Controls.Add(this.lklSearchFilter);
            this.pnlHome.Controls.Add(this.lblNameOrUsername);
            this.pnlHome.Controls.Add(this.lblStandartResume);
            this.pnlHome.Controls.Add(this.lblTitleMinPort);
            this.pnlHome.Controls.Add(this.lblSpacer);
            this.pnlHome.Enabled = false;
            this.pnlHome.Location = new System.Drawing.Point(155, 136);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(752, 488);
            this.pnlHome.TabIndex = 4;
            this.pnlHome.Visible = false;
            // 
            // lvwPortfolioTop
            // 
            this.lvwPortfolioTop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwPortfolioTop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cnTitle,
            this.cnScore});
            this.lvwPortfolioTop.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvwPortfolioTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.lvwPortfolioTop.GridLines = true;
            this.lvwPortfolioTop.Location = new System.Drawing.Point(45, 309);
            this.lvwPortfolioTop.Name = "lvwPortfolioTop";
            this.lvwPortfolioTop.Size = new System.Drawing.Size(663, 136);
            this.lvwPortfolioTop.TabIndex = 1;
            this.lvwPortfolioTop.UseCompatibleStateImageBehavior = false;
            this.lvwPortfolioTop.View = System.Windows.Forms.View.Details;
            // 
            // cnTitle
            // 
            this.cnTitle.Text = "Título do Filme";
            this.cnTitle.Width = 450;
            // 
            // cnScore
            // 
            this.cnScore.Text = "Nota";
            this.cnScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cnScore.Width = 150;
            // 
            // lblPercentResume
            // 
            this.lblPercentResume.AutoSize = true;
            this.lblPercentResume.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPercentResume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.lblPercentResume.Location = new System.Drawing.Point(34, 130);
            this.lblPercentResume.MaximumSize = new System.Drawing.Size(685, 100);
            this.lblPercentResume.Name = "lblPercentResume";
            this.lblPercentResume.Size = new System.Drawing.Size(297, 18);
            this.lblPercentResume.TabIndex = 5;
            this.lblPercentResume.Text = "Resumo dependendo do tanto de filme";
            // 
            // lblSpacer
            // 
            this.lblSpacer.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSpacer.Location = new System.Drawing.Point(43, 233);
            this.lblSpacer.Name = "lblSpacer";
            this.lblSpacer.Size = new System.Drawing.Size(666, 25);
            this.lblSpacer.TabIndex = 6;
            this.lblSpacer.Text = "___________________________________________________________________\r\n";
            this.lblSpacer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlEmptyUser
            // 
            this.pnlEmptyUser.BackColor = System.Drawing.Color.Transparent;
            this.pnlEmptyUser.Controls.Add(this.lklLinkToReview);
            this.pnlEmptyUser.Controls.Add(this.lblEmptyUsername);
            this.pnlEmptyUser.Controls.Add(this.lblEmptyResume);
            this.pnlEmptyUser.Enabled = false;
            this.pnlEmptyUser.Location = new System.Drawing.Point(155, 169);
            this.pnlEmptyUser.Name = "pnlEmptyUser";
            this.pnlEmptyUser.Size = new System.Drawing.Size(752, 334);
            this.pnlEmptyUser.TabIndex = 0;
            this.pnlEmptyUser.Visible = false;
            // 
            // lklLinkToReview
            // 
            this.lklLinkToReview.AutoSize = true;
            this.lklLinkToReview.DisabledLinkColor = System.Drawing.Color.OrangeRed;
            this.lklLinkToReview.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lklLinkToReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(183)))), ((int)(((byte)(125)))));
            this.lklLinkToReview.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(129)))), ((int)(((byte)(134)))));
            this.lklLinkToReview.Location = new System.Drawing.Point(71, 288);
            this.lklLinkToReview.Name = "lklLinkToReview";
            this.lklLinkToReview.Size = new System.Drawing.Size(600, 18);
            this.lklLinkToReview.TabIndex = 0;
            this.lklLinkToReview.TabStop = true;
            this.lklLinkToReview.Text = "Vamos começar? Descubra quais filmes estão disponíveis clicando aqui.";
            this.lklLinkToReview.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklSearchFilter_LinkClicked);
            // 
            // lblEmptyUsername
            // 
            this.lblEmptyUsername.AutoSize = true;
            this.lblEmptyUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblEmptyUsername.Font = new System.Drawing.Font("Georgia", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmptyUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.lblEmptyUsername.Location = new System.Drawing.Point(34, 47);
            this.lblEmptyUsername.Name = "lblEmptyUsername";
            this.lblEmptyUsername.Size = new System.Drawing.Size(192, 35);
            this.lblEmptyUsername.TabIndex = 6;
            this.lblEmptyUsername.Text = "Teatrologa,";
            this.lblEmptyUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmptyResume
            // 
            this.lblEmptyResume.AutoSize = true;
            this.lblEmptyResume.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmptyResume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.lblEmptyResume.Location = new System.Drawing.Point(34, 103);
            this.lblEmptyResume.MaximumSize = new System.Drawing.Size(687, 200);
            this.lblEmptyResume.Name = "lblEmptyResume";
            this.lblEmptyResume.Size = new System.Drawing.Size(102, 18);
            this.lblEmptyResume.TabIndex = 7;
            this.lblEmptyResume.Text = "Mini Resumo";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = global::Portfolio.Presentation.Properties.Resources._4___Home___Portfolio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.pnlEmptyUser);
            this.Controls.Add(this.ptbLogo);
            this.Controls.Add(this.btnNewSearch);
            this.Controls.Add(this.btnPortfolio);
            this.Controls.Add(this.pnlMenuPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHome";
            this.pnlMenuPanel.ResumeLayout(false);
            this.pnlSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.pnlEmptyUser.ResumeLayout(false);
            this.pnlEmptyUser.PerformLayout();
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
        private Label lblTitleMinPort;
        private Label lblStandartResume;
        private PictureBox ptbLogo;
        private LinkLabel lklSearchFilter;
        private Panel pnlHome;
        private Label lblSpacer;
        private Panel pnlEmptyUser;
        private LinkLabel lklLinkToReview;
        private Label lblEmptyUsername;
        private Label lblEmptyResume;
        private Label lblPercentResume;
        private ListView lvwPortfolioTop;
        private ColumnHeader cnTitle;
        private ColumnHeader cnScore;
    }
}