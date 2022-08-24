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
            this.lklSearchFilter = new System.Windows.Forms.LinkLabel();
            this.lblResume = new System.Windows.Forms.Label();
            this.pnlPortfolioMin = new System.Windows.Forms.Panel();
            this.lblMovieScorePort = new System.Windows.Forms.Label();
            this.lblMovieTitlePor = new System.Windows.Forms.Label();
            this.lblLatestMoviesScore = new System.Windows.Forms.Label();
            this.lblLatestMoviesTitle = new System.Windows.Forms.Label();
            this.lblTitleMinPort = new System.Windows.Forms.Label();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.pnlMenuPanel.SuspendLayout();
            this.pnlSubMenu.SuspendLayout();
            this.pnlPerson.SuspendLayout();
            this.pnlPortfolioMin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuPanel
            // 
            this.pnlMenuPanel.AutoScroll = true;
            this.pnlMenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenuPanel.Controls.Add(this.pnlSubMenu);
            this.pnlMenuPanel.Controls.Add(this.btnLogo);
            this.pnlMenuPanel.Location = new System.Drawing.Point(914, 3);
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
            // btnPortfolio
            // 
            this.btnPortfolio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.btnPortfolio.FlatAppearance.BorderSize = 0;
            this.btnPortfolio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPortfolio.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPortfolio.ForeColor = System.Drawing.Color.Snow;
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
            this.btnNewSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.btnNewSearch.FlatAppearance.BorderSize = 0;
            this.btnNewSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSearch.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewSearch.ForeColor = System.Drawing.Color.Snow;
            this.btnNewSearch.Location = new System.Drawing.Point(601, 8);
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
            this.lblNameOrUsername.Font = new System.Drawing.Font("Georgia", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameOrUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.lblNameOrUsername.Location = new System.Drawing.Point(27, 19);
            this.lblNameOrUsername.Name = "lblNameOrUsername";
            this.lblNameOrUsername.Size = new System.Drawing.Size(192, 35);
            this.lblNameOrUsername.TabIndex = 3;
            this.lblNameOrUsername.Text = "Teatrologa,";
            // 
            // pnlPerson
            // 
            this.pnlPerson.BackColor = System.Drawing.Color.Ivory;
            this.pnlPerson.Controls.Add(this.lklSearchFilter);
            this.pnlPerson.Controls.Add(this.lblResume);
            this.pnlPerson.Controls.Add(this.lblNameOrUsername);
            this.pnlPerson.Location = new System.Drawing.Point(156, 119);
            this.pnlPerson.Name = "pnlPerson";
            this.pnlPerson.Size = new System.Drawing.Size(750, 226);
            this.pnlPerson.TabIndex = 5;
            // 
            // lklSearchFilter
            // 
            this.lklSearchFilter.AutoSize = true;
            this.lklSearchFilter.DisabledLinkColor = System.Drawing.Color.OrangeRed;
            this.lklSearchFilter.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lklSearchFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(183)))), ((int)(((byte)(125)))));
            this.lklSearchFilter.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(129)))), ((int)(((byte)(134)))));
            this.lklSearchFilter.Location = new System.Drawing.Point(29, 183);
            this.lklSearchFilter.Name = "lklSearchFilter";
            this.lklSearchFilter.Size = new System.Drawing.Size(22, 13);
            this.lklSearchFilter.TabIndex = 5;
            this.lklSearchFilter.TabStop = true;
            this.lklSearchFilter.Text = "---";
            // 
            // lblResume
            // 
            this.lblResume.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.lblResume.Location = new System.Drawing.Point(27, 83);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(696, 98);
            this.lblResume.TabIndex = 4;
            this.lblResume.Text = "Mini Resumo";
            // 
            // pnlPortfolioMin
            // 
            this.pnlPortfolioMin.BackColor = System.Drawing.Color.Ivory;
            this.pnlPortfolioMin.Controls.Add(this.lblMovieScorePort);
            this.pnlPortfolioMin.Controls.Add(this.lblMovieTitlePor);
            this.pnlPortfolioMin.Controls.Add(this.lblLatestMoviesScore);
            this.pnlPortfolioMin.Controls.Add(this.lblLatestMoviesTitle);
            this.pnlPortfolioMin.Controls.Add(this.lblTitleMinPort);
            this.pnlPortfolioMin.Location = new System.Drawing.Point(156, 341);
            this.pnlPortfolioMin.Name = "pnlPortfolioMin";
            this.pnlPortfolioMin.Size = new System.Drawing.Size(750, 259);
            this.pnlPortfolioMin.TabIndex = 6;
            // 
            // lblMovieScorePort
            // 
            this.lblMovieScorePort.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMovieScorePort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.lblMovieScorePort.Location = new System.Drawing.Point(598, 73);
            this.lblMovieScorePort.Name = "lblMovieScorePort";
            this.lblMovieScorePort.Size = new System.Drawing.Size(125, 27);
            this.lblMovieScorePort.TabIndex = 10;
            this.lblMovieScorePort.Text = "Nota ";
            this.lblMovieScorePort.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMovieTitlePor
            // 
            this.lblMovieTitlePor.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMovieTitlePor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.lblMovieTitlePor.Location = new System.Drawing.Point(27, 73);
            this.lblMovieTitlePor.Name = "lblMovieTitlePor";
            this.lblMovieTitlePor.Size = new System.Drawing.Size(191, 27);
            this.lblMovieTitlePor.TabIndex = 9;
            this.lblMovieTitlePor.Text = "Título do filme";
            // 
            // lblLatestMoviesScore
            // 
            this.lblLatestMoviesScore.BackColor = System.Drawing.Color.Transparent;
            this.lblLatestMoviesScore.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLatestMoviesScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(183)))), ((int)(((byte)(125)))));
            this.lblLatestMoviesScore.Location = new System.Drawing.Point(598, 115);
            this.lblLatestMoviesScore.Name = "lblLatestMoviesScore";
            this.lblLatestMoviesScore.Size = new System.Drawing.Size(125, 121);
            this.lblLatestMoviesScore.TabIndex = 8;
            this.lblLatestMoviesScore.Text = "★★★☆☆\r\n★★★☆☆\r\n★★★☆☆\r\n★★★☆☆\r\n★★★☆☆";
            this.lblLatestMoviesScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLatestMoviesTitle
            // 
            this.lblLatestMoviesTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblLatestMoviesTitle.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLatestMoviesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(183)))), ((int)(((byte)(125)))));
            this.lblLatestMoviesTitle.Location = new System.Drawing.Point(27, 115);
            this.lblLatestMoviesTitle.Name = "lblLatestMoviesTitle";
            this.lblLatestMoviesTitle.Size = new System.Drawing.Size(506, 121);
            this.lblLatestMoviesTitle.TabIndex = 7;
            this.lblLatestMoviesTitle.Text = "Titulo 1:\r\nTitulo 2:\r\nTitulo 3:\r\nTitulo 4:\r\nTitulo 5:";
            // 
            // lblTitleMinPort
            // 
            this.lblTitleMinPort.AutoSize = true;
            this.lblTitleMinPort.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleMinPort.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleMinPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.lblTitleMinPort.Location = new System.Drawing.Point(27, 0);
            this.lblTitleMinPort.Name = "lblTitleMinPort";
            this.lblTitleMinPort.Size = new System.Drawing.Size(245, 29);
            this.lblTitleMinPort.TabIndex = 6;
            this.lblTitleMinPort.Text = "Ultimas Avaliações";
            // 
            // ptbLogo
            // 
            this.ptbLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptbLogo.Image = global::Portfolio.Presentation.Properties.Resources.logotipo_do_filme_10250_3708_1_;
            this.ptbLogo.Location = new System.Drawing.Point(12, 8);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(43, 43);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 7;
            this.ptbLogo.TabStop = false;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.ptbLogo);
            this.Controls.Add(this.pnlPortfolioMin);
            this.Controls.Add(this.btnNewSearch);
            this.Controls.Add(this.btnPortfolio);
            this.Controls.Add(this.pnlMenuPanel);
            this.Controls.Add(this.pnlPerson);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHome";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.pnlMenuPanel.ResumeLayout(false);
            this.pnlSubMenu.ResumeLayout(false);
            this.pnlPerson.ResumeLayout(false);
            this.pnlPerson.PerformLayout();
            this.pnlPortfolioMin.ResumeLayout(false);
            this.pnlPortfolioMin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
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
        private Label lblTitleMinPort;
        private Label lblResume;
        private Label lblLatestMoviesScore;
        private Label lblLatestMoviesTitle;
        private Label lblMovieTitlePor;
        private Label lblMovieScorePort;
        private PictureBox ptbLogo;
        private LinkLabel lklSearchFilter;
    }
}