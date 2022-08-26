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
            this.cbbSearchOptions = new System.Windows.Forms.ComboBox();
            this.txbSearchTitle = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lvwMovieBank = new System.Windows.Forms.ListView();
            this.cnTitulo = new System.Windows.Forms.ColumnHeader();
            this.cnYear = new System.Windows.Forms.ColumnHeader();
            this.btnOpen = new System.Windows.Forms.Button();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.cbbStudio = new System.Windows.Forms.ComboBox();
            this.pnlMenuPanel.SuspendLayout();
            this.pnlSubMenu.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPortfolio
            // 
            this.btnPortfolio.BackColor = System.Drawing.Color.Transparent;
            this.btnPortfolio.FlatAppearance.BorderSize = 0;
            this.btnPortfolio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPortfolio.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPortfolio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.btnPortfolio.Location = new System.Drawing.Point(757, 8);
            this.btnPortfolio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPortfolio.Name = "btnPortfolio";
            this.btnPortfolio.Size = new System.Drawing.Size(150, 45);
            this.btnPortfolio.TabIndex = 7;
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
            this.pnlMenuPanel.Location = new System.Drawing.Point(917, 3);
            this.pnlMenuPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlMenuPanel.Name = "pnlMenuPanel";
            this.pnlMenuPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlMenuPanel.Size = new System.Drawing.Size(135, 229);
            this.pnlMenuPanel.TabIndex = 8;
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
            this.btnLogo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogo.Location = new System.Drawing.Point(0, 10);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(135, 35);
            this.btnLogo.TabIndex = 0;
            this.btnLogo.UseVisualStyleBackColor = false;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.btnHome.Location = new System.Drawing.Point(621, 8);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(130, 45);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // cbbSearchOptions
            // 
            this.cbbSearchOptions.BackColor = System.Drawing.SystemColors.Window;
            this.cbbSearchOptions.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbbSearchOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.cbbSearchOptions.FormattingEnabled = true;
            this.cbbSearchOptions.Items.AddRange(new object[] {
            "Título",
            "Gênero",
            "Estúdio"});
            this.cbbSearchOptions.Location = new System.Drawing.Point(188, 172);
            this.cbbSearchOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbSearchOptions.Name = "cbbSearchOptions";
            this.cbbSearchOptions.Size = new System.Drawing.Size(149, 21);
            this.cbbSearchOptions.TabIndex = 0;
            this.cbbSearchOptions.Text = "Opções de Busca";
            this.cbbSearchOptions.SelectedIndexChanged += new System.EventHandler(this.cbbSearchOptions_SelectedIndexChanged);
            // 
            // txbSearchTitle
            // 
            this.txbSearchTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSearchTitle.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSearchTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.txbSearchTitle.Location = new System.Drawing.Point(343, 173);
            this.txbSearchTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSearchTitle.Name = "txbSearchTitle";
            this.txbSearchTitle.Size = new System.Drawing.Size(410, 20);
            this.txbSearchTitle.TabIndex = 1;
            this.txbSearchTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.Ivory;
            this.btnSearch.Location = new System.Drawing.Point(759, 172);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.lvwMovieBank);
            this.pnlSearch.Location = new System.Drawing.Point(186, 205);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(692, 332);
            this.pnlSearch.TabIndex = 5;
            // 
            // lvwMovieBank
            // 
            this.lvwMovieBank.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwMovieBank.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cnTitulo,
            this.cnYear});
            this.lvwMovieBank.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvwMovieBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.lvwMovieBank.FullRowSelect = true;
            this.lvwMovieBank.GridLines = true;
            this.lvwMovieBank.Location = new System.Drawing.Point(20, 15);
            this.lvwMovieBank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwMovieBank.MultiSelect = false;
            this.lvwMovieBank.Name = "lvwMovieBank";
            this.lvwMovieBank.Size = new System.Drawing.Size(652, 301);
            this.lvwMovieBank.TabIndex = 0;
            this.lvwMovieBank.UseCompatibleStateImageBehavior = false;
            this.lvwMovieBank.View = System.Windows.Forms.View.Details;
            // 
            // cnTitulo
            // 
            this.cnTitulo.Text = "Titulo";
            this.cnTitulo.Width = 500;
            // 
            // cnYear
            // 
            this.cnYear.Text = "Ano";
            this.cnYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cnYear.Width = 120;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(183)))), ((int)(((byte)(125)))));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(761, 550);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(117, 35);
            this.btnOpen.TabIndex = 15;
            this.btnOpen.Text = "Abrir";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // ptbLogo
            // 
            this.ptbLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptbLogo.Image = global::Portfolio.Presentation.Properties.Resources.logotipo_do_filme_10250_3708_1_;
            this.ptbLogo.Location = new System.Drawing.Point(12, 8);
            this.ptbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(52, 45);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo.TabIndex = 17;
            this.ptbLogo.TabStop = false;
            // 
            // cbbCategory
            // 
            this.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategory.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(343, 172);
            this.cbbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(410, 21);
            this.cbbCategory.TabIndex = 2;
            this.cbbCategory.Visible = false;
            // 
            // cbbStudio
            // 
            this.cbbStudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStudio.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbStudio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.cbbStudio.FormattingEnabled = true;
            this.cbbStudio.Location = new System.Drawing.Point(343, 172);
            this.cbbStudio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbStudio.Name = "cbbStudio";
            this.cbbStudio.Size = new System.Drawing.Size(410, 21);
            this.cbbStudio.TabIndex = 3;
            this.cbbStudio.Visible = false;
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Portfolio.Presentation.Properties.Resources._4___Home___Portfolio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 663);
            this.Controls.Add(this.cbbStudio);
            this.Controls.Add(this.cbbCategory);
            this.Controls.Add(this.ptbLogo);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbSearchTitle);
            this.Controls.Add(this.cbbSearchOptions);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnPortfolio);
            this.Controls.Add(this.pnlMenuPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSearch";
            this.pnlMenuPanel.ResumeLayout(false);
            this.pnlSubMenu.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ComboBox cbbSearchOptions;
        private TextBox txbSearchTitle;
        private Button btnSearch;
        private Panel pnlSearch;
        private Button btnOpen;
        private PictureBox ptbLogo;
        private ListView lvwMovieBank;
        private ColumnHeader cnTitulo;
        private ColumnHeader cnYear;
        private ComboBox cbbCategory;
        private ComboBox cbbStudio;
    }
}