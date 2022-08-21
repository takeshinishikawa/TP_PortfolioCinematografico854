namespace Portfolio.Presentation
{
    partial class FrmAccount
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
            this.lblContaNameValidation = new System.Windows.Forms.Label();
            this.mtxContaBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.txbContaUserName = new System.Windows.Forms.TextBox();
            this.lblContaUserName = new System.Windows.Forms.Label();
            this.lblContaBirthDate = new System.Windows.Forms.Label();
            this.btnContaVoltar = new System.Windows.Forms.Button();
            this.btnContaSalvar = new System.Windows.Forms.Button();
            this.txbContaName = new System.Windows.Forms.TextBox();
            this.lblContaName = new System.Windows.Forms.Label();
            this.lblContaSubtitle = new System.Windows.Forms.Label();
            this.lblContaTitle = new System.Windows.Forms.Label();
            this.chbContaMostrarSenha = new System.Windows.Forms.CheckBox();
            this.lblContaNewPasswordValidation = new System.Windows.Forms.Label();
            this.lblContaPasswordValidation = new System.Windows.Forms.Label();
            this.txbContaNewPassword = new System.Windows.Forms.TextBox();
            this.lblContaNovaSenha = new System.Windows.Forms.Label();
            this.txbContaCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblContaSenhaAtual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblContaNameValidation
            // 
            this.lblContaNameValidation.AutoSize = true;
            this.lblContaNameValidation.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContaNameValidation.Location = new System.Drawing.Point(456, 270);
            this.lblContaNameValidation.Name = "lblContaNameValidation";
            this.lblContaNameValidation.Size = new System.Drawing.Size(0, 14);
            this.lblContaNameValidation.TabIndex = 44;
            // 
            // mtxContaBirthDate
            // 
            this.mtxContaBirthDate.Enabled = false;
            this.mtxContaBirthDate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxContaBirthDate.Location = new System.Drawing.Point(456, 290);
            this.mtxContaBirthDate.Mask = "00/00/0000";
            this.mtxContaBirthDate.Name = "mtxContaBirthDate";
            this.mtxContaBirthDate.Size = new System.Drawing.Size(120, 27);
            this.mtxContaBirthDate.TabIndex = 1;
            this.mtxContaBirthDate.ValidatingType = typeof(System.DateTime);
            // 
            // txbContaUserName
            // 
            this.txbContaUserName.Enabled = false;
            this.txbContaUserName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbContaUserName.Location = new System.Drawing.Point(456, 340);
            this.txbContaUserName.Name = "txbContaUserName";
            this.txbContaUserName.Size = new System.Drawing.Size(360, 27);
            this.txbContaUserName.TabIndex = 31;
            // 
            // lblContaUserName
            // 
            this.lblContaUserName.AutoSize = true;
            this.lblContaUserName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContaUserName.Location = new System.Drawing.Point(256, 343);
            this.lblContaUserName.Name = "lblContaUserName";
            this.lblContaUserName.Size = new System.Drawing.Size(154, 18);
            this.lblContaUserName.TabIndex = 41;
            this.lblContaUserName.Text = "Nome de usuário:";
            // 
            // lblContaBirthDate
            // 
            this.lblContaBirthDate.AutoSize = true;
            this.lblContaBirthDate.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContaBirthDate.Location = new System.Drawing.Point(256, 293);
            this.lblContaBirthDate.Name = "lblContaBirthDate";
            this.lblContaBirthDate.Size = new System.Drawing.Size(180, 18);
            this.lblContaBirthDate.TabIndex = 40;
            this.lblContaBirthDate.Text = "Data de Nascimento:";
            // 
            // btnContaVoltar
            // 
            this.btnContaVoltar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContaVoltar.Location = new System.Drawing.Point(335, 538);
            this.btnContaVoltar.Name = "btnContaVoltar";
            this.btnContaVoltar.Size = new System.Drawing.Size(150, 45);
            this.btnContaVoltar.TabIndex = 5;
            this.btnContaVoltar.Text = "Voltar";
            this.btnContaVoltar.UseVisualStyleBackColor = true;
            this.btnContaVoltar.Click += new System.EventHandler(this.btnContaVoltar_Click);
            // 
            // btnContaSalvar
            // 
            this.btnContaSalvar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContaSalvar.Location = new System.Drawing.Point(604, 538);
            this.btnContaSalvar.Name = "btnContaSalvar";
            this.btnContaSalvar.Size = new System.Drawing.Size(150, 45);
            this.btnContaSalvar.TabIndex = 4;
            this.btnContaSalvar.Text = "Salvar";
            this.btnContaSalvar.UseVisualStyleBackColor = true;
            this.btnContaSalvar.Click += new System.EventHandler(this.btnContaSalvar_Click);
            // 
            // txbContaName
            // 
            this.txbContaName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbContaName.Location = new System.Drawing.Point(456, 240);
            this.txbContaName.Name = "txbContaName";
            this.txbContaName.Size = new System.Drawing.Size(360, 27);
            this.txbContaName.TabIndex = 0;
            this.txbContaName.TextChanged += new System.EventHandler(this.txbContaName_TextChanged);
            this.txbContaName.Leave += new System.EventHandler(this.txbContaName_Leave);
            // 
            // lblContaName
            // 
            this.lblContaName.AutoSize = true;
            this.lblContaName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContaName.Location = new System.Drawing.Point(256, 243);
            this.lblContaName.Name = "lblContaName";
            this.lblContaName.Size = new System.Drawing.Size(62, 18);
            this.lblContaName.TabIndex = 39;
            this.lblContaName.Text = "Nome:";
            // 
            // lblContaSubtitle
            // 
            this.lblContaSubtitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContaSubtitle.Location = new System.Drawing.Point(116, 152);
            this.lblContaSubtitle.Name = "lblContaSubtitle";
            this.lblContaSubtitle.Size = new System.Drawing.Size(832, 43);
            this.lblContaSubtitle.TabIndex = 38;
            this.lblContaSubtitle.Text = "Subtitle";
            this.lblContaSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContaTitle
            // 
            this.lblContaTitle.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContaTitle.Location = new System.Drawing.Point(116, 97);
            this.lblContaTitle.Name = "lblContaTitle";
            this.lblContaTitle.Size = new System.Drawing.Size(832, 43);
            this.lblContaTitle.TabIndex = 37;
            this.lblContaTitle.Text = "Title";
            this.lblContaTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chbContaMostrarSenha
            // 
            this.chbContaMostrarSenha.AutoSize = true;
            this.chbContaMostrarSenha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbContaMostrarSenha.Location = new System.Drawing.Point(456, 502);
            this.chbContaMostrarSenha.Name = "chbContaMostrarSenha";
            this.chbContaMostrarSenha.Size = new System.Drawing.Size(118, 18);
            this.chbContaMostrarSenha.TabIndex = 3;
            this.chbContaMostrarSenha.Text = "Mostrar Senha";
            this.chbContaMostrarSenha.UseVisualStyleBackColor = true;
            this.chbContaMostrarSenha.CheckedChanged += new System.EventHandler(this.chbContaMostrarSenha_CheckedChanged);
            // 
            // lblContaNewPasswordValidation
            // 
            this.lblContaNewPasswordValidation.AutoSize = true;
            this.lblContaNewPasswordValidation.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContaNewPasswordValidation.Location = new System.Drawing.Point(456, 474);
            this.lblContaNewPasswordValidation.Name = "lblContaNewPasswordValidation";
            this.lblContaNewPasswordValidation.Size = new System.Drawing.Size(0, 14);
            this.lblContaNewPasswordValidation.TabIndex = 51;
            // 
            // lblContaPasswordValidation
            // 
            this.lblContaPasswordValidation.AutoSize = true;
            this.lblContaPasswordValidation.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContaPasswordValidation.Location = new System.Drawing.Point(456, 424);
            this.lblContaPasswordValidation.Name = "lblContaPasswordValidation";
            this.lblContaPasswordValidation.Size = new System.Drawing.Size(0, 14);
            this.lblContaPasswordValidation.TabIndex = 50;
            // 
            // txbContaNewPassword
            // 
            this.txbContaNewPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbContaNewPassword.Location = new System.Drawing.Point(456, 444);
            this.txbContaNewPassword.Name = "txbContaNewPassword";
            this.txbContaNewPassword.Size = new System.Drawing.Size(360, 27);
            this.txbContaNewPassword.TabIndex = 2;
            this.txbContaNewPassword.UseSystemPasswordChar = true;
            this.txbContaNewPassword.TextChanged += new System.EventHandler(this.txbContaNewPassword_TextChanged);
            // 
            // lblContaNovaSenha
            // 
            this.lblContaNovaSenha.AutoSize = true;
            this.lblContaNovaSenha.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContaNovaSenha.Location = new System.Drawing.Point(256, 447);
            this.lblContaNovaSenha.Name = "lblContaNovaSenha";
            this.lblContaNovaSenha.Size = new System.Drawing.Size(109, 18);
            this.lblContaNovaSenha.TabIndex = 49;
            this.lblContaNovaSenha.Text = "Nova senha:";
            // 
            // txbContaCurrentPassword
            // 
            this.txbContaCurrentPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbContaCurrentPassword.Location = new System.Drawing.Point(456, 394);
            this.txbContaCurrentPassword.Name = "txbContaCurrentPassword";
            this.txbContaCurrentPassword.Size = new System.Drawing.Size(360, 27);
            this.txbContaCurrentPassword.TabIndex = 1;
            this.txbContaCurrentPassword.UseSystemPasswordChar = true;
            this.txbContaCurrentPassword.TextChanged += new System.EventHandler(this.txbContaCurrentPassword_TextChanged);
            // 
            // lblContaSenhaAtual
            // 
            this.lblContaSenhaAtual.AutoSize = true;
            this.lblContaSenhaAtual.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContaSenhaAtual.Location = new System.Drawing.Point(256, 397);
            this.lblContaSenhaAtual.Name = "lblContaSenhaAtual";
            this.lblContaSenhaAtual.Size = new System.Drawing.Size(113, 18);
            this.lblContaSenhaAtual.TabIndex = 48;
            this.lblContaSenhaAtual.Text = "Senha atual:";
            // 
            // FrmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.chbContaMostrarSenha);
            this.Controls.Add(this.lblContaNewPasswordValidation);
            this.Controls.Add(this.lblContaPasswordValidation);
            this.Controls.Add(this.txbContaNewPassword);
            this.Controls.Add(this.lblContaNovaSenha);
            this.Controls.Add(this.txbContaCurrentPassword);
            this.Controls.Add(this.lblContaSenhaAtual);
            this.Controls.Add(this.lblContaNameValidation);
            this.Controls.Add(this.mtxContaBirthDate);
            this.Controls.Add(this.txbContaUserName);
            this.Controls.Add(this.lblContaUserName);
            this.Controls.Add(this.lblContaBirthDate);
            this.Controls.Add(this.btnContaVoltar);
            this.Controls.Add(this.btnContaSalvar);
            this.Controls.Add(this.txbContaName);
            this.Controls.Add(this.lblContaName);
            this.Controls.Add(this.lblContaSubtitle);
            this.Controls.Add(this.lblContaTitle);
            this.Name = "FrmAccount";
            this.Text = "Minha Conta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblContaNameValidation;
        private MaskedTextBox mtxContaBirthDate;
        private TextBox txbContaUserName;
        private Label lblContaUserName;
        private Label lblContaBirthDate;
        private Button btnContaVoltar;
        private Button btnContaSalvar;
        private TextBox txbContaName;
        private Label lblContaName;
        private Label lblContaSubtitle;
        private Label lblContaTitle;
        private CheckBox chbContaMostrarSenha;
        private Label lblContaNewPasswordValidation;
        private Label lblContaPasswordValidation;
        private TextBox txbContaNewPassword;
        private Label lblContaNovaSenha;
        private TextBox txbContaCurrentPassword;
        private Label lblContaSenhaAtual;
    }
}