namespace Portfolio.Presentation
{
    partial class FrmMovieDetail
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
            this.txbContaName = new System.Windows.Forms.TextBox();
            this.btnDetailSalvar = new System.Windows.Forms.Button();
            this.lblDetailNote = new System.Windows.Forms.Label();
            this.lblDetailTitle = new System.Windows.Forms.Label();
            this.lblDetailStudio = new System.Windows.Forms.Label();
            this.lblDetailCategory = new System.Windows.Forms.Label();
            this.btnDetailVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbContaName
            // 
            this.txbContaName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbContaName.Location = new System.Drawing.Point(52, 191);
            this.txbContaName.Multiline = true;
            this.txbContaName.Name = "txbContaName";
            this.txbContaName.Size = new System.Drawing.Size(496, 154);
            this.txbContaName.TabIndex = 1;
            // 
            // btnDetailSalvar
            // 
            this.btnDetailSalvar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDetailSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.btnDetailSalvar.Location = new System.Drawing.Point(338, 374);
            this.btnDetailSalvar.Name = "btnDetailSalvar";
            this.btnDetailSalvar.Size = new System.Drawing.Size(150, 45);
            this.btnDetailSalvar.TabIndex = 5;
            this.btnDetailSalvar.Text = "Salvar";
            this.btnDetailSalvar.UseVisualStyleBackColor = true;
            // 
            // lblDetailNote
            // 
            this.lblDetailNote.AutoSize = true;
            this.lblDetailNote.BackColor = System.Drawing.Color.Transparent;
            this.lblDetailNote.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetailNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.lblDetailNote.Location = new System.Drawing.Point(52, 170);
            this.lblDetailNote.Name = "lblDetailNote";
            this.lblDetailNote.Size = new System.Drawing.Size(112, 18);
            this.lblDetailNote.TabIndex = 40;
            this.lblDetailNote.Text = "Observações";
            // 
            // lblDetailTitle
            // 
            this.lblDetailTitle.AutoSize = true;
            this.lblDetailTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblDetailTitle.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetailTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.lblDetailTitle.Location = new System.Drawing.Point(303, 53);
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(127, 25);
            this.lblDetailTitle.TabIndex = 45;
            this.lblDetailTitle.Text = "Title (YYYY)";
            // 
            // lblDetailStudio
            // 
            this.lblDetailStudio.AutoSize = true;
            this.lblDetailStudio.BackColor = System.Drawing.Color.Transparent;
            this.lblDetailStudio.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetailStudio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.lblDetailStudio.Location = new System.Drawing.Point(303, 90);
            this.lblDetailStudio.Name = "lblDetailStudio";
            this.lblDetailStudio.Size = new System.Drawing.Size(53, 18);
            this.lblDetailStudio.TabIndex = 46;
            this.lblDetailStudio.Text = "Studio";
            // 
            // lblDetailCategory
            // 
            this.lblDetailCategory.AutoSize = true;
            this.lblDetailCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblDetailCategory.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetailCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.lblDetailCategory.Location = new System.Drawing.Point(303, 118);
            this.lblDetailCategory.Name = "lblDetailCategory";
            this.lblDetailCategory.Size = new System.Drawing.Size(72, 18);
            this.lblDetailCategory.TabIndex = 47;
            this.lblDetailCategory.Text = "Category";
            // 
            // btnDetailVoltar
            // 
            this.btnDetailVoltar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDetailVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.btnDetailVoltar.Location = new System.Drawing.Point(102, 374);
            this.btnDetailVoltar.Name = "btnDetailVoltar";
            this.btnDetailVoltar.Size = new System.Drawing.Size(150, 45);
            this.btnDetailVoltar.TabIndex = 48;
            this.btnDetailVoltar.Text = "Voltar";
            this.btnDetailVoltar.UseVisualStyleBackColor = true;
            // 
            // FrmMovieDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.btnDetailVoltar);
            this.Controls.Add(this.lblDetailCategory);
            this.Controls.Add(this.lblDetailStudio);
            this.Controls.Add(this.lblDetailTitle);
            this.Controls.Add(this.lblDetailNote);
            this.Controls.Add(this.btnDetailSalvar);
            this.Controls.Add(this.txbContaName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMovieDetail";
            this.Text = "FrmMovieDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbContaName;
        private Button btnDetailSalvar;
        private Label lblDetailNote;
        private Label lblDetailTitle;
        private Label lblDetailStudio;
        private Label lblDetailCategory;
        private Button btnDetailVoltar;
    }
}