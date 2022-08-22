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
            this.lblAbout = new System.Windows.Forms.Label();
            this.pnlAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAbout
            // 
            this.pnlAbout.Controls.Add(this.lblAbout);
            this.pnlAbout.Location = new System.Drawing.Point(64, 94);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(936, 520);
            this.pnlAbout.TabIndex = 0;
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAbout.Location = new System.Drawing.Point(3, 80);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(485, 184);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.Text = "Projeto do módulo 05: Técnicas de Programação.\r\nTurma 854 do Programa Top Coders/" +
    "Let\'s Code.\r\n\r\nLuiza Motta Campello - \r\n\r\nMarilia Castro -\r\n\r\nRobson Takeshi Nis" +
    "hikawa - ";
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.pnlAbout);
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
    }
}