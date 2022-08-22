using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portfolio.Presentation
{
    public partial class FrmPortfolio : Form
    {
        public FrmPortfolio()
        {
            InitializeComponent();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenu);
        }

        private void CustomizeDesign()
        {
            pnlSubMenu.Visible = false;
        }
        private void HideSubMenu()
        {
            if (pnlSubMenu.Visible == true)
                pnlSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FrmAccount account = new FrmAccount(username);
            //account.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Portfólio Cinematográfico\nTécnicas de Programação" +
                "\n\n" +
                "Autores:\n" +
                "- Luiza Campelo\n" +
                "- Marília Castro\n" +
                "- Robson Nishikawa", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var answer = DialogResult;
            answer = MessageBox.Show("Você tem certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                base.Close();
            }
        }

        private void btnPortfolio_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPortfolio portfolio = new FrmPortfolio();
            portfolio.Show();
        }

        private void btnNewSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSearch search = new FrmSearch();
            search.Show();
        }
    }
}
