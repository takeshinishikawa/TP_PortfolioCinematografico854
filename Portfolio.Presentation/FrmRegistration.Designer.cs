namespace Portfolio.Presentation
{
    partial class FrmRegistration
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
            this.txbCadastroName = new System.Windows.Forms.TextBox();
            this.lblCadastroName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitleCadastro = new System.Windows.Forms.Label();
            this.btnCadastroEnviar = new System.Windows.Forms.Button();
            this.btnCadastroVoltar = new System.Windows.Forms.Button();
            this.lblCadastroBirthDate = new System.Windows.Forms.Label();
            this.txbCadastroUserName = new System.Windows.Forms.TextBox();
            this.lblCadastroUserName = new System.Windows.Forms.Label();
            this.txbCadastroTypePassword = new System.Windows.Forms.TextBox();
            this.lblCadastroTypePassword = new System.Windows.Forms.Label();
            this.mtxBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.txbCadastroConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblCadastroConfirmPassword = new System.Windows.Forms.Label();
            this.lblCadastroNameValidation = new System.Windows.Forms.Label();
            this.lblCadastroBirthDateValidation = new System.Windows.Forms.Label();
            this.lblCadastroUserNameValidation = new System.Windows.Forms.Label();
            this.lblCadastroPasswordValidation = new System.Windows.Forms.Label();
            this.lblCadastroPasswordConfirmValidation = new System.Windows.Forms.Label();
            this.chbCadastroMostrarSenha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txbCadastroName
            // 
            this.txbCadastroName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCadastroName.Location = new System.Drawing.Point(456, 215);
            this.txbCadastroName.Name = "txbCadastroName";
            this.txbCadastroName.Size = new System.Drawing.Size(360, 27);
            this.txbCadastroName.TabIndex = 0;
            this.txbCadastroName.TextChanged += new System.EventHandler(this.txbCadastroName_TextChanged);
            this.txbCadastroName.Leave += new System.EventHandler(this.txbCadastroName_Leave);
            // 
            // lblCadastroName
            // 
            this.lblCadastroName.AutoSize = true;
            this.lblCadastroName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroName.Location = new System.Drawing.Point(256, 218);
            this.lblCadastroName.Name = "lblCadastroName";
            this.lblCadastroName.Size = new System.Drawing.Size(62, 18);
            this.lblCadastroName.TabIndex = 10;
            this.lblCadastroName.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(116, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(832, 43);
            this.label2.TabIndex = 9;
            this.label2.Text = " Aproveite as vantagens de ser um usuário do Portfólio Cinematográfico!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleCadastro
            // 
            this.lblTitleCadastro.AutoSize = true;
            this.lblTitleCadastro.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleCadastro.Location = new System.Drawing.Point(406, 72);
            this.lblTitleCadastro.Name = "lblTitleCadastro";
            this.lblTitleCadastro.Size = new System.Drawing.Size(252, 25);
            this.lblTitleCadastro.TabIndex = 8;
            this.lblTitleCadastro.Text = "Faça agora o seu cadastro";
            // 
            // btnCadastroEnviar
            // 
            this.btnCadastroEnviar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastroEnviar.Location = new System.Drawing.Point(604, 513);
            this.btnCadastroEnviar.Name = "btnCadastroEnviar";
            this.btnCadastroEnviar.Size = new System.Drawing.Size(150, 45);
            this.btnCadastroEnviar.TabIndex = 6;
            this.btnCadastroEnviar.Text = "Enviar";
            this.btnCadastroEnviar.UseVisualStyleBackColor = true;
            this.btnCadastroEnviar.Click += new System.EventHandler(this.btnCadastroEnviar_Click);
            // 
            // btnCadastroVoltar
            // 
            this.btnCadastroVoltar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastroVoltar.Location = new System.Drawing.Point(335, 513);
            this.btnCadastroVoltar.Name = "btnCadastroVoltar";
            this.btnCadastroVoltar.Size = new System.Drawing.Size(150, 45);
            this.btnCadastroVoltar.TabIndex = 7;
            this.btnCadastroVoltar.Text = "Voltar";
            this.btnCadastroVoltar.UseVisualStyleBackColor = true;
            this.btnCadastroVoltar.Click += new System.EventHandler(this.btnCadastroVoltar_Click);
            // 
            // lblCadastroBirthDate
            // 
            this.lblCadastroBirthDate.AutoSize = true;
            this.lblCadastroBirthDate.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroBirthDate.Location = new System.Drawing.Point(256, 268);
            this.lblCadastroBirthDate.Name = "lblCadastroBirthDate";
            this.lblCadastroBirthDate.Size = new System.Drawing.Size(180, 18);
            this.lblCadastroBirthDate.TabIndex = 14;
            this.lblCadastroBirthDate.Text = "Data de Nascimento:";
            // 
            // txbCadastroUserName
            // 
            this.txbCadastroUserName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCadastroUserName.Location = new System.Drawing.Point(456, 315);
            this.txbCadastroUserName.Name = "txbCadastroUserName";
            this.txbCadastroUserName.Size = new System.Drawing.Size(360, 27);
            this.txbCadastroUserName.TabIndex = 2;
            this.txbCadastroUserName.TextChanged += new System.EventHandler(this.txbCadastroUserName_TextChanged);
            // 
            // lblCadastroUserName
            // 
            this.lblCadastroUserName.AutoSize = true;
            this.lblCadastroUserName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroUserName.Location = new System.Drawing.Point(256, 318);
            this.lblCadastroUserName.Name = "lblCadastroUserName";
            this.lblCadastroUserName.Size = new System.Drawing.Size(154, 18);
            this.lblCadastroUserName.TabIndex = 16;
            this.lblCadastroUserName.Text = "Nome de usuário:";
            // 
            // txbCadastroTypePassword
            // 
            this.txbCadastroTypePassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCadastroTypePassword.Location = new System.Drawing.Point(456, 365);
            this.txbCadastroTypePassword.Name = "txbCadastroTypePassword";
            this.txbCadastroTypePassword.Size = new System.Drawing.Size(360, 27);
            this.txbCadastroTypePassword.TabIndex = 3;
            this.txbCadastroTypePassword.UseSystemPasswordChar = true;
            this.txbCadastroTypePassword.TextChanged += new System.EventHandler(this.txbCadastroTypePassword_TextChanged);
            // 
            // lblCadastroTypePassword
            // 
            this.lblCadastroTypePassword.AutoSize = true;
            this.lblCadastroTypePassword.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroTypePassword.Location = new System.Drawing.Point(256, 368);
            this.lblCadastroTypePassword.Name = "lblCadastroTypePassword";
            this.lblCadastroTypePassword.Size = new System.Drawing.Size(149, 18);
            this.lblCadastroTypePassword.TabIndex = 18;
            this.lblCadastroTypePassword.Text = "Digite sua senha:";
            // 
            // mtxBirthDate
            // 
            this.mtxBirthDate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxBirthDate.Location = new System.Drawing.Point(456, 265);
            this.mtxBirthDate.Mask = "00/00/0000";
            this.mtxBirthDate.Name = "mtxBirthDate";
            this.mtxBirthDate.Size = new System.Drawing.Size(120, 27);
            this.mtxBirthDate.TabIndex = 1;
            this.mtxBirthDate.ValidatingType = typeof(System.DateTime);
            this.mtxBirthDate.TextChanged += new System.EventHandler(this.mtxBirthDate_TextChanged);
            this.mtxBirthDate.Leave += new System.EventHandler(this.mtxBirthDate_Leave);
            // 
            // txbCadastroConfirmPassword
            // 
            this.txbCadastroConfirmPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCadastroConfirmPassword.Location = new System.Drawing.Point(456, 415);
            this.txbCadastroConfirmPassword.Name = "txbCadastroConfirmPassword";
            this.txbCadastroConfirmPassword.Size = new System.Drawing.Size(360, 27);
            this.txbCadastroConfirmPassword.TabIndex = 4;
            this.txbCadastroConfirmPassword.UseSystemPasswordChar = true;
            this.txbCadastroConfirmPassword.TextChanged += new System.EventHandler(this.txbCadastroConfirmPassword_TextChanged);
            // 
            // lblCadastroConfirmPassword
            // 
            this.lblCadastroConfirmPassword.AutoSize = true;
            this.lblCadastroConfirmPassword.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroConfirmPassword.Location = new System.Drawing.Point(256, 418);
            this.lblCadastroConfirmPassword.Name = "lblCadastroConfirmPassword";
            this.lblCadastroConfirmPassword.Size = new System.Drawing.Size(177, 18);
            this.lblCadastroConfirmPassword.TabIndex = 22;
            this.lblCadastroConfirmPassword.Text = "Confirme sua senha:";
            // 
            // lblCadastroNameValidation
            // 
            this.lblCadastroNameValidation.AutoSize = true;
            this.lblCadastroNameValidation.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroNameValidation.Location = new System.Drawing.Point(456, 245);
            this.lblCadastroNameValidation.Name = "lblCadastroNameValidation";
            this.lblCadastroNameValidation.Size = new System.Drawing.Size(0, 14);
            this.lblCadastroNameValidation.TabIndex = 24;
            // 
            // lblCadastroBirthDateValidation
            // 
            this.lblCadastroBirthDateValidation.AutoSize = true;
            this.lblCadastroBirthDateValidation.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroBirthDateValidation.Location = new System.Drawing.Point(456, 295);
            this.lblCadastroBirthDateValidation.Name = "lblCadastroBirthDateValidation";
            this.lblCadastroBirthDateValidation.Size = new System.Drawing.Size(0, 14);
            this.lblCadastroBirthDateValidation.TabIndex = 25;
            // 
            // lblCadastroUserNameValidation
            // 
            this.lblCadastroUserNameValidation.AutoSize = true;
            this.lblCadastroUserNameValidation.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroUserNameValidation.Location = new System.Drawing.Point(456, 345);
            this.lblCadastroUserNameValidation.Name = "lblCadastroUserNameValidation";
            this.lblCadastroUserNameValidation.Size = new System.Drawing.Size(0, 14);
            this.lblCadastroUserNameValidation.TabIndex = 26;
            // 
            // lblCadastroPasswordValidation
            // 
            this.lblCadastroPasswordValidation.AutoSize = true;
            this.lblCadastroPasswordValidation.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroPasswordValidation.Location = new System.Drawing.Point(456, 395);
            this.lblCadastroPasswordValidation.Name = "lblCadastroPasswordValidation";
            this.lblCadastroPasswordValidation.Size = new System.Drawing.Size(0, 14);
            this.lblCadastroPasswordValidation.TabIndex = 27;
            // 
            // lblCadastroPasswordConfirmValidation
            // 
            this.lblCadastroPasswordConfirmValidation.AutoSize = true;
            this.lblCadastroPasswordConfirmValidation.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroPasswordConfirmValidation.Location = new System.Drawing.Point(456, 445);
            this.lblCadastroPasswordConfirmValidation.Name = "lblCadastroPasswordConfirmValidation";
            this.lblCadastroPasswordConfirmValidation.Size = new System.Drawing.Size(0, 14);
            this.lblCadastroPasswordConfirmValidation.TabIndex = 28;
            // 
            // chbCadastroMostrarSenha
            // 
            this.chbCadastroMostrarSenha.AutoSize = true;
            this.chbCadastroMostrarSenha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbCadastroMostrarSenha.Location = new System.Drawing.Point(456, 472);
            this.chbCadastroMostrarSenha.Name = "chbCadastroMostrarSenha";
            this.chbCadastroMostrarSenha.Size = new System.Drawing.Size(118, 18);
            this.chbCadastroMostrarSenha.TabIndex = 5;
            this.chbCadastroMostrarSenha.Text = "Mostrar Senha";
            this.chbCadastroMostrarSenha.UseVisualStyleBackColor = true;
            this.chbCadastroMostrarSenha.CheckedChanged += new System.EventHandler(this.chbCadastroMostrarSenha_CheckedChanged);
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.chbCadastroMostrarSenha);
            this.Controls.Add(this.lblCadastroPasswordConfirmValidation);
            this.Controls.Add(this.lblCadastroPasswordValidation);
            this.Controls.Add(this.lblCadastroUserNameValidation);
            this.Controls.Add(this.lblCadastroBirthDateValidation);
            this.Controls.Add(this.lblCadastroNameValidation);
            this.Controls.Add(this.txbCadastroConfirmPassword);
            this.Controls.Add(this.lblCadastroConfirmPassword);
            this.Controls.Add(this.mtxBirthDate);
            this.Controls.Add(this.txbCadastroTypePassword);
            this.Controls.Add(this.lblCadastroTypePassword);
            this.Controls.Add(this.txbCadastroUserName);
            this.Controls.Add(this.lblCadastroUserName);
            this.Controls.Add(this.lblCadastroBirthDate);
            this.Controls.Add(this.btnCadastroVoltar);
            this.Controls.Add(this.btnCadastroEnviar);
            this.Controls.Add(this.txbCadastroName);
            this.Controls.Add(this.lblCadastroName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitleCadastro);
            this.Name = "FrmRegistration";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbCadastroName;
        private Label lblCadastroName;
        private Label label2;
        private Label lblTitleCadastro;
        private Button btnCadastroEnviar;
        private Button btnCadastroVoltar;
        private Label lblCadastroBirthDate;
        private TextBox txbCadastroUserName;
        private Label lblCadastroUserName;
        private TextBox txbCadastroTypePassword;
        private Label lblCadastroTypePassword;
        private MaskedTextBox mtxBirthDate;
        private TextBox txbCadastroConfirmPassword;
        private Label lblCadastroConfirmPassword;
        private Label lblCadastroNameValidation;
        private Label lblCadastroBirthDateValidation;
        private Label lblCadastroUserNameValidation;
        private Label lblCadastroPasswordValidation;
        private Label lblCadastroPasswordConfirmValidation;
        private CheckBox chbCadastroMostrarSenha;
    }
}