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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbCadastroName
            // 
            this.txbCadastroName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(215)))), ((int)(((byte)(181)))));
            this.txbCadastroName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCadastroName.Location = new System.Drawing.Point(681, 295);
            this.txbCadastroName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCadastroName.Name = "txbCadastroName";
            this.txbCadastroName.Size = new System.Drawing.Size(457, 36);
            this.txbCadastroName.TabIndex = 0;
            this.txbCadastroName.TextChanged += new System.EventHandler(this.txbCadastroName_TextChanged);
            this.txbCadastroName.Leave += new System.EventHandler(this.txbCadastroName_Leave);
            // 
            // lblCadastroName
            // 
            this.lblCadastroName.AutoSize = true;
            this.lblCadastroName.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.lblCadastroName.Location = new System.Drawing.Point(681, 267);
            this.lblCadastroName.Name = "lblCadastroName";
            this.lblCadastroName.Size = new System.Drawing.Size(79, 25);
            this.lblCadastroName.TabIndex = 10;
            this.lblCadastroName.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.label2.Location = new System.Drawing.Point(681, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 57);
            this.label2.TabIndex = 9;
            this.label2.Text = " Aproveite as vantagens de ser um usuário do Portfólio Cinematográfico!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleCadastro
            // 
            this.lblTitleCadastro.AutoSize = true;
            this.lblTitleCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleCadastro.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.lblTitleCadastro.Location = new System.Drawing.Point(774, 131);
            this.lblTitleCadastro.Name = "lblTitleCadastro";
            this.lblTitleCadastro.Size = new System.Drawing.Size(325, 31);
            this.lblTitleCadastro.TabIndex = 8;
            this.lblTitleCadastro.Text = "Faça agora o seu cadastro";
            // 
            // btnCadastroEnviar
            // 
            this.btnCadastroEnviar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastroEnviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.btnCadastroEnviar.Location = new System.Drawing.Point(927, 793);
            this.btnCadastroEnviar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastroEnviar.Name = "btnCadastroEnviar";
            this.btnCadastroEnviar.Size = new System.Drawing.Size(171, 60);
            this.btnCadastroEnviar.TabIndex = 6;
            this.btnCadastroEnviar.Text = "Enviar";
            this.btnCadastroEnviar.UseVisualStyleBackColor = true;
            this.btnCadastroEnviar.Click += new System.EventHandler(this.btnCadastroEnviar_Click);
            // 
            // btnCadastroVoltar
            // 
            this.btnCadastroVoltar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastroVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.btnCadastroVoltar.Location = new System.Drawing.Point(719, 793);
            this.btnCadastroVoltar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastroVoltar.Name = "btnCadastroVoltar";
            this.btnCadastroVoltar.Size = new System.Drawing.Size(171, 60);
            this.btnCadastroVoltar.TabIndex = 7;
            this.btnCadastroVoltar.Text = "Voltar";
            this.btnCadastroVoltar.UseVisualStyleBackColor = true;
            this.btnCadastroVoltar.Click += new System.EventHandler(this.btnCadastroVoltar_Click);
            // 
            // lblCadastroBirthDate
            // 
            this.lblCadastroBirthDate.AutoSize = true;
            this.lblCadastroBirthDate.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroBirthDate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroBirthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.lblCadastroBirthDate.Location = new System.Drawing.Point(681, 369);
            this.lblCadastroBirthDate.Name = "lblCadastroBirthDate";
            this.lblCadastroBirthDate.Size = new System.Drawing.Size(223, 25);
            this.lblCadastroBirthDate.TabIndex = 14;
            this.lblCadastroBirthDate.Text = "Data de Nascimento:";
            // 
            // txbCadastroUserName
            // 
            this.txbCadastroUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(215)))), ((int)(((byte)(181)))));
            this.txbCadastroUserName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCadastroUserName.Location = new System.Drawing.Point(681, 493);
            this.txbCadastroUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCadastroUserName.Name = "txbCadastroUserName";
            this.txbCadastroUserName.Size = new System.Drawing.Size(457, 36);
            this.txbCadastroUserName.TabIndex = 2;
            this.txbCadastroUserName.TextChanged += new System.EventHandler(this.txbCadastroUserName_TextChanged);
            // 
            // lblCadastroUserName
            // 
            this.lblCadastroUserName.AutoSize = true;
            this.lblCadastroUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroUserName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.lblCadastroUserName.Location = new System.Drawing.Point(681, 465);
            this.lblCadastroUserName.Name = "lblCadastroUserName";
            this.lblCadastroUserName.Size = new System.Drawing.Size(192, 25);
            this.lblCadastroUserName.TabIndex = 16;
            this.lblCadastroUserName.Text = "Nome de usuário:";
            // 
            // txbCadastroTypePassword
            // 
            this.txbCadastroTypePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(215)))), ((int)(((byte)(181)))));
            this.txbCadastroTypePassword.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCadastroTypePassword.Location = new System.Drawing.Point(681, 593);
            this.txbCadastroTypePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCadastroTypePassword.Name = "txbCadastroTypePassword";
            this.txbCadastroTypePassword.Size = new System.Drawing.Size(457, 36);
            this.txbCadastroTypePassword.TabIndex = 3;
            this.txbCadastroTypePassword.UseSystemPasswordChar = true;
            this.txbCadastroTypePassword.TextChanged += new System.EventHandler(this.txbCadastroTypePassword_TextChanged);
            // 
            // lblCadastroTypePassword
            // 
            this.lblCadastroTypePassword.AutoSize = true;
            this.lblCadastroTypePassword.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroTypePassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroTypePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.lblCadastroTypePassword.Location = new System.Drawing.Point(681, 565);
            this.lblCadastroTypePassword.Name = "lblCadastroTypePassword";
            this.lblCadastroTypePassword.Size = new System.Drawing.Size(189, 25);
            this.lblCadastroTypePassword.TabIndex = 18;
            this.lblCadastroTypePassword.Text = "Digite sua senha:";
            // 
            // mtxBirthDate
            // 
            this.mtxBirthDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(215)))), ((int)(((byte)(181)))));
            this.mtxBirthDate.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxBirthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.mtxBirthDate.Location = new System.Drawing.Point(681, 397);
            this.mtxBirthDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtxBirthDate.Mask = "00/00/0000";
            this.mtxBirthDate.Name = "mtxBirthDate";
            this.mtxBirthDate.Size = new System.Drawing.Size(137, 36);
            this.mtxBirthDate.TabIndex = 1;
            this.mtxBirthDate.ValidatingType = typeof(System.DateTime);
            this.mtxBirthDate.TextChanged += new System.EventHandler(this.mtxBirthDate_TextChanged);
            this.mtxBirthDate.Leave += new System.EventHandler(this.mtxBirthDate_Leave);
            // 
            // txbCadastroConfirmPassword
            // 
            this.txbCadastroConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(215)))), ((int)(((byte)(181)))));
            this.txbCadastroConfirmPassword.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCadastroConfirmPassword.Location = new System.Drawing.Point(681, 693);
            this.txbCadastroConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCadastroConfirmPassword.Name = "txbCadastroConfirmPassword";
            this.txbCadastroConfirmPassword.Size = new System.Drawing.Size(457, 36);
            this.txbCadastroConfirmPassword.TabIndex = 4;
            this.txbCadastroConfirmPassword.UseSystemPasswordChar = true;
            this.txbCadastroConfirmPassword.TextChanged += new System.EventHandler(this.txbCadastroConfirmPassword_TextChanged);
            // 
            // lblCadastroConfirmPassword
            // 
            this.lblCadastroConfirmPassword.AutoSize = true;
            this.lblCadastroConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroConfirmPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.lblCadastroConfirmPassword.Location = new System.Drawing.Point(681, 665);
            this.lblCadastroConfirmPassword.Name = "lblCadastroConfirmPassword";
            this.lblCadastroConfirmPassword.Size = new System.Drawing.Size(222, 25);
            this.lblCadastroConfirmPassword.TabIndex = 22;
            this.lblCadastroConfirmPassword.Text = "Confirme sua senha:";
            // 
            // lblCadastroNameValidation
            // 
            this.lblCadastroNameValidation.AutoSize = true;
            this.lblCadastroNameValidation.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroNameValidation.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroNameValidation.Location = new System.Drawing.Point(681, 341);
            this.lblCadastroNameValidation.Name = "lblCadastroNameValidation";
            this.lblCadastroNameValidation.Size = new System.Drawing.Size(0, 18);
            this.lblCadastroNameValidation.TabIndex = 24;
            // 
            // lblCadastroBirthDateValidation
            // 
            this.lblCadastroBirthDateValidation.AutoSize = true;
            this.lblCadastroBirthDateValidation.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroBirthDateValidation.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroBirthDateValidation.Location = new System.Drawing.Point(681, 447);
            this.lblCadastroBirthDateValidation.Name = "lblCadastroBirthDateValidation";
            this.lblCadastroBirthDateValidation.Size = new System.Drawing.Size(0, 18);
            this.lblCadastroBirthDateValidation.TabIndex = 25;
            // 
            // lblCadastroUserNameValidation
            // 
            this.lblCadastroUserNameValidation.AutoSize = true;
            this.lblCadastroUserNameValidation.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroUserNameValidation.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroUserNameValidation.Location = new System.Drawing.Point(681, 541);
            this.lblCadastroUserNameValidation.Name = "lblCadastroUserNameValidation";
            this.lblCadastroUserNameValidation.Size = new System.Drawing.Size(0, 18);
            this.lblCadastroUserNameValidation.TabIndex = 26;
            // 
            // lblCadastroPasswordValidation
            // 
            this.lblCadastroPasswordValidation.AutoSize = true;
            this.lblCadastroPasswordValidation.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroPasswordValidation.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroPasswordValidation.Location = new System.Drawing.Point(683, 640);
            this.lblCadastroPasswordValidation.Name = "lblCadastroPasswordValidation";
            this.lblCadastroPasswordValidation.Size = new System.Drawing.Size(0, 18);
            this.lblCadastroPasswordValidation.TabIndex = 27;
            // 
            // lblCadastroPasswordConfirmValidation
            // 
            this.lblCadastroPasswordConfirmValidation.AutoSize = true;
            this.lblCadastroPasswordConfirmValidation.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroPasswordConfirmValidation.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCadastroPasswordConfirmValidation.Location = new System.Drawing.Point(685, 739);
            this.lblCadastroPasswordConfirmValidation.Name = "lblCadastroPasswordConfirmValidation";
            this.lblCadastroPasswordConfirmValidation.Size = new System.Drawing.Size(0, 18);
            this.lblCadastroPasswordConfirmValidation.TabIndex = 28;
            // 
            // chbCadastroMostrarSenha
            // 
            this.chbCadastroMostrarSenha.AutoSize = true;
            this.chbCadastroMostrarSenha.BackColor = System.Drawing.Color.Transparent;
            this.chbCadastroMostrarSenha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbCadastroMostrarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.chbCadastroMostrarSenha.Location = new System.Drawing.Point(1003, 743);
            this.chbCadastroMostrarSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbCadastroMostrarSenha.Name = "chbCadastroMostrarSenha";
            this.chbCadastroMostrarSenha.Size = new System.Drawing.Size(139, 22);
            this.chbCadastroMostrarSenha.TabIndex = 5;
            this.chbCadastroMostrarSenha.Text = "Mostrar Senha";
            this.chbCadastroMostrarSenha.UseVisualStyleBackColor = false;
            this.chbCadastroMostrarSenha.CheckedChanged += new System.EventHandler(this.chbCadastroMostrarSenha_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Portfolio.Presentation.Properties.Resources.logotipo_do_filme_10250_3708_1_;
            this.pictureBox1.Location = new System.Drawing.Point(878, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = global::Portfolio.Presentation.Properties.Resources.loginScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1216, 908);
            this.Controls.Add(this.pictureBox1);
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
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private PictureBox pictureBox1;
    }
}