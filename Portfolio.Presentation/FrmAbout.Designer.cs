namespace Portfolio.Presentation
{
    partial class FrmAbout
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
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAbout
            // 
            this.pnlAbout.BackColor = System.Drawing.Color.Transparent;
            this.pnlAbout.Controls.Add(this.btnReturn);
            this.pnlAbout.Controls.Add(this.label1);
            this.pnlAbout.Controls.Add(this.lblAbout);
            this.pnlAbout.Location = new System.Drawing.Point(70, 263);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(938, 384);
            this.pnlAbout.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(269, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "github.com/luizacampello";
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(66)))), ((int)(((byte)(16)))));
            this.lblAbout.Location = new System.Drawing.Point(16, 21);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(535, 200);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.Text = "Projeto do módulo 05: Técnicas de Programação.\r\nTurma 854 do Programa Top Coders/" +
    "Let\'s Code.\r\n\r\nLuiza Motta Campello - \r\n\r\nMarilia Castro -\r\n\r\nRobson Takeshi Nis" +
    "hikawa - ";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.White;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(100)))), ((int)(((byte)(12)))));
            this.btnReturn.Location = new System.Drawing.Point(389, 327);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(161, 45);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Voltar";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Portfolio.Presentation.Properties.Resources.Portfólio_Cinematográfico;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.pnlAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAbout";
            this.pnlAbout.ResumeLayout(false);
            this.pnlAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlAbout;
        private Label lblAbout;
        private Label label1;
        private Button btnReturn;
    }
}